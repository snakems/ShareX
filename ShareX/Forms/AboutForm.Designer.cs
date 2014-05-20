﻿namespace ShareX
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBerk = new System.Windows.Forms.Label();
            this.pbTR = new System.Windows.Forms.PictureBox();
            this.pbBerkURL = new System.Windows.Forms.PictureBox();
            this.pbMikeURL = new System.Windows.Forms.PictureBox();
            this.pbAU = new System.Windows.Forms.PictureBox();
            this.lblMike = new System.Windows.Forms.Label();
            this.pbBerkSteamURL = new System.Windows.Forms.PictureBox();
            this.rtbCredits = new System.Windows.Forms.RichTextBox();
            this.rtbShareXInfo = new System.Windows.Forms.RichTextBox();
            this.lblOwners = new System.Windows.Forms.Label();
            this.pbMikeSteamURL = new System.Windows.Forms.PictureBox();
            this.cLogo = new HelpersLib.Canvas();
            this.uclUpdate = new HelpersLib.UpdateCheckerLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBerkURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMikeURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBerkSteamURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMikeSteamURL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblProductName.Location = new System.Drawing.Point(12, 8);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(134, 24);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "ShareX 1.0.0.0";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // lblBerk
            // 
            this.lblBerk.AutoSize = true;
            this.lblBerk.BackColor = System.Drawing.Color.Transparent;
            this.lblBerk.ForeColor = System.Drawing.Color.Black;
            this.lblBerk.Location = new System.Drawing.Point(89, 144);
            this.lblBerk.Name = "lblBerk";
            this.lblBerk.Size = new System.Drawing.Size(60, 13);
            this.lblBerk.TabIndex = 4;
            this.lblBerk.Text = "Jaex (Berk)";
            // 
            // pbTR
            // 
            this.pbTR.BackColor = System.Drawing.Color.Transparent;
            this.pbTR.Image = global::ShareX.Properties.Resources.tr;
            this.pbTR.Location = new System.Drawing.Point(17, 142);
            this.pbTR.Name = "pbTR";
            this.pbTR.Size = new System.Drawing.Size(16, 16);
            this.pbTR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTR.TabIndex = 8;
            this.pbTR.TabStop = false;
            // 
            // pbBerkURL
            // 
            this.pbBerkURL.BackColor = System.Drawing.Color.Transparent;
            this.pbBerkURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBerkURL.Image = global::ShareX.Properties.Resources.application_browser;
            this.pbBerkURL.Location = new System.Drawing.Point(41, 142);
            this.pbBerkURL.Name = "pbBerkURL";
            this.pbBerkURL.Size = new System.Drawing.Size(16, 16);
            this.pbBerkURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBerkURL.TabIndex = 10;
            this.pbBerkURL.TabStop = false;
            this.pbBerkURL.Click += new System.EventHandler(this.pbBerkURL_Click);
            // 
            // pbMikeURL
            // 
            this.pbMikeURL.BackColor = System.Drawing.Color.Transparent;
            this.pbMikeURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMikeURL.Image = global::ShareX.Properties.Resources.application_browser;
            this.pbMikeURL.Location = new System.Drawing.Point(41, 166);
            this.pbMikeURL.Name = "pbMikeURL";
            this.pbMikeURL.Size = new System.Drawing.Size(16, 16);
            this.pbMikeURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMikeURL.TabIndex = 14;
            this.pbMikeURL.TabStop = false;
            this.pbMikeURL.Click += new System.EventHandler(this.pbMikeURL_Click);
            // 
            // pbAU
            // 
            this.pbAU.BackColor = System.Drawing.Color.Transparent;
            this.pbAU.Image = global::ShareX.Properties.Resources.au;
            this.pbAU.Location = new System.Drawing.Point(17, 166);
            this.pbAU.Name = "pbAU";
            this.pbAU.Size = new System.Drawing.Size(16, 16);
            this.pbAU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAU.TabIndex = 12;
            this.pbAU.TabStop = false;
            // 
            // lblMike
            // 
            this.lblMike.AutoSize = true;
            this.lblMike.BackColor = System.Drawing.Color.Transparent;
            this.lblMike.ForeColor = System.Drawing.Color.Black;
            this.lblMike.Location = new System.Drawing.Point(89, 168);
            this.lblMike.Name = "lblMike";
            this.lblMike.Size = new System.Drawing.Size(131, 13);
            this.lblMike.TabIndex = 6;
            this.lblMike.Text = "mcored (Michael Delpach)";
            // 
            // pbBerkSteamURL
            // 
            this.pbBerkSteamURL.BackColor = System.Drawing.Color.Transparent;
            this.pbBerkSteamURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBerkSteamURL.Image = global::ShareX.Properties.Resources.steam;
            this.pbBerkSteamURL.Location = new System.Drawing.Point(65, 142);
            this.pbBerkSteamURL.Name = "pbBerkSteamURL";
            this.pbBerkSteamURL.Size = new System.Drawing.Size(16, 16);
            this.pbBerkSteamURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBerkSteamURL.TabIndex = 21;
            this.pbBerkSteamURL.TabStop = false;
            this.pbBerkSteamURL.Click += new System.EventHandler(this.pbBerkSteamURL_Click);
            // 
            // rtbCredits
            // 
            this.rtbCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCredits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbCredits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCredits.Location = new System.Drawing.Point(15, 200);
            this.rtbCredits.Name = "rtbCredits";
            this.rtbCredits.ReadOnly = true;
            this.rtbCredits.Size = new System.Drawing.Size(417, 248);
            this.rtbCredits.TabIndex = 11;
            this.rtbCredits.Text = resources.GetString("rtbCredits.Text");
            this.rtbCredits.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb_LinkClicked);
            // 
            // rtbShareXInfo
            // 
            this.rtbShareXInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbShareXInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbShareXInfo.Location = new System.Drawing.Point(15, 66);
            this.rtbShareXInfo.Name = "rtbShareXInfo";
            this.rtbShareXInfo.ReadOnly = true;
            this.rtbShareXInfo.Size = new System.Drawing.Size(247, 48);
            this.rtbShareXInfo.TabIndex = 2;
            this.rtbShareXInfo.Text = "Website: http://getsharex.com\nProject page: https://github.com/ShareX/ShareX\nIssu" +
    "es: https://github.com/ShareX/ShareX/issues";
            this.rtbShareXInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb_LinkClicked);
            // 
            // lblOwners
            // 
            this.lblOwners.AutoSize = true;
            this.lblOwners.Location = new System.Drawing.Point(14, 117);
            this.lblOwners.Name = "lblOwners";
            this.lblOwners.Size = new System.Drawing.Size(46, 13);
            this.lblOwners.TabIndex = 3;
            this.lblOwners.Text = "Owners:";
            // 
            // pbMikeSteamURL
            // 
            this.pbMikeSteamURL.BackColor = System.Drawing.Color.Transparent;
            this.pbMikeSteamURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMikeSteamURL.Image = global::ShareX.Properties.Resources.steam;
            this.pbMikeSteamURL.Location = new System.Drawing.Point(65, 166);
            this.pbMikeSteamURL.Name = "pbMikeSteamURL";
            this.pbMikeSteamURL.Size = new System.Drawing.Size(16, 16);
            this.pbMikeSteamURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMikeSteamURL.TabIndex = 34;
            this.pbMikeSteamURL.TabStop = false;
            this.pbMikeSteamURL.Click += new System.EventHandler(this.pbMikeSteamURL_Click);
            // 
            // cLogo
            // 
            this.cLogo.Interval = 100;
            this.cLogo.Location = new System.Drawing.Point(224, -8);
            this.cLogo.Name = "cLogo";
            this.cLogo.Size = new System.Drawing.Size(208, 200);
            this.cLogo.TabIndex = 5;
            this.cLogo.Draw += new HelpersLib.Canvas.DrawEventHandler(this.cLogo_Draw);
            this.cLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cLogo_MouseDown);
            // 
            // uclUpdate
            // 
            this.uclUpdate.Location = new System.Drawing.Point(13, 36);
            this.uclUpdate.Name = "uclUpdate";
            this.uclUpdate.Size = new System.Drawing.Size(224, 24);
            this.uclUpdate.TabIndex = 1;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(441, 457);
            this.Controls.Add(this.pbMikeSteamURL);
            this.Controls.Add(this.lblOwners);
            this.Controls.Add(this.rtbShareXInfo);
            this.Controls.Add(this.rtbCredits);
            this.Controls.Add(this.pbBerkSteamURL);
            this.Controls.Add(this.lblBerk);
            this.Controls.Add(this.lblMike);
            this.Controls.Add(this.cLogo);
            this.Controls.Add(this.uclUpdate);
            this.Controls.Add(this.pbMikeURL);
            this.Controls.Add(this.pbAU);
            this.Controls.Add(this.pbBerkURL);
            this.Controls.Add(this.pbTR);
            this.Controls.Add(this.lblProductName);
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareX - About";
            this.Shown += new System.EventHandler(this.AboutForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBerkURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMikeURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBerkSteamURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMikeSteamURL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBerk;
        private System.Windows.Forms.PictureBox pbTR;
        private System.Windows.Forms.PictureBox pbBerkURL;
        private System.Windows.Forms.PictureBox pbMikeURL;
        private System.Windows.Forms.PictureBox pbAU;
        private System.Windows.Forms.Label lblMike;
        private HelpersLib.Canvas cLogo;
        private System.Windows.Forms.PictureBox pbBerkSteamURL;
        private System.Windows.Forms.RichTextBox rtbCredits;
        private System.Windows.Forms.RichTextBox rtbShareXInfo;
        private System.Windows.Forms.Label lblOwners;
        private HelpersLib.UpdateCheckerLabel uclUpdate;
        private System.Windows.Forms.PictureBox pbMikeSteamURL;
    }
}