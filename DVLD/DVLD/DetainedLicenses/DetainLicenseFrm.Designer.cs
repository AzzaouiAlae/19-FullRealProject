namespace DVLD.Forms.License
{
    partial class DetainLicenseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetainLicenseFrm));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.licenseFilterControl1 = new DVLD.Controls.License.LicenseFilterControl();
            this.detainInfo = new DVLD.Controls.DetainInfoControl();
            this.LicenseInfo = new DVLD.Controls.DriverLicenseInfoControl();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(252, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(148, 24);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Detain License";
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(551, 453);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 30);
            this.btn_Save.TabIndex = 61;
            this.btn_Save.Text = "   Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(460, 453);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 30);
            this.btn_Exit.TabIndex = 60;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // licenseFilterControl1
            // 
            this.licenseFilterControl1.BackColor = System.Drawing.Color.White;
            this.licenseFilterControl1.Location = new System.Drawing.Point(7, 21);
            this.licenseFilterControl1.Name = "licenseFilterControl1";
            this.licenseFilterControl1.Size = new System.Drawing.Size(634, 75);
            this.licenseFilterControl1.TabIndex = 62;
            this.licenseFilterControl1.Find += new System.Action<System.Windows.Forms.TextBox>(this.licenseFilterControl1_Find);
            // 
            // detainInfo
            // 
            this.detainInfo.BackColor = System.Drawing.Color.White;
            this.detainInfo.Location = new System.Drawing.Point(7, 331);
            this.detainInfo.Name = "detainInfo";
            this.detainInfo.Size = new System.Drawing.Size(635, 121);
            this.detainInfo.TabIndex = 6;
            this.detainInfo.onTextChange += new System.Action<System.Windows.Forms.TextBox>(this.detainInfo_onTextChange);
            // 
            // LicenseInfo
            // 
            this.LicenseInfo.BackColor = System.Drawing.Color.White;
            this.LicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseInfo.Location = new System.Drawing.Point(7, 94);
            this.LicenseInfo.Margin = new System.Windows.Forms.Padding(4);
            this.LicenseInfo.Name = "LicenseInfo";
            this.LicenseInfo.Size = new System.Drawing.Size(640, 239);
            this.LicenseInfo.TabIndex = 4;
            this.LicenseInfo.onLicenseFound += new System.Action<int>(this.LicenseInfo_onLicenseFound);
            // 
            // DetainLicenseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 491);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.licenseFilterControl1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.detainInfo);
            this.Controls.Add(this.LicenseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetainLicenseFrm";
            this.Text = "DetainLicenseFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private Controls.DriverLicenseInfoControl LicenseInfo;
        private Controls.DetainInfoControl detainInfo;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
        private Controls.License.LicenseFilterControl licenseFilterControl1;
    }
}