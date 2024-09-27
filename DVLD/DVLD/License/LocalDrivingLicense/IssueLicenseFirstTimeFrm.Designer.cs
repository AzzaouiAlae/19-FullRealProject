namespace DVLD.Forms.License
{
    partial class IssueLicenseFirstTimeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueLicenseFirstTimeFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.licenseAppInfo = new DVLD.Controls.LicenseAppInfoControl();
            this.appBasicInfo = new DVLD.Controls.AppBasicInfoControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Note :";
            // 
            // txt_Note
            // 
            this.txt_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Note.Location = new System.Drawing.Point(117, 291);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(551, 117);
            this.txt_Note.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(476, 418);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 30);
            this.btn_Exit.TabIndex = 61;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(578, 418);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 30);
            this.btn_Save.TabIndex = 63;
            this.btn_Save.Text = "   Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // licenseAppInfo
            // 
            this.licenseAppInfo.BackColor = System.Drawing.Color.White;
            this.licenseAppInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseAppInfo.Location = new System.Drawing.Point(13, 12);
            this.licenseAppInfo.Margin = new System.Windows.Forms.Padding(4);
            this.licenseAppInfo.Name = "licenseAppInfo";
            this.licenseAppInfo.Size = new System.Drawing.Size(660, 99);
            this.licenseAppInfo.TabIndex = 2;
            this.licenseAppInfo.OnFormFill += new System.Action<int>(this.licenseAppInfo_OnFormFill);
            // 
            // appBasicInfo
            // 
            this.appBasicInfo.BackColor = System.Drawing.Color.White;
            this.appBasicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appBasicInfo.Location = new System.Drawing.Point(9, 107);
            this.appBasicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.appBasicInfo.Name = "appBasicInfo";
            this.appBasicInfo.Size = new System.Drawing.Size(660, 180);
            this.appBasicInfo.TabIndex = 1;
            // 
            // IssueLicenseFirstTimeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 454);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.licenseAppInfo);
            this.Controls.Add(this.appBasicInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IssueLicenseFirstTimeFrm";
            this.Text = "Issue Driver License For The First Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AppBasicInfoControl appBasicInfo;
        private Controls.LicenseAppInfoControl licenseAppInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
    }
}