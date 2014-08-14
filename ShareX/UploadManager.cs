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
using IndexerLib;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using UploadersLib;

namespace ShareX
{
    public static class UploadManager
    {
        public static void UploadFile(string filePath, TaskSettings taskSettings = null)
        {
            if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

            if (!string.IsNullOrEmpty(filePath))
            {
                if (File.Exists(filePath))
                {
                    UploadTask task = UploadTask.CreateFileUploaderTask(filePath, taskSettings);
                    TaskManager.Start(task);
                }
                else if (Directory.Exists(filePath))
                {
                    string[] files = Directory.GetFiles(filePath, "*.*", SearchOption.AllDirectories);
                    UploadFile(files, taskSettings);
                }
            }
        }

        public static void UploadFile(string[] files, TaskSettings taskSettings = null)
        {
            if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

            if (files != null && files.Length > 0)
            {
                if (files.Length <= 10 || IsUploadConfirmed(files.Length))
                {
                    foreach (string file in files)
                    {
                        UploadFile(file, taskSettings);
                    }
                }
            }
        }

        private static bool IsUploadConfirmed(int length)
        {
            if (Program.Settings.ShowMultiUploadWarning)
            {
                using (MyMessageBox msgbox = new MyMessageBox("Are you sure you want to upload " + length + " files?", "ShareX - Upload files",
                    MessageBoxButtons.YesNo, "Don't show this message again."))
                {
                    msgbox.ShowDialog();
                    Program.Settings.ShowMultiUploadWarning = !msgbox.IsChecked;
                    return msgbox.DialogResult == DialogResult.Yes;
                }
            }

            return true;
        }

        public static void UploadFile(TaskSettings taskSettings = null)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "ShareX - File upload";

                if (!string.IsNullOrEmpty(Program.Settings.FileUploadDefaultDirectory) && Directory.Exists(Program.Settings.FileUploadDefaultDirectory))
                {
                    ofd.InitialDirectory = Program.Settings.FileUploadDefaultDirectory;
                }
                else
                {
                    ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }

                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(ofd.FileName))
                    {
                        Program.Settings.FileUploadDefaultDirectory = Path.GetDirectoryName(ofd.FileName);
                    }

                    UploadFile(ofd.FileNames);
                }
            }
        }

        public static void UploadFolder(TaskSettings taskSettings = null)
        {
            using (FolderSelectDialog folderDialog = new FolderSelectDialog())
            {
                folderDialog.Title = "ShareX - Folder upload";

                if (!string.IsNullOrEmpty(Program.Settings.FileUploadDefaultDirectory) && Directory.Exists(Program.Settings.FileUploadDefaultDirectory))
                {
                    folderDialog.InitialDirectory = Program.Settings.FileUploadDefaultDirectory;
                }
                else
                {
                    folderDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }

                if (folderDialog.ShowDialog() && !string.IsNullOrEmpty(folderDialog.FileName))
                {
                    Program.Settings.FileUploadDefaultDirectory = folderDialog.FileName;
                    UploadFile(folderDialog.FileName);
                }
            }
        }

        public static void IndexFolder(TaskSettings taskSettings = null)
        {
            using (FolderSelectDialog dlg = new FolderSelectDialog())
            {
                if (dlg.ShowDialog())
                {
                    IndexFolder(dlg.FileName, taskSettings);
                }
            }
        }

        public static void IndexFolder(string folderPath, TaskSettings taskSettings = null)
        {
            if (!string.IsNullOrEmpty(folderPath) && Directory.Exists(folderPath))
            {
                if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

                taskSettings.IndexerSettings.BinaryUnits = Program.Settings.BinaryUnits;
                string text = Indexer.Index(folderPath, taskSettings.IndexerSettings);
                UploadTask task = UploadTask.CreateTextUploaderTask(text, taskSettings);
                task.Info.FileName = Path.ChangeExtension(task.Info.FileName, taskSettings.IndexerSettings.Output.ToString().ToLower());
                TaskManager.Start(task);
            }
        }

        public static void ClipboardUpload(TaskSettings taskSettings = null)
        {
            if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

            if (Clipboard.ContainsImage())
            {
                Image img = Clipboard.GetImage();

                if (img != null)
                {
                    if (!taskSettings.AdvancedSettings.ProcessImagesDuringClipboardUpload)
                    {
                        taskSettings.AfterCaptureJob = AfterCaptureTasks.UploadImageToHost;
                    }

                    RunImageTask(img, taskSettings);
                }
            }
            else if (Clipboard.ContainsFileDropList())
            {
                string[] files = Clipboard.GetFileDropList().Cast<string>().ToArray();
                UploadFile(files, taskSettings);
            }
            else if (Clipboard.ContainsText())
            {
                string text = Clipboard.GetText();

                if (!string.IsNullOrEmpty(text))
                {
                    string url = text.Trim();

                    if (URLHelpers.IsValidURLRegex(url))
                    {
                        if (taskSettings.UploadSettings.ClipboardUploadURLContents)
                        {
                            string filename = URLHelpers.GetFileName(url, true);

                            if (!string.IsNullOrEmpty(filename))
                            {
                                DownloadAndUploadFile(url, filename, taskSettings);
                                return;
                            }
                        }

                        if (taskSettings.UploadSettings.ClipboardUploadShortenURL)
                        {
                            ShortenURL(url, taskSettings);
                            return;
                        }

                        if (taskSettings.UploadSettings.ClipboardUploadShareURL)
                        {
                            ShareURL(url, taskSettings);
                            return;
                        }
                    }

                    if (taskSettings.UploadSettings.ClipboardUploadAutoIndexFolder && text.Length <= 260 && Directory.Exists(text))
                    {
                        IndexFolder(text, taskSettings);
                    }
                    else
                    {
                        UploadText(text, taskSettings);
                    }
                }
            }
        }

        public static void ClipboardUploadWithContentViewer(TaskSettings taskSettings = null)
        {
            if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

            using (ClipboardContentViewer ccv = new ClipboardContentViewer())
            {
                if (ccv.ShowDialog() == DialogResult.OK && !ccv.IsClipboardEmpty)
                {
                    ClipboardUpload(taskSettings);
                }
            }
        }

        public static void ClipboardUploadMainWindow(TaskSettings taskSettings = null)
        {
            if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

            if (Program.Settings.ShowClipboardContentViewer)
            {
                using (ClipboardContentViewer ccv = new ClipboardContentViewer(true))
                {
                    if (ccv.ShowDialog() == DialogResult.OK && !ccv.IsClipboardEmpty)
                    {
                        ClipboardUpload(taskSettings);
                    }

                    Program.Settings.ShowClipboardContentViewer = !ccv.DontShowThisWindow;
                }
            }
            else
            {
                ClipboardUpload(taskSettings);
            }
        }

        public static void DragDropUpload(IDataObject data, TaskSettings taskSettings = null)
        {
            if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

            if (data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] files = data.GetData(DataFormats.FileDrop, false) as string[];
                UploadFile(files, taskSettings);
            }
            else if (data.GetDataPresent(DataFormats.Bitmap, false))
            {
                Image img = data.GetData(DataFormats.Bitmap, false) as Image;
                RunImageTask(img, taskSettings);
            }
            else if (data.GetDataPresent(DataFormats.Text, false))
            {
                string text = data.GetData(DataFormats.Text, false) as string;
                UploadText(text, taskSettings);
            }
        }

        public static void UploadURL(TaskSettings taskSettings = null)
        {
            if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

            string url = InputBox.GetInputText("ShareX - URL to download from and upload");

            if (!string.IsNullOrEmpty(url))
            {
                string filename = URLHelpers.GetFileName(url, true);

                if (!string.IsNullOrEmpty(filename))
                {
                    DownloadAndUploadFile(url, filename, taskSettings);
                }
            }
        }

        public static void RunImageTask(Image img, TaskSettings taskSettings)
        {
            if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

            if (img != null && taskSettings != null)
            {
                UploadTask task = UploadTask.CreateImageUploaderTask(img, taskSettings);
                TaskManager.Start(task);
            }
        }

        public static void UploadImage(Image img)
        {
            if (img != null)
            {
                TaskSettings taskSettings = TaskSettings.GetDefaultTaskSettings();
                taskSettings.UseDefaultAfterCaptureJob = false;
                taskSettings.AfterCaptureJob = AfterCaptureTasks.UploadImageToHost;

                RunImageTask(img, taskSettings);
            }
        }

        public static void UploadImage(Image img, ImageDestination imageDestination)
        {
            if (img != null)
            {
                TaskSettings taskSettings = TaskSettings.GetDefaultTaskSettings();
                taskSettings.UseDefaultAfterCaptureJob = false;
                taskSettings.AfterCaptureJob = AfterCaptureTasks.UploadImageToHost;
                taskSettings.UseDefaultDestinations = false;
                taskSettings.ImageDestination = imageDestination;

                RunImageTask(img, taskSettings);
            }
        }

        public static void UploadText(string text, TaskSettings taskSettings = null)
        {
            if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

            if (!string.IsNullOrEmpty(text))
            {
                UploadTask task = UploadTask.CreateTextUploaderTask(text, taskSettings);
                TaskManager.Start(task);
            }
        }

        public static void UploadImageStream(Stream stream, string filename, TaskSettings taskSettings = null)
        {
            if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

            if (stream != null && stream.Length > 0 && !string.IsNullOrEmpty(filename))
            {
                UploadTask task = UploadTask.CreateDataUploaderTask(EDataType.Image, stream, filename, taskSettings);
                TaskManager.Start(task);
            }
        }

        public static void ShortenURL(string url, TaskSettings taskSettings = null)
        {
            if (!string.IsNullOrEmpty(url))
            {
                if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

                UploadTask task = UploadTask.CreateURLShortenerTask(url, taskSettings);
                TaskManager.Start(task);
            }
        }

        public static void ShortenURL(string url, UrlShortenerType urlShortener)
        {
            if (!string.IsNullOrEmpty(url))
            {
                TaskSettings taskSettings = TaskSettings.GetDefaultTaskSettings();
                taskSettings.URLShortenerDestination = urlShortener;

                UploadTask task = UploadTask.CreateURLShortenerTask(url, taskSettings);
                TaskManager.Start(task);
            }
        }

        public static void ShareURL(string url, TaskSettings taskSettings = null)
        {
            if (!string.IsNullOrEmpty(url))
            {
                if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

                UploadTask task = UploadTask.CreateShareURLTask(url, taskSettings);
                TaskManager.Start(task);
            }
        }

        public static void ShareURL(string url, URLSharingServices urlSharingService)
        {
            if (!string.IsNullOrEmpty(url))
            {
                TaskSettings taskSettings = TaskSettings.GetDefaultTaskSettings();
                taskSettings.URLSharingServiceDestination = urlSharingService;

                UploadTask task = UploadTask.CreateShareURLTask(url, taskSettings);
                TaskManager.Start(task);
            }
        }

        public static void DownloadAndUploadFile(string url, string filename, TaskSettings taskSettings = null)
        {
            if (!string.IsNullOrEmpty(url))
            {
                if (taskSettings == null) taskSettings = TaskSettings.GetDefaultTaskSettings();

                string downloadPath = null;
                bool isDownloaded = false;

                TaskEx.Run(() =>
                {
                    downloadPath = TaskHelpers.CheckFilePath(taskSettings.CaptureFolder, filename, taskSettings);

                    if (!string.IsNullOrEmpty(downloadPath))
                    {
                        try
                        {
                            using (WebClient wc = new WebClient())
                            {
                                wc.Proxy = ProxyInfo.Current.GetWebProxy();
                                wc.DownloadFile(url, downloadPath);
                            }

                            isDownloaded = true;
                        }
                        catch (Exception e)
                        {
                            DebugHelper.WriteException(e);
                            MessageBox.Show("Download failed:\r\n" + e.ToString(), "ShareX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                },
                () =>
                {
                    if (isDownloaded)
                    {
                        UploadFile(downloadPath, taskSettings);
                    }
                });
            }
        }
    }
}