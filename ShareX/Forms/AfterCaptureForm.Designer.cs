﻿namespace ShareX
{
    partial class AfterCaptureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvAfterCaptureTasks = new System.Windows.Forms.ListView();
            this.chAfterCapture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbImage = new HelpersLib.MyPictureBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tcTasks = new System.Windows.Forms.TabControl();
            this.tpAfterCapture = new System.Windows.Forms.TabPage();
            this.tpBeforeUpload = new System.Windows.Forms.TabPage();
            this.ucBeforeUpload = new ShareX.BeforeUploadControl();
            this.tcTasks.SuspendLayout();
            this.tpAfterCapture.SuspendLayout();
            this.tpBeforeUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAfterCaptureTasks
            // 
            this.lvAfterCaptureTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAfterCapture});
            this.lvAfterCaptureTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAfterCaptureTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvAfterCaptureTasks.FullRowSelect = true;
            this.lvAfterCaptureTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvAfterCaptureTasks.Location = new System.Drawing.Point(3, 3);
            this.lvAfterCaptureTasks.MultiSelect = false;
            this.lvAfterCaptureTasks.Name = "lvAfterCaptureTasks";
            this.lvAfterCaptureTasks.Scrollable = false;
            this.lvAfterCaptureTasks.Size = new System.Drawing.Size(290, 268);
            this.lvAfterCaptureTasks.TabIndex = 0;
            this.lvAfterCaptureTasks.UseCompatibleStateImageBehavior = false;
            this.lvAfterCaptureTasks.View = System.Windows.Forms.View.Details;
            this.lvAfterCaptureTasks.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvAfterCaptureTasks_ItemSelectionChanged);
            this.lvAfterCaptureTasks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvAfterCaptureTasks_MouseDown);
            // 
            // chAfterCapture
            // 
            this.chAfterCapture.Text = "Tasks";
            this.chAfterCapture.Width = 252;
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContinue.Location = new System.Drawing.Point(8, 312);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(80, 32);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(96, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbImage.DrawCheckeredBackground = true;
            this.pbImage.EnableRightClickMenu = true;
            this.pbImage.FullscreenOnClick = true;
            this.pbImage.Location = new System.Drawing.Point(320, 8);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(376, 336);
            this.pbImage.TabIndex = 4;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopy.Location = new System.Drawing.Point(184, 312);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(80, 32);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tcTasks
            // 
            this.tcTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tcTasks.Controls.Add(this.tpAfterCapture);
            this.tcTasks.Controls.Add(this.tpBeforeUpload);
            this.tcTasks.Location = new System.Drawing.Point(8, 8);
            this.tcTasks.Name = "tcTasks";
            this.tcTasks.SelectedIndex = 0;
            this.tcTasks.Size = new System.Drawing.Size(304, 300);
            this.tcTasks.TabIndex = 0;
            // 
            // tpAfterCapture
            // 
            this.tpAfterCapture.Controls.Add(this.lvAfterCaptureTasks);
            this.tpAfterCapture.Location = new System.Drawing.Point(4, 22);
            this.tpAfterCapture.Name = "tpAfterCapture";
            this.tpAfterCapture.Padding = new System.Windows.Forms.Padding(3);
            this.tpAfterCapture.Size = new System.Drawing.Size(296, 274);
            this.tpAfterCapture.TabIndex = 0;
            this.tpAfterCapture.Text = "After capture";
            this.tpAfterCapture.UseVisualStyleBackColor = true;
            // 
            // tpBeforeUpload
            // 
            this.tpBeforeUpload.Controls.Add(this.ucBeforeUpload);
            this.tpBeforeUpload.Location = new System.Drawing.Point(4, 22);
            this.tpBeforeUpload.Name = "tpBeforeUpload";
            this.tpBeforeUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tpBeforeUpload.Size = new System.Drawing.Size(296, 274);
            this.tpBeforeUpload.TabIndex = 1;
            this.tpBeforeUpload.Text = "Before upload";
            this.tpBeforeUpload.UseVisualStyleBackColor = true;
            // 
            // ucBeforeUpload
            // 
            this.ucBeforeUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBeforeUpload.Location = new System.Drawing.Point(3, 3);
            this.ucBeforeUpload.Name = "ucBeforeUpload";
            this.ucBeforeUpload.Size = new System.Drawing.Size(290, 268);
            this.ucBeforeUpload.TabIndex = 0;
            // 
            // AfterCaptureForm
            // 
            this.AcceptButton = this.btnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 352);
            this.Controls.Add(this.tcTasks);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pbImage);
            this.MinimumSize = new System.Drawing.Size(720, 368);
            this.Name = "AfterCaptureForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareX - Post capture tasks";
            this.TopMost = true;
            this.tcTasks.ResumeLayout(false);
            this.tpAfterCapture.ResumeLayout(false);
            this.tpBeforeUpload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HelpersLib.MyPictureBox pbImage;
        private System.Windows.Forms.ListView lvAfterCaptureTasks;
        private System.Windows.Forms.ColumnHeader chAfterCapture;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TabControl tcTasks;
        private System.Windows.Forms.TabPage tpAfterCapture;
        private System.Windows.Forms.TabPage tpBeforeUpload;
        private BeforeUploadControl ucBeforeUpload;
    }
}