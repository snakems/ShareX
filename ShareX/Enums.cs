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

using System;
using System.ComponentModel;

namespace ShareX
{
    public enum EImageFormat
    {
        [Description("png")]
        PNG,
        [Description("jpg")]
        JPEG,
        [Description("gif")]
        GIF,
        [Description("bmp")]
        BMP,
        [Description("tif")]
        TIFF
    }

    public enum TaskJob
    {
        Job,
        DataUpload,
        FileUpload,
        TextUpload,
        ShortenURL,
        ShareURL
    }

    [Flags]
    public enum AfterCaptureTasks
    {
        None = 0,
        [Description("Add image effects")]
        AddImageEffects = 1,
        [Description("Add watermark")]
        AddWatermark = 1 << 1,
        [Description("Annotate image")]
        AnnotateImage = 1 << 2,
        [Description("Copy image to clipboard")]
        CopyImageToClipboard = 1 << 3,
        [Description("Print image")]
        SendImageToPrinter = 1 << 4,
        [Description("Save image to file")]
        SaveImageToFile = 1 << 5,
        [Description("Save image to file as...")]
        SaveImageToFileWithDialog = 1 << 6,
        [Description("Save thumbnail image to file")]
        SaveThumbnailImageToFile = 1 << 7,
        [Description("Copy file to clipboard")]
        CopyFileToClipboard = 1 << 8,
        [Description("Copy file path to clipboard")]
        CopyFilePathToClipboard = 1 << 9,
        [Description("Perform actions")]
        PerformActions = 1 << 10,
        [Description("Upload image to host")]
        UploadImageToHost = 1 << 11,
        [Description("Delete file locally")]
        DeleteFile = 1 << 12
    }

    [Flags]
    public enum AfterUploadTasks
    {
        None = 0,
        [Description("Shorten URL")]
        UseURLShortener = 1,
        [Description("Share URL")]
        ShareURL = 1 << 1,
        [Description("Copy URL to clipboard")]
        CopyURLToClipboard = 1 << 2,
        [Description("Open URL")]
        OpenURL = 1 << 3,
        [Description("Show QR code window")]
        ShowQRCode = 1 << 4
    }

    public enum AfterCaptureFormResult
    {
        Cancel,
        Continue,
        Copy
    }

    public enum CaptureType
    {
        Screen,
        Monitor,
        ActiveMonitor,
        Window,
        ActiveWindow,
        RectangleWindow,
        Rectangle,
        RoundedRectangle,
        Ellipse,
        Triangle,
        Diamond,
        Polygon,
        Freehand,
        LastRegion
    }

    public enum HotkeyType
    {
        [Description("None")]
        None,
        [Description("Upload file")]
        FileUpload,
        [Description("Upload folder")]
        FolderUpload,
        [Description("Upload from clipboard")]
        ClipboardUpload,
        [Description("Upload from clipboard with content viewer")]
        ClipboardUploadWithContentViewer,
        [Description("Upload from URL")]
        UploadURL,
        [Description("Drag and drop upload")]
        DragDropUpload,
        [Description("Stop all active uploads")]
        StopUploads,
        [Description("Capture entire screen")]
        PrintScreen,
        [Description("Capture active window")]
        ActiveWindow,
        [Description("Capture active monitor")]
        ActiveMonitor,
        [Description("Capture rectangle region")]
        RectangleRegion,
        [Description("Capture rectangle region (Window)")]
        WindowRectangle,
        [Description("Capture rectangle region (Annotate)")]
        RectangleAnnotate,
        [Description("Capture rectangle region (Light)")]
        RectangleLight,
        [Description("Capture rounded rectangle region")]
        RoundedRectangleRegion,
        [Description("Capture ellipse region")]
        EllipseRegion,
        [Description("Capture triangle region")]
        TriangleRegion,
        [Description("Capture diamond region")]
        DiamondRegion,
        [Description("Capture polygon region")]
        PolygonRegion,
        [Description("Capture freehand region")]
        FreeHandRegion,
        [Description("Capture last region")]
        LastRegion,
        [Description("Screen recording")]
        ScreenRecorder,
        [Description("Auto capture")]
        AutoCapture,
        [Description("Open screenshots folder")]
        OpenScreenshotsFolder,
        [Description("Screen color picker")]
        ScreenColorPicker,
        [Description("Ruler")]
        Ruler,
        [Description("FTP client")]
        FTPClient,
        [Description("Hash check")]
        HashCheck,
        [Description("Index folder")]
        IndexFolder,
        [Description("Image effects")]
        ImageEffects,
        [Description("QR code")]
        QRCode,
        [Description("Tweet message")]
        TweetMessage
    }

    public enum HotkeyStatus
    {
        Registered,
        Failed,
        NotConfigured
    }

    public enum PopUpNotificationType
    {
        [Description("Show nothing")]
        None,
        [Description("Show tray balloon tip")]
        BalloonTip,
        [Description("Show toast notification with preview")]
        ToastNotification
    }

    [DefaultValue(ToastClickAction.OpenUrl)]
    public enum ToastClickAction
    {
        [Description("Annotate image")]
        AnnotateImage,
        [Description("Copy image to clipboard")]
        CopyImageToClipboard,
        [Description("Open file")]
        OpenFile,
        [Description("Open folder")]
        OpenFolder,
        [Description("Open URL")]
        OpenUrl,
        [Description("Upload")]
        Upload,
    }

    public enum FileExistAction
    {
        [Description("Ask what to do")]
        Ask,
        [Description("Overwrite file")]
        Overwrite,
        [Description("Append number to the filename")]
        UniqueName,
        [Description("Do not save")]
        Cancel
    }

    public enum ImagePreviewVisibility
    {
        Show, Hide, Automatic
    }
}