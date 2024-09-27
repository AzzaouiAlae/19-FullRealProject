namespace DVLD.Forms.License
{
    partial class NewInternationalLicenseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewInternationalLicenseFrm));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.internationalAppInfo = new DVLD.Controls.License.InternationalAppInfoControl();
            this.driverLicenseInfo = new DVLD.Controls.DriverLicenseInfoControl();
            this.licenseFilterControl1 = new DVLD.Controls.License.LicenseFilterControl();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_ShowNewLicensesInfo = new System.Windows.Forms.Label();
            this.lbl_ShowLicensesHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(172, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(313, 24);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "International License Application";
            // 
            // internationalAppInfo
            // 
            this.internationalAppInfo.BackColor = System.Drawing.Color.White;
            this.internationalAppInfo.Location = new System.Drawing.Point(1, 332);
            this.internationalAppInfo.Name = "internationalAppInfo";
            this.internationalAppInfo.Size = new System.Drawing.Size(640, 148);
            this.internationalAppInfo.TabIndex = 7;
            // 
            // driverLicenseInfo
            // 
            this.driverLicenseInfo.BackColor = System.Drawing.Color.White;
            this.driverLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLicenseInfo.Location = new System.Drawing.Point(3, 99);
            this.driverLicenseInfo.Margin = new System.Windows.Forms.Padding(4);
            this.driverLicenseInfo.Name = "driverLicenseInfo";
            this.driverLicenseInfo.Size = new System.Drawing.Size(640, 239);
            this.driverLicenseInfo.TabIndex = 6;
            this.driverLicenseInfo.onLicenseFound += new System.Action<int>(this.driverLicenseInfo_onLicenseFound);
            // 
            // licenseFilterControl1
            // 
            this.licenseFilterControl1.BackColor = System.Drawing.Color.White;
            this.licenseFilterControl1.Location = new System.Drawing.Point(3, 30);
            this.licenseFilterControl1.Name = "licenseFilterControl1";
            this.licenseFilterControl1.Size = new System.Drawing.Size(640, 82);
            this.licenseFilterControl1.TabIndex = 5;
            this.licenseFilterControl1.Find += new System.Action<System.Windows.Forms.TextBox>(this.licenseFilterControl1_Find);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(545, 481);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 30);
            this.btn_Save.TabIndex = 63;
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
            this.btn_Exit.Location = new System.Drawing.Point(454, 481);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 30);
            this.btn_Exit.TabIndex = 62;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_ShowNewLicensesInfo
            // 
            this.lbl_ShowNewLicensesInfo.AutoSize = true;
            this.lbl_ShowNewLicensesInfo.Enabled = false;
            this.lbl_ShowNewLicensesInfo.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowNewLicensesInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ShowNewLicensesInfo.Location = new System.Drawing.Point(187, 484);
            this.lbl_ShowNewLicensesInfo.Name = "lbl_ShowNewLicensesInfo";
            this.lbl_ShowNewLicensesInfo.Size = new System.Drawing.Size(161, 22);
            this.lbl_ShowNewLicensesInfo.TabIndex = 65;
            this.lbl_ShowNewLicensesInfo.Text = "Show New Licenses Info";
            this.lbl_ShowNewLicensesInfo.Click += new System.EventHandler(this.lbl_ShowNewLicensesInfo_Click);
            // 
            // lbl_ShowLicensesHistory
            // 
            this.lbl_ShowLicensesHistory.AutoSize = true;
            this.lbl_ShowLicensesHistory.Enabled = false;
            this.lbl_ShowLicensesHistory.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowLicensesHistory.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ShowLicensesHistory.Location = new System.Drawing.Point(12, 484);
            this.lbl_ShowLicensesHistory.Name = "lbl_ShowLicensesHistory";
            this.lbl_ShowLicensesHistory.Size = new System.Drawing.Size(151, 22);
            this.lbl_ShowLicensesHistory.TabIndex = 66;
            this.lbl_ShowLicensesHistory.Text = "Show Licenses History";
            this.lbl_ShowLicensesHistory.Click += new System.EventHandler(this.lbl_ShowLicensesHistory_Click);
            // 
            // NewInternationalLicenseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 521);
            this.Controls.Add(this.lbl_ShowNewLicensesInfo);
            this.Controls.Add(this.lbl_ShowLicensesHistory);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.internationalAppInfo);
            this.Controls.Add(this.driverLicenseInfo);
            this.Controls.Add(this.licenseFilterControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewInternationalLicenseFrm";
            this.Text = "New International License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private Controls.License.LicenseFilterControl licenseFilterControl1;
        private Controls.DriverLicenseInfoControl driverLicenseInfo;
        private Controls.License.InternationalAppInfoControl internationalAppInfo;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_ShowNewLicensesInfo;
        private System.Windows.Forms.Label lbl_ShowLicensesHistory;
    }
}