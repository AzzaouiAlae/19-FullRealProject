namespace DVLD.Controls
{
    partial class LicenseAppInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_PassedTests = new System.Windows.Forms.Label();
            this.lbl_LicenseClassName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_DLAppID = new System.Windows.Forms.Label();
            this.lbl_ShowLicenseInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_PassedTests);
            this.groupBox1.Controls.Add(this.lbl_LicenseClassName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_DLAppID);
            this.groupBox1.Controls.Add(this.lbl_ShowLicenseInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Application Info";
            // 
            // lbl_PassedTests
            // 
            this.lbl_PassedTests.AutoSize = true;
            this.lbl_PassedTests.Location = new System.Drawing.Point(408, 59);
            this.lbl_PassedTests.Name = "lbl_PassedTests";
            this.lbl_PassedTests.Size = new System.Drawing.Size(19, 16);
            this.lbl_PassedTests.TabIndex = 4;
            this.lbl_PassedTests.Text = "...";
            // 
            // lbl_LicenseClassName
            // 
            this.lbl_LicenseClassName.AutoSize = true;
            this.lbl_LicenseClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LicenseClassName.Location = new System.Drawing.Point(408, 28);
            this.lbl_LicenseClassName.Name = "lbl_LicenseClassName";
            this.lbl_LicenseClassName.Size = new System.Drawing.Size(19, 16);
            this.lbl_LicenseClassName.TabIndex = 2;
            this.lbl_LicenseClassName.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Passed Tests :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Applied for License :";
            // 
            // lbl_DLAppID
            // 
            this.lbl_DLAppID.AutoSize = true;
            this.lbl_DLAppID.Location = new System.Drawing.Point(120, 28);
            this.lbl_DLAppID.Name = "lbl_DLAppID";
            this.lbl_DLAppID.Size = new System.Drawing.Size(19, 16);
            this.lbl_DLAppID.TabIndex = 0;
            this.lbl_DLAppID.Text = "...";
            // 
            // lbl_ShowLicenseInfo
            // 
            this.lbl_ShowLicenseInfo.AutoSize = true;
            this.lbl_ShowLicenseInfo.Enabled = false;
            this.lbl_ShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowLicenseInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ShowLicenseInfo.Location = new System.Drawing.Point(25, 59);
            this.lbl_ShowLicenseInfo.Name = "lbl_ShowLicenseInfo";
            this.lbl_ShowLicenseInfo.Size = new System.Drawing.Size(131, 16);
            this.lbl_ShowLicenseInfo.TabIndex = 1;
            this.lbl_ShowLicenseInfo.Text = "Show License Info";
            this.lbl_ShowLicenseInfo.Click += new System.EventHandler(this.lbl_ShowLicenseInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L.App ID :";
            // 
            // LicenseAppInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LicenseAppInfoControl";
            this.Size = new System.Drawing.Size(660, 99);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_DLAppID;
        private System.Windows.Forms.Label lbl_ShowLicenseInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PassedTests;
        private System.Windows.Forms.Label lbl_LicenseClassName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
