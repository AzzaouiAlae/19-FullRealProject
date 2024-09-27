namespace DVLD.Forms.License
{
    partial class LocalDrivingLicenseAppFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalDrivingLicenseAppFrm));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.dgv_LocalLicense = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAppDetailsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editAppTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAppTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelAppTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sechduleTestsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueLicenseFirstTimeTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseHistoryTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_FiltterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_RecordsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btn_AddLDLApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(235, 188);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(330, 24);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Local Driving License Applications";
            // 
            // txt_Find
            // 
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Find.Location = new System.Drawing.Point(231, 223);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(168, 22);
            this.txt_Find.TabIndex = 13;
            this.txt_Find.Visible = false;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // dgv_LocalLicense
            // 
            this.dgv_LocalLicense.AllowUserToAddRows = false;
            this.dgv_LocalLicense.AllowUserToDeleteRows = false;
            this.dgv_LocalLicense.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LocalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LocalLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_LocalLicense.Location = new System.Drawing.Point(12, 251);
            this.dgv_LocalLicense.MultiSelect = false;
            this.dgv_LocalLicense.Name = "dgv_LocalLicense";
            this.dgv_LocalLicense.ReadOnly = true;
            this.dgv_LocalLicense.Size = new System.Drawing.Size(779, 200);
            this.dgv_LocalLicense.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppDetailsTSM,
            this.toolStripMenuItem1,
            this.editAppTSM,
            this.deleteAppTSM,
            this.toolStripMenuItem2,
            this.cancelAppTSM,
            this.toolStripMenuItem3,
            this.sechduleTestsTSM,
            this.toolStripMenuItem4,
            this.issueLicenseFirstTimeTSM,
            this.toolStripMenuItem5,
            this.showLicenseTSM,
            this.toolStripMenuItem6,
            this.showLicenseHistoryTSM});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(259, 344);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showAppDetailsTSM
            // 
            this.showAppDetailsTSM.Image = ((System.Drawing.Image)(resources.GetObject("showAppDetailsTSM.Image")));
            this.showAppDetailsTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showAppDetailsTSM.Name = "showAppDetailsTSM";
            this.showAppDetailsTSM.Size = new System.Drawing.Size(258, 38);
            this.showAppDetailsTSM.Text = "Show Application Details";
            this.showAppDetailsTSM.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(255, 6);
            // 
            // editAppTSM
            // 
            this.editAppTSM.Image = ((System.Drawing.Image)(resources.GetObject("editAppTSM.Image")));
            this.editAppTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editAppTSM.Name = "editAppTSM";
            this.editAppTSM.Size = new System.Drawing.Size(258, 38);
            this.editAppTSM.Text = "Edit Application";
            this.editAppTSM.Click += new System.EventHandler(this.editAppTSM_Click);
            // 
            // deleteAppTSM
            // 
            this.deleteAppTSM.Image = ((System.Drawing.Image)(resources.GetObject("deleteAppTSM.Image")));
            this.deleteAppTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteAppTSM.Name = "deleteAppTSM";
            this.deleteAppTSM.Size = new System.Drawing.Size(258, 38);
            this.deleteAppTSM.Text = "Delete Application";
            this.deleteAppTSM.Click += new System.EventHandler(this.deleteAppTSM_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(255, 6);
            // 
            // cancelAppTSM
            // 
            this.cancelAppTSM.Image = ((System.Drawing.Image)(resources.GetObject("cancelAppTSM.Image")));
            this.cancelAppTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelAppTSM.Name = "cancelAppTSM";
            this.cancelAppTSM.Size = new System.Drawing.Size(258, 38);
            this.cancelAppTSM.Text = "Cancel Application";
            this.cancelAppTSM.Click += new System.EventHandler(this.cancelAppTSM_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(255, 6);
            // 
            // sechduleTestsTSM
            // 
            this.sechduleTestsTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestTSM,
            this.scheduleWrittenTestTSM,
            this.scheduleStreetTestTSM});
            this.sechduleTestsTSM.Image = ((System.Drawing.Image)(resources.GetObject("sechduleTestsTSM.Image")));
            this.sechduleTestsTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sechduleTestsTSM.Name = "sechduleTestsTSM";
            this.sechduleTestsTSM.Size = new System.Drawing.Size(258, 38);
            this.sechduleTestsTSM.Text = "Schedule Tests";
            // 
            // scheduleVisionTestTSM
            // 
            this.scheduleVisionTestTSM.Image = ((System.Drawing.Image)(resources.GetObject("scheduleVisionTestTSM.Image")));
            this.scheduleVisionTestTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleVisionTestTSM.Name = "scheduleVisionTestTSM";
            this.scheduleVisionTestTSM.Size = new System.Drawing.Size(203, 38);
            this.scheduleVisionTestTSM.Text = "Schedule Vision Test";
            this.scheduleVisionTestTSM.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestTSM
            // 
            this.scheduleWrittenTestTSM.Image = ((System.Drawing.Image)(resources.GetObject("scheduleWrittenTestTSM.Image")));
            this.scheduleWrittenTestTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleWrittenTestTSM.Name = "scheduleWrittenTestTSM";
            this.scheduleWrittenTestTSM.Size = new System.Drawing.Size(203, 38);
            this.scheduleWrittenTestTSM.Text = "Schedule Written Test";
            this.scheduleWrittenTestTSM.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestTSM
            // 
            this.scheduleStreetTestTSM.Image = ((System.Drawing.Image)(resources.GetObject("scheduleStreetTestTSM.Image")));
            this.scheduleStreetTestTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleStreetTestTSM.Name = "scheduleStreetTestTSM";
            this.scheduleStreetTestTSM.Size = new System.Drawing.Size(203, 38);
            this.scheduleStreetTestTSM.Text = "Schedule Street Test";
            this.scheduleStreetTestTSM.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(255, 6);
            // 
            // issueLicenseFirstTimeTSM
            // 
            this.issueLicenseFirstTimeTSM.Image = ((System.Drawing.Image)(resources.GetObject("issueLicenseFirstTimeTSM.Image")));
            this.issueLicenseFirstTimeTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueLicenseFirstTimeTSM.Name = "issueLicenseFirstTimeTSM";
            this.issueLicenseFirstTimeTSM.Size = new System.Drawing.Size(258, 38);
            this.issueLicenseFirstTimeTSM.Text = "Issue Driving License(First Time)";
            this.issueLicenseFirstTimeTSM.Click += new System.EventHandler(this.issueLicenseFirstTimeTSM_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(255, 6);
            // 
            // showLicenseTSM
            // 
            this.showLicenseTSM.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseTSM.Image")));
            this.showLicenseTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseTSM.Name = "showLicenseTSM";
            this.showLicenseTSM.Size = new System.Drawing.Size(258, 38);
            this.showLicenseTSM.Text = "Show License";
            this.showLicenseTSM.Click += new System.EventHandler(this.showLicenseTSM_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(255, 6);
            // 
            // showLicenseHistoryTSM
            // 
            this.showLicenseHistoryTSM.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseHistoryTSM.Image")));
            this.showLicenseHistoryTSM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseHistoryTSM.Name = "showLicenseHistoryTSM";
            this.showLicenseHistoryTSM.Size = new System.Drawing.Size(258, 38);
            this.showLicenseHistoryTSM.Text = "Show Person License History";
            this.showLicenseHistoryTSM.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // cbx_FiltterBy
            // 
            this.cbx_FiltterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_FiltterBy.FormattingEnabled = true;
            this.cbx_FiltterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "ClassName",
            "NationalNo",
            "Full Name",
            "ApplicationDate",
            "PassTests",
            "Status"});
            this.cbx_FiltterBy.Location = new System.Drawing.Point(98, 221);
            this.cbx_FiltterBy.Name = "cbx_FiltterBy";
            this.cbx_FiltterBy.Size = new System.Drawing.Size(121, 24);
            this.cbx_FiltterBy.TabIndex = 11;
            this.cbx_FiltterBy.Text = "None";
            this.cbx_FiltterBy.SelectedIndexChanged += new System.EventHandler(this.cbx_FiltterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtter By : ";
            // 
            // lbl_RecordsNum
            // 
            this.lbl_RecordsNum.AutoSize = true;
            this.lbl_RecordsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsNum.Location = new System.Drawing.Point(104, 464);
            this.lbl_RecordsNum.Name = "lbl_RecordsNum";
            this.lbl_RecordsNum.Size = new System.Drawing.Size(19, 16);
            this.lbl_RecordsNum.TabIndex = 15;
            this.lbl_RecordsNum.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "# Records :";
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(694, 464);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 30);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(323, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(179, 182);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            // 
            // btn_AddLDLApp
            // 
            this.btn_AddLDLApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddLDLApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddLDLApp.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddLDLApp.Image")));
            this.btn_AddLDLApp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_AddLDLApp.Location = new System.Drawing.Point(731, 188);
            this.btn_AddLDLApp.Name = "btn_AddLDLApp";
            this.btn_AddLDLApp.Size = new System.Drawing.Size(60, 56);
            this.btn_AddLDLApp.TabIndex = 17;
            this.btn_AddLDLApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddLDLApp.UseVisualStyleBackColor = true;
            this.btn_AddLDLApp.Click += new System.EventHandler(this.btn_AddLDLApp_Click);
            // 
            // LocalDrivingLicenseAppFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 502);
            this.Controls.Add(this.btn_AddLDLApp);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_RecordsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.dgv_LocalLicense);
            this.Controls.Add(this.cbx_FiltterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocalDrivingLicenseAppFrm";
            this.Text = "Local Driving License Applications";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.DataGridView dgv_LocalLicense;
        private System.Windows.Forms.ComboBox cbx_FiltterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_RecordsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showAppDetailsTSM;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editAppTSM;
        private System.Windows.Forms.ToolStripMenuItem deleteAppTSM;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelAppTSM;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestsTSM;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem issueLicenseFirstTimeTSM;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showLicenseTSM;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem showLicenseHistoryTSM;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestTSM;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestTSM;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestTSM;
        private System.Windows.Forms.Button btn_AddLDLApp;
    }
}