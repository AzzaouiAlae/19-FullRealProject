namespace DVLD.Forms.License
{
    partial class TestAppointmentsFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestAppointmentsFrm));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.dgv_LocalLicense = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.licenseAppInfo = new DVLD.Controls.LicenseAppInfoControl();
            this.appBasicInfo = new DVLD.Controls.AppBasicInfoControl();
            this.btn_ScheduleTest = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(169, 134);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(248, 24);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "Vision Test Appointments";
            // 
            // dgv_LocalLicense
            // 
            this.dgv_LocalLicense.AllowUserToAddRows = false;
            this.dgv_LocalLicense.AllowUserToDeleteRows = false;
            this.dgv_LocalLicense.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LocalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LocalLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_LocalLicense.Location = new System.Drawing.Point(12, 455);
            this.dgv_LocalLicense.MultiSelect = false;
            this.dgv_LocalLicense.Name = "dgv_LocalLicense";
            this.dgv_LocalLicense.ReadOnly = true;
            this.dgv_LocalLicense.Size = new System.Drawing.Size(576, 84);
            this.dgv_LocalLicense.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeTestToolStripMenuItem.Image")));
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Appointments :";
            // 
            // licenseAppInfo
            // 
            this.licenseAppInfo.BackColor = System.Drawing.Color.White;
            this.licenseAppInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseAppInfo.Location = new System.Drawing.Point(12, 157);
            this.licenseAppInfo.Margin = new System.Windows.Forms.Padding(4);
            this.licenseAppInfo.Name = "licenseAppInfo";
            this.licenseAppInfo.Size = new System.Drawing.Size(587, 89);
            this.licenseAppInfo.TabIndex = 9;
            this.licenseAppInfo.OnFormFill += new System.Action<int>(this.licenseAppInfo_OnFormFill);
            // 
            // appBasicInfo
            // 
            this.appBasicInfo.BackColor = System.Drawing.Color.White;
            this.appBasicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appBasicInfo.Location = new System.Drawing.Point(8, 248);
            this.appBasicInfo.Margin = new System.Windows.Forms.Padding(4);
            this.appBasicInfo.Name = "appBasicInfo";
            this.appBasicInfo.Size = new System.Drawing.Size(587, 169);
            this.appBasicInfo.TabIndex = 8;
            // 
            // btn_ScheduleTest
            // 
            this.btn_ScheduleTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ScheduleTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScheduleTest.Image = ((System.Drawing.Image)(resources.GetObject("btn_ScheduleTest.Image")));
            this.btn_ScheduleTest.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ScheduleTest.Location = new System.Drawing.Point(548, 421);
            this.btn_ScheduleTest.Name = "btn_ScheduleTest";
            this.btn_ScheduleTest.Size = new System.Drawing.Size(40, 30);
            this.btn_ScheduleTest.TabIndex = 18;
            this.btn_ScheduleTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ScheduleTest.UseVisualStyleBackColor = true;
            this.btn_ScheduleTest.Click += new System.EventHandler(this.btn_ScheduleTest_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(491, 543);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 30);
            this.btn_Exit.TabIndex = 17;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TestAppointmentsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 579);
            this.Controls.Add(this.btn_ScheduleTest);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_LocalLicense);
            this.Controls.Add(this.licenseAppInfo);
            this.Controls.Add(this.appBasicInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Title);
            this.Name = "TestAppointmentsFrm";
            this.Text = "Vision Test Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.AppBasicInfoControl appBasicInfo;
        private Controls.LicenseAppInfoControl licenseAppInfo;
        private System.Windows.Forms.DataGridView dgv_LocalLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ScheduleTest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}