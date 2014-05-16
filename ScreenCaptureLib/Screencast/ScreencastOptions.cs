﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (C) 2007-2014 ShareX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using HelpersLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace ScreenCaptureLib
{
    public class ScreencastOptions
    {
        public string OutputPath;
        public int GIFFPS;
        public int ScreenRecordFPS;
        public Rectangle CaptureArea;
        public float Duration;
        public bool DrawCursor;

        public IntPtr ParentWindow;
        public bool ShowAVIOptionsDialog;
        public AVIOptions AVI = new AVIOptions();

        public FFmpegOptions FFmpeg = new FFmpegOptions();

        public string GetFFmpegArgs()
        {
            StringBuilder args = new StringBuilder();

            // input FPS
            args.AppendFormat("-r {0} ", ScreenRecordFPS);

            if (string.IsNullOrEmpty(FFmpeg.VideoSource) || FFmpeg.VideoSource.Equals(FFmpegHelper.GDIgrab, StringComparison.InvariantCultureIgnoreCase))
            {
                // http://ffmpeg.org/ffmpeg-devices.html#gdigrab
                args.AppendFormat("-f gdigrab -framerate {0} -offset_x {1} -offset_y {2} -video_size {3}x{4} -draw_mouse {5} -show_region {6} -i desktop ",
                    ScreenRecordFPS, CaptureArea.X, CaptureArea.Y, CaptureArea.Width, CaptureArea.Height, DrawCursor ? 1 : 0, 0);

                if (FFmpeg.IsAudioSourceSelected())
                {
                    args.AppendFormat("-f dshow -i audio=\"{0}\" ", FFmpeg.AudioSource);
                }
            }
            else
            {
                // https://github.com/rdp/screen-capture-recorder-to-video-windows-free configuration section
                string dshowRegistryPath = "Software\\screen-capture-recorder";
                RegistryHelpers.CreateRegistry(dshowRegistryPath, "start_x", CaptureArea.X);
                RegistryHelpers.CreateRegistry(dshowRegistryPath, "start_y", CaptureArea.Y);
                RegistryHelpers.CreateRegistry(dshowRegistryPath, "capture_width", CaptureArea.Width);
                RegistryHelpers.CreateRegistry(dshowRegistryPath, "capture_height", CaptureArea.Height);
                RegistryHelpers.CreateRegistry(dshowRegistryPath, "default_max_fps", ScreenRecordFPS);
                RegistryHelpers.CreateRegistry(dshowRegistryPath, "capture_mouse_default_1", DrawCursor ? 1 : 0);

                args.Append("-f dshow -i ");

                // dshow audio/video device: https://github.com/rdp/screen-capture-recorder-to-video-windows-free
                args.AppendFormat("video=\"{0}\"", FFmpeg.VideoSource);

                if (FFmpeg.IsAudioSourceSelected())
                {
                    args.AppendFormat(":audio=\"{0}\" ", FFmpeg.AudioSource);
                }
                else
                {
                    args.Append(" ");
                }
            }

            if (!string.IsNullOrEmpty(FFmpeg.UserArgs))
            {
                args.Append(FFmpeg.UserArgs + " ");
            }

            args.AppendFormat("-c:v {0} ", FFmpeg.VideoCodec.ToString());

            // output FPS
            args.AppendFormat("-r {0} ", ScreenRecordFPS);

            switch (FFmpeg.VideoCodec)
            {
                case FFmpegVideoCodec.libx264: // https://trac.ffmpeg.org/wiki/x264EncodingGuide
                    args.AppendFormat("-crf {0} ", FFmpeg.x264_CRF);
                    args.AppendFormat("-preset {0} ", FFmpeg.Preset.ToString());
                    break;
                case FFmpegVideoCodec.libvpx: // https://trac.ffmpeg.org/wiki/vpxEncodingGuide
                    args.AppendFormat("-crf {0} ", FFmpeg.VPx_CRF);
                    break;
                case FFmpegVideoCodec.libxvid: // https://trac.ffmpeg.org/wiki/How%20to%20encode%20Xvid%20/%20DivX%20video%20with%20ffmpeg
                    args.AppendFormat("-qscale:v {0} ", FFmpeg.XviD_qscale);
                    break;
            }

            // -pix_fmt yuv420p required for libx264 otherwise can't stream in Chrome
            if (FFmpeg.VideoCodec == FFmpegVideoCodec.libx264)
            {
                args.Append("-pix_fmt yuv420p -tune zerolatency ");
            }

            if (FFmpeg.IsAudioSourceSelected())
            {
                switch (FFmpeg.AudioCodec)
                {
                    case FFmpegAudioCodec.libvorbis: // http://trac.ffmpeg.org/wiki/TheoraVorbisEncodingGuide
                        args.AppendFormat("-c:a {0} -qscale:a {1} ", FFmpegAudioCodec.libvorbis.ToString(), FFmpeg.Vorbis_qscale);
                        break;
                    case FFmpegAudioCodec.libmp3lame: // http://trac.ffmpeg.org/wiki/Encoding%20VBR%20(Variable%20Bit%20Rate)%20mp3%20audio
                        args.AppendFormat("-c:a {0} -qscale:a {1} ", FFmpegAudioCodec.libmp3lame.ToString(), FFmpeg.MP3_qscale);
                        break;
                    case FFmpegAudioCodec.libvoaacenc: // http://trac.ffmpeg.org/wiki/AACEncodingGuide
                        args.AppendFormat("-c:a libvo_aacenc -ac 2 -b:a {0}k ", FFmpeg.AAC_bitrate); // -ac 2 required otherwise failing with 7.1
                        break;
                }
            }

            if (Duration > 0)
            {
                args.AppendFormat("-t {0} ", Duration);
            }

            // -y for overwrite file
            args.Append("-y ");

            args.AppendFormat("\"{0}\"", Path.ChangeExtension(OutputPath, FFmpeg.Extension));

            return args.ToString();
        }
    }
}