namespace DVLD.Forms.License
{
    partial class LocalDrivingLicenseApplicationInfoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalDrivingLicenseApplicationInfoFrm));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.appBasicInfo = new DVLD.Controls.AppBasicInfoControl();
            this.licenseAppInfo1 = new DVLD.Controls.LicenseAppInfoControl();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(555, 283);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 30);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // appBasicInfo
            // 
            this.appBasicInfo.BackColor = System.Drawing.Color.White;
            this.appBasicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appBasicInfo.Location = new System.Drawing.Point(5, 96);
            this.appBasicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.appBasicInfo.Name = "appBasicInfo";
            this.appBasicInfo.Size = new System.Drawing.Size(660, 180);
            this.appBasicInfo.TabIndex = 1;
            // 
            // licenseAppInfo1
            // 
            this.licenseAppInfo1.BackColor = System.Drawing.Color.White;
            this.licenseAppInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseAppInfo1.Location = new System.Drawing.Point(5, 5);
            this.licenseAppInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.licenseAppInfo1.Name = "licenseAppInfo1";
            this.licenseAppInfo1.Size = new System.Drawing.Size(660, 99);
            this.licenseAppInfo1.TabIndex = 0;
            this.licenseAppInfo1.OnFormFill += new System.Action<int>(this.licenseAppInfo1_OnFormFill);
            // 
            // LocalDrivingLicenseApplicationInfoFrm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 323);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.appBasicInfo);
            this.Controls.Add(this.licenseAppInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocalDrivingLicenseApplicationInfoFrm";
            this.ResumeLayout(false);

        }

        #endregion

        
        private Controls.LicenseAppInfoControl licenseAppInfo1;
        private Controls.AppBasicInfoControl appBasicInfo;
        private System.Windows.Forms.Button btn_Exit;
    }
}