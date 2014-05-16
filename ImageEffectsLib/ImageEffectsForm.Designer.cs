﻿namespace ImageEffectsLib
{
    partial class ImageEffectsForm
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
            this.tvEffects = new System.Windows.Forms.TreeView();
            this.pgSettings = new System.Windows.Forms.PropertyGrid();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvEffects = new System.Windows.Forms.ListView();
            this.chEffect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnSettingsExport = new System.Windows.Forms.Button();
            this.btnSettingsImport = new System.Windows.Forms.Button();
            this.pbResult = new HelpersLib.MyPictureBox();
            this.SuspendLayout();
            // 
            // tvEffects
            // 
            this.tvEffects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvEffects.HideSelection = false;
            this.tvEffects.Location = new System.Drawing.Point(8, 40);
            this.tvEffects.Name = "tvEffects";
            this.tvEffects.ShowPlusMinus = false;
            this.tvEffects.ShowRootLines = false;
            this.tvEffects.Size = new System.Drawing.Size(232, 688);
            this.tvEffects.TabIndex = 7;
            this.tvEffects.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvEffects_BeforeCollapse);
            this.tvEffects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvEffects_MouseDoubleClick);
            // 
            // pgSettings
            // 
            this.pgSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgSettings.Location = new System.Drawing.Point(488, 8);
            this.pgSettings.Name = "pgSettings";
            this.pgSettings.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgSettings.Size = new System.Drawing.Size(408, 304);
            this.pgSettings.TabIndex = 9;
            this.pgSettings.ToolbarVisible = false;
            this.pgSettings.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgSettings_PropertyValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 24);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvEffects
            // 
            this.lvEffects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEffect});
            this.lvEffects.FullRowSelect = true;
            this.lvEffects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvEffects.HideSelection = false;
            this.lvEffects.Location = new System.Drawing.Point(248, 40);
            this.lvEffects.MultiSelect = false;
            this.lvEffects.Name = "lvEffects";
            this.lvEffects.Size = new System.Drawing.Size(232, 272);
            this.lvEffects.TabIndex = 8;
            this.lvEffects.UseCompatibleStateImageBehavior = false;
            this.lvEffects.View = System.Windows.Forms.View.Details;
            this.lvEffects.SelectedIndexChanged += new System.EventHandler(this.lvEffects_SelectedIndexChanged);
            this.lvEffects.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvEffects_KeyDown);
            // 
            // chEffect
            // 
            this.chEffect.Width = 228;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(88, 8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 24);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(744, 734);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 24);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(824, 734);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 24);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 24);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMoveUp.Location = new System.Drawing.Point(328, 8);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(32, 24);
            this.btnMoveUp.TabIndex = 4;
            this.btnMoveUp.Text = "↑";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMoveDown.Location = new System.Drawing.Point(368, 8);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(32, 24);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.Text = "↓";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Location = new System.Drawing.Point(248, 8);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(72, 24);
            this.btnDuplicate.TabIndex = 3;
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(408, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 24);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadImage.AutoSize = true;
            this.btnLoadImage.Location = new System.Drawing.Point(318, 734);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(81, 24);
            this.btnLoadImage.TabIndex = 13;
            this.btnLoadImage.Text = "Load image...";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Visible = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveImage.AutoSize = true;
            this.btnSaveImage.Location = new System.Drawing.Point(405, 734);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(82, 24);
            this.btnSaveImage.TabIndex = 14;
            this.btnSaveImage.Text = "Save image...";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Visible = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnSettingsExport
            // 
            this.btnSettingsExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettingsExport.AutoSize = true;
            this.btnSettingsExport.Location = new System.Drawing.Point(8, 734);
            this.btnSettingsExport.Name = "btnSettingsExport";
            this.btnSettingsExport.Size = new System.Drawing.Size(144, 24);
            this.btnSettingsExport.TabIndex = 11;
            this.btnSettingsExport.Text = "Export settings to clipboard";
            this.btnSettingsExport.UseVisualStyleBackColor = true;
            this.btnSettingsExport.Click += new System.EventHandler(this.btnSettingsExport_Click);
            // 
            // btnSettingsImport
            // 
            this.btnSettingsImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettingsImport.AutoSize = true;
            this.btnSettingsImport.Location = new System.Drawing.Point(158, 734);
            this.btnSettingsImport.Name = "btnSettingsImport";
            this.btnSettingsImport.Size = new System.Drawing.Size(154, 24);
            this.btnSettingsImport.TabIndex = 12;
            this.btnSettingsImport.Text = "Import settings from clipboard";
            this.btnSettingsImport.UseVisualStyleBackColor = true;
            this.btnSettingsImport.Click += new System.EventHandler(this.btnSettingsImport_Click);
            // 
            // pbResult
            // 
            this.pbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbResult.BackColor = System.Drawing.Color.White;
            this.pbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResult.DrawCheckeredBackground = true;
            this.pbResult.EnableRightClickMenu = true;
            this.pbResult.FullscreenOnClick = true;
            this.pbResult.Location = new System.Drawing.Point(248, 320);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(648, 408);
            this.pbResult.TabIndex = 10;
            this.pbResult.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbResult_DragDrop);
            this.pbResult.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbResult_DragEnter);
            // 
            // ImageEffectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 766);
            this.Controls.Add(this.btnSettingsImport);
            this.Controls.Add(this.btnSettingsExport);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDuplicate);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pgSettings);
            this.Controls.Add(this.tvEffects);
            this.Controls.Add(this.lvEffects);
            this.Name = "ImageEffectsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareX - Image effects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvEffects;
        private System.Windows.Forms.PropertyGrid pgSettings;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvEffects;
        private System.Windows.Forms.ColumnHeader chEffect;
        private System.Windows.Forms.Button btnRemove;
        private HelpersLib.MyPictureBox pbResult;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnSettingsExport;
        private System.Windows.Forms.Button btnSettingsImport;
    }
}

