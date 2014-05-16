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
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UploadersLib.FileUploaders;
using UploadersLib.HelperClasses;
using UploadersLib.Properties;

namespace UploadersLib.Forms
{
    public partial class DropboxFilesForm : Form
    {
        public string CurrentFolderPath { get; private set; }

        private Dropbox dropbox;
        private DropboxAccountInfo dropboxAccountInfo;
        private ImageListManager ilm;
        private bool isSelectedFile, isSelectedPublic;

        public DropboxFilesForm(OAuthInfo oauth, string path, DropboxAccountInfo accountInfo)
        {
            InitializeComponent();
            Icon = Resources.Dropbox;

            dropbox = new Dropbox(oauth);
            dropboxAccountInfo = accountInfo;
            ilm = new ImageListManager(lvDropboxFiles);

            if (path != null)
            {
                Shown += (sender, e) => OpenDirectory(path);
            }
        }

        public async void OpenDirectory(string path)
        {
            lvDropboxFiles.Items.Clear();

            DropboxContentInfo contentInfo = await TaskEx.Run(() => dropbox.GetMetadata(path, true));

            if (contentInfo != null)
            {
                lvDropboxFiles.Tag = contentInfo;

                ListViewItem lvi = GetParentFolder(contentInfo.Path);

                if (lvi != null)
                {
                    lvDropboxFiles.Items.Add(lvi);
                }

                foreach (DropboxContentInfo content in contentInfo.Contents.OrderBy(x => !x.Is_dir))
                {
                    string filename = Path.GetFileName(content.Path);
                    lvi = new ListViewItem(filename);
                    lvi.SubItems.Add(content.Is_dir ? "" : content.Size);
                    DateTime modified;
                    if (DateTime.TryParse(content.Modified, out modified))
                    {
                        lvi.SubItems.Add(modified.ToString());
                    }
                    lvi.ImageKey = ilm.AddImage(content.Icon);
                    lvi.Tag = content;
                    lvDropboxFiles.Items.Add(lvi);
                }

                CurrentFolderPath = contentInfo.Path.Trim('/');
                Text = "Dropbox - " + CurrentFolderPath;
            }
            else
            {
                MessageBox.Show("Path not exist: " + path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshDirectory()
        {
            OpenDirectory(CurrentFolderPath);
        }

        public ListViewItem GetParentFolder(string currentPath)
        {
            if (!string.IsNullOrEmpty(currentPath))
            {
                string parentFolder = currentPath.Remove(currentPath.LastIndexOf('/'));

                DropboxContentInfo content = new DropboxContentInfo { Icon = "folder", Is_dir = true, Path = parentFolder };

                ListViewItem lvi = new ListViewItem("..");
                lvi.ImageKey = ilm.AddImage(content.Icon);
                lvi.Tag = content;
                return lvi;
            }

            return null;
        }

        private void lvDropboxFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lvDropboxFiles.SelectedItems.Count > 0)
            {
                DropboxContentInfo content = lvDropboxFiles.SelectedItems[0].Tag as DropboxContentInfo;

                if (content != null && content.Is_dir)
                {
                    OpenDirectory(content.Path);
                }
            }
        }

        private void tsbSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void tsmiCopyPublicLink_Click(object sender, EventArgs e)
        {
            if (lvDropboxFiles.SelectedItems.Count > 0)
            {
                DropboxContentInfo content = lvDropboxFiles.SelectedItems[0].Tag as DropboxContentInfo;

                if (content != null && !content.Is_dir && content.Path.StartsWith("/Public/", StringComparison.InvariantCultureIgnoreCase))
                {
                    string url = Dropbox.GetPublicURL(dropboxAccountInfo.Uid, content.Path);
                    ClipboardHelpers.CopyText(url);
                }
            }
        }

        private void tsmiDownloadFile_Click(object sender, EventArgs e)
        {
            if (lvDropboxFiles.SelectedItems.Count > 0)
            {
                DropboxContentInfo content = lvDropboxFiles.SelectedItems[0].Tag as DropboxContentInfo;

                if (content != null && !content.Is_dir)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.FileName = Path.GetFileName(content.Path);

                        if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                        {
                            using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.Read))
                            {
                                dropbox.DownloadFile(content.Path, fileStream);
                            }
                        }
                    }
                }
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (lvDropboxFiles.SelectedItems.Count > 0)
            {
                DropboxContentInfo content = lvDropboxFiles.SelectedItems[0].Tag as DropboxContentInfo;

                if (content != null)
                {
                    if (MessageBox.Show("Are you sure you want to delete '" + Path.GetFileName(content.Path) + "' from your Dropbox?", "Dropbox - Delete file?",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dropbox.Delete(content.Path);
                        RefreshDirectory();
                    }
                }
            }
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            RefreshDirectory();
        }

        private void tsmiCreateDirectory_Click(object sender, EventArgs e)
        {
            using (InputBox ib = new InputBox { Text = "Dropbox - Create directory", Question = "Please enter the name of the directory which should be created:" })
            {
                if (ib.ShowDialog() == DialogResult.OK)
                {
                    string path = Helpers.CombineURL(CurrentFolderPath, ib.InputText);
                    dropbox.CreateFolder(path);
                    RefreshDirectory();
                }
            }
        }

        private void lvDropboxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDropboxFiles.SelectedItems.Count > 0)
            {
                DropboxContentInfo content = lvDropboxFiles.SelectedItems[0].Tag as DropboxContentInfo;

                if (content != null)
                {
                    isSelectedFile = !content.Is_dir;
                    isSelectedPublic = content.Path.StartsWith("/Public/", StringComparison.InvariantCultureIgnoreCase);
                }
            }

            RefreshMenu();
        }

        private void RefreshMenu()
        {
            tsmiCopyPublicLink.Visible = isSelectedFile && isSelectedPublic;
            tsmiDownloadFile.Visible = isSelectedFile;
        }

        private void cmsDropbox_Opening(object sender, CancelEventArgs e)
        {
            RefreshMenu();
        }
    }
}