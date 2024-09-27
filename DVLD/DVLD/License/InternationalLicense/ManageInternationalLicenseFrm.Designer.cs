namespace DVLD.Forms
{
    partial class ManageInternationalLicenseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInternationalLicenseFrm));
            this.btn_AddLDLApp = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_RecordsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.dgv_InternationalLicense = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_FiltterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.cbx_Active = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InternationalLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddLDLApp
            // 
            this.btn_AddLDLApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddLDLApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddLDLApp.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddLDLApp.Image")));
            this.btn_AddLDLApp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_AddLDLApp.Location = new System.Drawing.Point(730, 194);
            this.btn_AddLDLApp.Name = "btn_AddLDLApp";
            this.btn_AddLDLApp.Size = new System.Drawing.Size(60, 56);
            this.btn_AddLDLApp.TabIndex = 27;
            this.btn_AddLDLApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddLDLApp.UseVisualStyleBackColor = true;
            this.btn_AddLDLApp.Click += new System.EventHandler(this.btn_AddLDLApp_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(693, 470);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 30);
            this.btn_Exit.TabIndex = 26;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_RecordsNum
            // 
            this.lbl_RecordsNum.AutoSize = true;
            this.lbl_RecordsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsNum.Location = new System.Drawing.Point(103, 470);
            this.lbl_RecordsNum.Name = "lbl_RecordsNum";
            this.lbl_RecordsNum.Size = new System.Drawing.Size(19, 16);
            this.lbl_RecordsNum.TabIndex = 25;
            this.lbl_RecordsNum.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "# Records :";
            // 
            // txt_Find
            // 
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Find.Location = new System.Drawing.Point(253, 229);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(168, 22);
            this.txt_Find.TabIndex = 23;
            this.txt_Find.Visible = false;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // dgv_InternationalLicense
            // 
            this.dgv_InternationalLicense.AllowUserToAddRows = false;
            this.dgv_InternationalLicense.AllowUserToDeleteRows = false;
            this.dgv_InternationalLicense.BackgroundColor = System.Drawing.Color.White;
            this.dgv_InternationalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InternationalLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_InternationalLicense.Location = new System.Drawing.Point(11, 257);
            this.dgv_InternationalLicense.MultiSelect = false;
            this.dgv_InternationalLicense.Name = "dgv_InternationalLicense";
            this.dgv_InternationalLicense.ReadOnly = true;
            this.dgv_InternationalLicense.Size = new System.Drawing.Size(779, 200);
            this.dgv_InternationalLicense.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsTSMI,
            this.showLicenseDetailsTSMI,
            this.showPersonLicenseHistoryTSMI});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 118);
            // 
            // showPersonDetailsTSMI
            // 
            this.showPersonDetailsTSMI.Image = ((System.Drawing.Image)(resources.GetObject("showPersonDetailsTSMI.Image")));
            this.showPersonDetailsTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsTSMI.Name = "showPersonDetailsTSMI";
            this.showPersonDetailsTSMI.Size = new System.Drawing.Size(241, 38);
            this.showPersonDetailsTSMI.Text = "Show Person Details";
            this.showPersonDetailsTSMI.Click += new System.EventHandler(this.showPersonDetailsTSMI_Click);
            // 
            // showLicenseDetailsTSMI
            // 
            this.showLicenseDetailsTSMI.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseDetailsTSMI.Image")));
            this.showLicenseDetailsTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetailsTSMI.Name = "showLicenseDetailsTSMI";
            this.showLicenseDetailsTSMI.Size = new System.Drawing.Size(241, 38);
            this.showLicenseDetailsTSMI.Text = "Show License Details";
            this.showLicenseDetailsTSMI.Click += new System.EventHandler(this.showLicenseDetailsTSMI_Click);
            // 
            // showPersonLicenseHistoryTSMI
            // 
            this.showPersonLicenseHistoryTSMI.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryTSMI.Image")));
            this.showPersonLicenseHistoryTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryTSMI.Name = "showPersonLicenseHistoryTSMI";
            this.showPersonLicenseHistoryTSMI.Size = new System.Drawing.Size(241, 38);
            this.showPersonLicenseHistoryTSMI.Text = "Show Person License History";
            this.showPersonLicenseHistoryTSMI.Click += new System.EventHandler(this.showPersonLicenseHistoryTSMI_Click);
            // 
            // cbx_FiltterBy
            // 
            this.cbx_FiltterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_FiltterBy.FormattingEnabled = true;
            this.cbx_FiltterBy.Items.AddRange(new object[] {
            "None",
            "Int.License ID",
            "Application ID",
            "Driver ID",
            "L.License ID",
            "Is Active"});
            this.cbx_FiltterBy.Location = new System.Drawing.Point(97, 227);
            this.cbx_FiltterBy.Name = "cbx_FiltterBy";
            this.cbx_FiltterBy.Size = new System.Drawing.Size(150, 24);
            this.cbx_FiltterBy.TabIndex = 21;
            this.cbx_FiltterBy.Text = "None";
            this.cbx_FiltterBy.SelectedIndexChanged += new System.EventHandler(this.cbx_FiltterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filtter By : ";
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(318, 9);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(179, 182);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 19;
            this.picBox.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(267, 194);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(284, 24);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Manage International License";
            // 
            // cbx_Active
            // 
            this.cbx_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbx_Active.FormattingEnabled = true;
            this.cbx_Active.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not active"});
            this.cbx_Active.Location = new System.Drawing.Point(253, 228);
            this.cbx_Active.Name = "cbx_Active";
            this.cbx_Active.Size = new System.Drawing.Size(168, 24);
            this.cbx_Active.TabIndex = 28;
            this.cbx_Active.Visible = false;
            this.cbx_Active.SelectedIndexChanged += new System.EventHandler(this.cbx_Active_SelectedIndexChanged);
            // 
            // ManageInternationalLicenseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.cbx_Active);
            this.Controls.Add(this.btn_AddLDLApp);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_RecordsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.dgv_InternationalLicense);
            this.Controls.Add(this.cbx_FiltterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageInternationalLicenseFrm";
            this.Text = "Manage International License";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InternationalLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddLDLApp;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_RecordsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.DataGridView dgv_InternationalLicense;
        private System.Windows.Forms.ComboBox cbx_FiltterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox cbx_Active;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsTSMI;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsTSMI;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryTSMI;
    }
}