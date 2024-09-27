namespace DVLD.Forms
{
    partial class ListDetainedLicensesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDetainedLicensesFrm));
            this.cbx_Active = new System.Windows.Forms.ComboBox();
            this.btn_ReleaseLicense = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_RecordsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.dgv_DetainedLicenses = new System.Windows.Forms.DataGridView();
            this.cbx_FiltterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_DetainedLicenses = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetaibedLicenseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetainedLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_Active
            // 
            this.cbx_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbx_Active.FormattingEnabled = true;
            this.cbx_Active.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not active"});
            this.cbx_Active.Location = new System.Drawing.Point(253, 226);
            this.cbx_Active.Name = "cbx_Active";
            this.cbx_Active.Size = new System.Drawing.Size(157, 24);
            this.cbx_Active.TabIndex = 39;
            this.cbx_Active.Visible = false;
            this.cbx_Active.SelectedIndexChanged += new System.EventHandler(this.cbx_Active_SelectedIndexChanged);
            // 
            // btn_ReleaseLicense
            // 
            this.btn_ReleaseLicense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ReleaseLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReleaseLicense.Image = ((System.Drawing.Image)(resources.GetObject("btn_ReleaseLicense.Image")));
            this.btn_ReleaseLicense.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_ReleaseLicense.Location = new System.Drawing.Point(860, 194);
            this.btn_ReleaseLicense.Name = "btn_ReleaseLicense";
            this.btn_ReleaseLicense.Size = new System.Drawing.Size(60, 56);
            this.btn_ReleaseLicense.TabIndex = 38;
            this.btn_ReleaseLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ReleaseLicense.UseVisualStyleBackColor = true;
            this.btn_ReleaseLicense.Click += new System.EventHandler(this.btn_ReleaseLicense_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(823, 462);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(97, 30);
            this.btn_Exit.TabIndex = 37;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_RecordsNum
            // 
            this.lbl_RecordsNum.AutoSize = true;
            this.lbl_RecordsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsNum.Location = new System.Drawing.Point(103, 468);
            this.lbl_RecordsNum.Name = "lbl_RecordsNum";
            this.lbl_RecordsNum.Size = new System.Drawing.Size(19, 16);
            this.lbl_RecordsNum.TabIndex = 36;
            this.lbl_RecordsNum.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "# Records :";
            // 
            // txt_Find
            // 
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Find.Location = new System.Drawing.Point(253, 227);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(168, 22);
            this.txt_Find.TabIndex = 34;
            this.txt_Find.Visible = false;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // dgv_DetainedLicenses
            // 
            this.dgv_DetainedLicenses.AllowUserToAddRows = false;
            this.dgv_DetainedLicenses.AllowUserToDeleteRows = false;
            this.dgv_DetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetainedLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_DetainedLicenses.Location = new System.Drawing.Point(11, 255);
            this.dgv_DetainedLicenses.MultiSelect = false;
            this.dgv_DetainedLicenses.Name = "dgv_DetainedLicenses";
            this.dgv_DetainedLicenses.ReadOnly = true;
            this.dgv_DetainedLicenses.Size = new System.Drawing.Size(909, 200);
            this.dgv_DetainedLicenses.TabIndex = 33;
            // 
            // cbx_FiltterBy
            // 
            this.cbx_FiltterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_FiltterBy.FormattingEnabled = true;
            this.cbx_FiltterBy.Items.AddRange(new object[] {
            "None",
            "D.ID",
            "L.ID",
            "Is Released",
            "N.No",
            "Full Name",
            "Release App.ID"});
            this.cbx_FiltterBy.Location = new System.Drawing.Point(97, 225);
            this.cbx_FiltterBy.Name = "cbx_FiltterBy";
            this.cbx_FiltterBy.Size = new System.Drawing.Size(150, 24);
            this.cbx_FiltterBy.TabIndex = 32;
            this.cbx_FiltterBy.Text = "None";
            this.cbx_FiltterBy.SelectedIndexChanged += new System.EventHandler(this.cbx_FiltterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Filtter By : ";
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(374, 1);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(179, 182);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 30;
            this.picBox.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(351, 194);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(219, 24);
            this.lbl_Title.TabIndex = 29;
            this.lbl_Title.Text = "List Detained Licenses";
            // 
            // btn_DetainedLicenses
            // 
            this.btn_DetainedLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DetainedLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DetainedLicenses.Image = ((System.Drawing.Image)(resources.GetObject("btn_DetainedLicenses.Image")));
            this.btn_DetainedLicenses.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_DetainedLicenses.Location = new System.Drawing.Point(794, 194);
            this.btn_DetainedLicenses.Name = "btn_DetainedLicenses";
            this.btn_DetainedLicenses.Size = new System.Drawing.Size(60, 56);
            this.btn_DetainedLicenses.TabIndex = 40;
            this.btn_DetainedLicenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DetainedLicenses.UseVisualStyleBackColor = true;
            this.btn_DetainedLicenses.Click += new System.EventHandler(this.btn_DetainedLicenses_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsTSMI,
            this.showLicenseDetailsTSMI,
            this.showPersonLicenseHistoryTSMI,
            this.toolStripMenuItem1,
            this.releaseDetaibedLicenseTSMI});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 168);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 6);
            // 
            // releaseDetaibedLicenseTSMI
            // 
            this.releaseDetaibedLicenseTSMI.Image = ((System.Drawing.Image)(resources.GetObject("releaseDetaibedLicenseTSMI.Image")));
            this.releaseDetaibedLicenseTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetaibedLicenseTSMI.Name = "releaseDetaibedLicenseTSMI";
            this.releaseDetaibedLicenseTSMI.Size = new System.Drawing.Size(241, 38);
            this.releaseDetaibedLicenseTSMI.Text = "Release Detaibed License";
            this.releaseDetaibedLicenseTSMI.Click += new System.EventHandler(this.releaseDetaibedLicenseTSMI_Click);
            // 
            // ListDetainedLicensesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 504);
            this.Controls.Add(this.btn_DetainedLicenses);
            this.Controls.Add(this.cbx_Active);
            this.Controls.Add(this.btn_ReleaseLicense);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_RecordsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.dgv_DetainedLicenses);
            this.Controls.Add(this.cbx_FiltterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListDetainedLicensesFrm";
            this.Text = "List Detained Licenses";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetainedLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Active;
        private System.Windows.Forms.Button btn_ReleaseLicense;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_RecordsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.DataGridView dgv_DetainedLicenses;
        private System.Windows.Forms.ComboBox cbx_FiltterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_DetainedLicenses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsTSMI;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsTSMI;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetaibedLicenseTSMI;
    }
}