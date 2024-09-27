namespace DVLD.Forms
{
    partial class ManageDriversFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDriversFrm));
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.lbl_RecordsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Drivers = new System.Windows.Forms.DataGridView();
            this.cbx_FiltterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonInfoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInternationalLicenseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHistoryTSMI = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Find
            // 
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Find.Location = new System.Drawing.Point(245, 170);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(168, 22);
            this.txt_Find.TabIndex = 18;
            this.txt_Find.Visible = false;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // lbl_RecordsNum
            // 
            this.lbl_RecordsNum.AutoSize = true;
            this.lbl_RecordsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsNum.Location = new System.Drawing.Point(112, 417);
            this.lbl_RecordsNum.Name = "lbl_RecordsNum";
            this.lbl_RecordsNum.Size = new System.Drawing.Size(19, 16);
            this.lbl_RecordsNum.TabIndex = 16;
            this.lbl_RecordsNum.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "# Records :";
            // 
            // dgv_Drivers
            // 
            this.dgv_Drivers.AllowUserToAddRows = false;
            this.dgv_Drivers.AllowUserToDeleteRows = false;
            this.dgv_Drivers.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Drivers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Drivers.Location = new System.Drawing.Point(8, 201);
            this.dgv_Drivers.MultiSelect = false;
            this.dgv_Drivers.Name = "dgv_Drivers";
            this.dgv_Drivers.ReadOnly = true;
            this.dgv_Drivers.Size = new System.Drawing.Size(785, 200);
            this.dgv_Drivers.TabIndex = 14;
            // 
            // cbx_FiltterBy
            // 
            this.cbx_FiltterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_FiltterBy.FormattingEnabled = true;
            this.cbx_FiltterBy.Items.AddRange(new object[] {
            "None",
            "DriverID",
            "PersonID",
            "NationalNo",
            "Full Name"});
            this.cbx_FiltterBy.Location = new System.Drawing.Point(112, 168);
            this.cbx_FiltterBy.Name = "cbx_FiltterBy";
            this.cbx_FiltterBy.Size = new System.Drawing.Size(121, 24);
            this.cbx_FiltterBy.TabIndex = 13;
            this.cbx_FiltterBy.Text = "None";
            this.cbx_FiltterBy.SelectedIndexChanged += new System.EventHandler(this.cbx_FiltterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filtter By : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(319, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Drivers";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(691, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "   Exit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(309, 7);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(177, 129);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 10;
            this.picBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonInfoTSMI,
            this.issueInternationalLicenseTSMI,
            this.ShowPersonLicenseHistoryTSMI});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 124);
            // 
            // ShowPersonInfoTSMI
            // 
            this.ShowPersonInfoTSMI.Image = ((System.Drawing.Image)(resources.GetObject("ShowPersonInfoTSMI.Image")));
            this.ShowPersonInfoTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonInfoTSMI.Name = "ShowPersonInfoTSMI";
            this.ShowPersonInfoTSMI.Size = new System.Drawing.Size(241, 38);
            this.ShowPersonInfoTSMI.Text = "Show Person Info";
            this.ShowPersonInfoTSMI.Click += new System.EventHandler(this.ShowPersonInfoTSMI_Click);
            // 
            // issueInternationalLicenseTSMI
            // 
            this.issueInternationalLicenseTSMI.Image = ((System.Drawing.Image)(resources.GetObject("issueInternationalLicenseTSMI.Image")));
            this.issueInternationalLicenseTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueInternationalLicenseTSMI.Name = "issueInternationalLicenseTSMI";
            this.issueInternationalLicenseTSMI.Size = new System.Drawing.Size(241, 38);
            this.issueInternationalLicenseTSMI.Text = "Issue International License";
            this.issueInternationalLicenseTSMI.Click += new System.EventHandler(this.issueInternationalLicenseTSMI_Click);
            // 
            // ShowPersonLicenseHistoryTSMI
            // 
            this.ShowPersonLicenseHistoryTSMI.Image = ((System.Drawing.Image)(resources.GetObject("ShowPersonLicenseHistoryTSMI.Image")));
            this.ShowPersonLicenseHistoryTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowPersonLicenseHistoryTSMI.Name = "ShowPersonLicenseHistoryTSMI";
            this.ShowPersonLicenseHistoryTSMI.Size = new System.Drawing.Size(241, 38);
            this.ShowPersonLicenseHistoryTSMI.Text = "Show Person License History";
            this.ShowPersonLicenseHistoryTSMI.Click += new System.EventHandler(this.ShowPersonLicenseHistoryTSMI_Click);
            // 
            // ManageDriversFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_RecordsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Drivers);
            this.Controls.Add(this.cbx_FiltterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.Name = "ManageDriversFrm";
            this.Text = "Drivers List";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Drivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_RecordsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Drivers;
        private System.Windows.Forms.ComboBox cbx_FiltterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonInfoTSMI;
        private System.Windows.Forms.ToolStripMenuItem issueInternationalLicenseTSMI;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHistoryTSMI;
    }
}