namespace DVLD.Forms.License
{
    partial class ReleaseDetainLicenseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleaseDetainLicenseFrm));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Release = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.releaseDetainLicense = new DVLD.Controls.ReleaseDetainLicenseControl();
            this.licenseFilter = new DVLD.Controls.License.LicenseFilterControl();
            this.LicenseInfo = new DVLD.Controls.DriverLicenseInfoControl();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(221, 5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(230, 24);
            this.lbl_Title.TabIndex = 63;
            this.lbl_Title.Text = "Release Detain License";
            // 
            // btn_Release
            // 
            this.btn_Release.Enabled = false;
            this.btn_Release.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Release.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Release.Image = ((System.Drawing.Image)(resources.GetObject("btn_Release.Image")));
            this.btn_Release.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Release.Location = new System.Drawing.Point(524, 471);
            this.btn_Release.Name = "btn_Release";
            this.btn_Release.Size = new System.Drawing.Size(114, 30);
            this.btn_Release.TabIndex = 67;
            this.btn_Release.Text = "   Release";
            this.btn_Release.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Release.UseVisualStyleBackColor = true;
            this.btn_Release.Click += new System.EventHandler(this.btn_Release_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(434, 471);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 30);
            this.btn_Exit.TabIndex = 66;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // releaseDetainLicense
            // 
            this.releaseDetainLicense.BackColor = System.Drawing.Color.White;
            this.releaseDetainLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.releaseDetainLicense.Location = new System.Drawing.Point(6, 329);
            this.releaseDetainLicense.Margin = new System.Windows.Forms.Padding(4);
            this.releaseDetainLicense.Name = "releaseDetainLicense";
            this.releaseDetainLicense.Size = new System.Drawing.Size(640, 143);
            this.releaseDetainLicense.TabIndex = 69;
            // 
            // licenseFilter
            // 
            this.licenseFilter.BackColor = System.Drawing.Color.White;
            this.licenseFilter.Location = new System.Drawing.Point(6, 23);
            this.licenseFilter.Name = "licenseFilter";
            this.licenseFilter.Size = new System.Drawing.Size(634, 75);
            this.licenseFilter.TabIndex = 68;
            this.licenseFilter.Find += new System.Action<System.Windows.Forms.TextBox>(this.licenseFilterControl1_Find);
            // 
            // LicenseInfo
            // 
            this.LicenseInfo.BackColor = System.Drawing.Color.White;
            this.LicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseInfo.Location = new System.Drawing.Point(6, 96);
            this.LicenseInfo.Margin = new System.Windows.Forms.Padding(4);
            this.LicenseInfo.Name = "LicenseInfo";
            this.LicenseInfo.Size = new System.Drawing.Size(640, 239);
            this.LicenseInfo.TabIndex = 64;
            this.LicenseInfo.onLicenseFound += new System.Action<int>(this.LicenseInfo_onLicenseFound);
            // 
            // ReleaseDetainLicenseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 506);
            this.Controls.Add(this.btn_Release);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.releaseDetainLicense);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.licenseFilter);
            this.Controls.Add(this.LicenseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReleaseDetainLicenseFrm";
            this.Text = "Release Detain License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private Controls.License.LicenseFilterControl licenseFilter;
        private System.Windows.Forms.Button btn_Release;
        private System.Windows.Forms.Button btn_Exit;
        private Controls.DriverLicenseInfoControl LicenseInfo;
        private Controls.ReleaseDetainLicenseControl releaseDetainLicense;
    }
}