namespace Julian_Date_Selector
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkLicenseSite = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblGitHubRepo = new System.Windows.Forms.Label();
            this.lblGitHubProfile = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lnkGitHubProfile = new System.Windows.Forms.LinkLabel();
            this.lnkGitHubRepo = new System.Windows.Forms.LinkLabel();
            this.btnDisclaimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lnkLicenseSite
            // 
            this.lnkLicenseSite.AutoSize = true;
            this.lnkLicenseSite.Location = new System.Drawing.Point(489, 11);
            this.lnkLicenseSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLicenseSite.Name = "lnkLicenseSite";
            this.lnkLicenseSite.Size = new System.Drawing.Size(306, 16);
            this.lnkLicenseSite.TabIndex = 0;
            this.lnkLicenseSite.TabStop = true;
            this.lnkLicenseSite.Text = "License: GNU General Public License Version 3";
            this.lnkLicenseSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLicenseSite_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(489, 81);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(62, 16);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version: ";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(489, 116);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(76, 16);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright: ";
            // 
            // lblGitHubRepo
            // 
            this.lblGitHubRepo.AutoSize = true;
            this.lblGitHubRepo.Location = new System.Drawing.Point(489, 186);
            this.lblGitHubRepo.Name = "lblGitHubRepo";
            this.lblGitHubRepo.Size = new System.Drawing.Size(129, 16);
            this.lblGitHubRepo.TabIndex = 6;
            this.lblGitHubRepo.Text = "GitHub Repository: ";
            // 
            // lblGitHubProfile
            // 
            this.lblGitHubProfile.AutoSize = true;
            this.lblGitHubProfile.Location = new System.Drawing.Point(489, 151);
            this.lblGitHubProfile.Name = "lblGitHubProfile";
            this.lblGitHubProfile.Size = new System.Drawing.Size(104, 16);
            this.lblGitHubProfile.TabIndex = 4;
            this.lblGitHubProfile.Text = "GitHub Profile: ";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(489, 46);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(164, 16);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product/Program Name: ";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(489, 434);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(489, 234);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxDescription.Size = new System.Drawing.Size(406, 194);
            this.tbxDescription.TabIndex = 8;
            // 
            // lnkGitHubProfile
            // 
            this.lnkGitHubProfile.AutoSize = true;
            this.lnkGitHubProfile.Location = new System.Drawing.Point(592, 151);
            this.lnkGitHubProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkGitHubProfile.Name = "lnkGitHubProfile";
            this.lnkGitHubProfile.Size = new System.Drawing.Size(19, 16);
            this.lnkGitHubProfile.TabIndex = 5;
            this.lnkGitHubProfile.TabStop = true;
            this.lnkGitHubProfile.Text = "   ";
            this.lnkGitHubProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHubProfile_LinkClicked);
            // 
            // lnkGitHubRepo
            // 
            this.lnkGitHubRepo.AutoSize = true;
            this.lnkGitHubRepo.Location = new System.Drawing.Point(489, 202);
            this.lnkGitHubRepo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkGitHubRepo.Name = "lnkGitHubRepo";
            this.lnkGitHubRepo.Size = new System.Drawing.Size(19, 16);
            this.lnkGitHubRepo.TabIndex = 7;
            this.lnkGitHubRepo.TabStop = true;
            this.lnkGitHubRepo.Text = "   ";
            this.lnkGitHubRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGitHubRepo_LinkClicked);
            // 
            // btnDisclaimer
            // 
            this.btnDisclaimer.AutoSize = true;
            this.btnDisclaimer.Location = new System.Drawing.Point(820, 434);
            this.btnDisclaimer.Name = "btnDisclaimer";
            this.btnDisclaimer.Size = new System.Drawing.Size(84, 26);
            this.btnDisclaimer.TabIndex = 10;
            this.btnDisclaimer.Text = "&Disclaimer";
            this.btnDisclaimer.UseVisualStyleBackColor = true;
            this.btnDisclaimer.Click += new System.EventHandler(this.btnDisclaimer_Click);
            // 
            // frmAbout
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 467);
            this.Controls.Add(this.btnDisclaimer);
            this.Controls.Add(this.lnkGitHubRepo);
            this.Controls.Add(this.lnkGitHubProfile);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblGitHubProfile);
            this.Controls.Add(this.lblGitHubRepo);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lnkLicenseSite);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkLicenseSite;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblGitHubRepo;
        private System.Windows.Forms.Label lblGitHubProfile;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.LinkLabel lnkGitHubProfile;
        private System.Windows.Forms.LinkLabel lnkGitHubRepo;
        private System.Windows.Forms.Button btnDisclaimer;
    }
}
