namespace DVLD.Forms.License
{
    partial class RepLostLicenseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepLostLicenseFrm));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Lost = new System.Windows.Forms.RadioButton();
            this.rb_Damaged = new System.Windows.Forms.RadioButton();
            this.LicenseInfo = new DVLD.Controls.DriverLicenseInfoControl();
            this.licenseFilter = new DVLD.Controls.License.LicenseFilterControl();
            this.appInfoRepLost = new DVLD.Controls.License.AppInfoRepLostControl();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_ShowLicensesHistory = new System.Windows.Forms.Label();
            this.lbl_ShowNewLicensesInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(156, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(337, 24);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Replacement for Damaged License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Lost);
            this.groupBox1.Controls.Add(this.rb_Damaged);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(439, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement For :";
            // 
            // rb_Lost
            // 
            this.rb_Lost.AutoSize = true;
            this.rb_Lost.Location = new System.Drawing.Point(16, 40);
            this.rb_Lost.Name = "rb_Lost";
            this.rb_Lost.Size = new System.Drawing.Size(112, 20);
            this.rb_Lost.TabIndex = 1;
            this.rb_Lost.Text = "Lost License";
            this.rb_Lost.UseVisualStyleBackColor = true;
            this.rb_Lost.CheckedChanged += new System.EventHandler(this.rb_Lost_CheckedChanged);
            // 
            // rb_Damaged
            // 
            this.rb_Damaged.AutoSize = true;
            this.rb_Damaged.Checked = true;
            this.rb_Damaged.Location = new System.Drawing.Point(16, 17);
            this.rb_Damaged.Name = "rb_Damaged";
            this.rb_Damaged.Size = new System.Drawing.Size(151, 20);
            this.rb_Damaged.TabIndex = 0;
            this.rb_Damaged.TabStop = true;
            this.rb_Damaged.Text = "Damaged License";
            this.rb_Damaged.UseVisualStyleBackColor = true;
            this.rb_Damaged.CheckedChanged += new System.EventHandler(this.rb_Damaged_CheckedChanged);
            // 
            // LicenseInfo
            // 
            this.LicenseInfo.BackColor = System.Drawing.Color.White;
            this.LicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseInfo.Location = new System.Drawing.Point(7, 99);
            this.LicenseInfo.Margin = new System.Windows.Forms.Padding(4);
            this.LicenseInfo.Name = "LicenseInfo";
            this.LicenseInfo.Size = new System.Drawing.Size(640, 239);
            this.LicenseInfo.TabIndex = 5;
            this.LicenseInfo.onLicenseFound += new System.Action<int>(this.LicenseInfo_onLicenseFound);
            // 
            // licenseFilter
            // 
            this.licenseFilter.BackColor = System.Drawing.Color.White;
            this.licenseFilter.border_size = new System.Drawing.Size(340, 63);
            this.licenseFilter.Location = new System.Drawing.Point(7, 28);
            this.licenseFilter.Name = "licenseFilter";
            this.licenseFilter.Size = new System.Drawing.Size(345, 82);
            this.licenseFilter.TabIndex = 6;
            this.licenseFilter.Find += new System.Action<System.Windows.Forms.TextBox>(this.licenseFilter_Find);
            // 
            // appInfoRepLost
            // 
            this.appInfoRepLost.BackColor = System.Drawing.Color.White;
            this.appInfoRepLost.Location = new System.Drawing.Point(7, 334);
            this.appInfoRepLost.Name = "appInfoRepLost";
            this.appInfoRepLost.Size = new System.Drawing.Size(640, 120);
            this.appInfoRepLost.TabIndex = 8;
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(550, 452);
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
            this.btn_Exit.Location = new System.Drawing.Point(459, 452);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 30);
            this.btn_Exit.TabIndex = 62;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_ShowLicensesHistory
            // 
            this.lbl_ShowLicensesHistory.AutoSize = true;
            this.lbl_ShowLicensesHistory.Enabled = false;
            this.lbl_ShowLicensesHistory.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowLicensesHistory.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ShowLicensesHistory.Location = new System.Drawing.Point(56, 456);
            this.lbl_ShowLicensesHistory.Name = "lbl_ShowLicensesHistory";
            this.lbl_ShowLicensesHistory.Size = new System.Drawing.Size(151, 22);
            this.lbl_ShowLicensesHistory.TabIndex = 64;
            this.lbl_ShowLicensesHistory.Text = "Show Licenses History";
            this.lbl_ShowLicensesHistory.Click += new System.EventHandler(this.lbl_ShowLicensesHistory_Click);
            // 
            // lbl_ShowNewLicensesInfo
            // 
            this.lbl_ShowNewLicensesInfo.AutoSize = true;
            this.lbl_ShowNewLicensesInfo.Enabled = false;
            this.lbl_ShowNewLicensesInfo.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowNewLicensesInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ShowNewLicensesInfo.Location = new System.Drawing.Point(231, 456);
            this.lbl_ShowNewLicensesInfo.Name = "lbl_ShowNewLicensesInfo";
            this.lbl_ShowNewLicensesInfo.Size = new System.Drawing.Size(161, 22);
            this.lbl_ShowNewLicensesInfo.TabIndex = 64;
            this.lbl_ShowNewLicensesInfo.Text = "Show New Licenses Info";
            this.lbl_ShowNewLicensesInfo.Click += new System.EventHandler(this.lbl_ShowNewLicensesInfo_Click);
            // 
            // RepLostLicenseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 491);
            this.Controls.Add(this.lbl_ShowNewLicensesInfo);
            this.Controls.Add(this.lbl_ShowLicensesHistory);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.appInfoRepLost);
            this.Controls.Add(this.LicenseInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.licenseFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RepLostLicenseFrm";
            this.Text = "Replacement for Lost License";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private Controls.DriverLicenseInfoControl LicenseInfo;
        private Controls.License.LicenseFilterControl licenseFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Lost;
        private System.Windows.Forms.RadioButton rb_Damaged;
        private Controls.License.AppInfoRepLostControl appInfoRepLost;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_ShowLicensesHistory;
        private System.Windows.Forms.Label lbl_ShowNewLicensesInfo;
    }
}