namespace DVLD.Controls
{
    partial class DriverLicensesControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverLicensesControl));
            this.gb_DriverLicenses = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_Local = new System.Windows.Forms.TabPage();
            this.lbl_LocalRecordsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_LocalLicense = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_International = new System.Windows.Forms.TabPage();
            this.lbl_InternationalRecordsNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_InternationalLicense = new System.Windows.Forms.DataGridView();
            this.gb_DriverLicenses.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tab_International.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InternationalLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DriverLicenses
            // 
            this.gb_DriverLicenses.Controls.Add(this.tabControl);
            this.gb_DriverLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DriverLicenses.Location = new System.Drawing.Point(3, 3);
            this.gb_DriverLicenses.Name = "gb_DriverLicenses";
            this.gb_DriverLicenses.Size = new System.Drawing.Size(828, 220);
            this.gb_DriverLicenses.TabIndex = 0;
            this.gb_DriverLicenses.TabStop = false;
            this.gb_DriverLicenses.Text = "Driver Licenses";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_Local);
            this.tabControl.Controls.Add(this.tab_International);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 22);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(819, 188);
            this.tabControl.TabIndex = 0;
            // 
            // tab_Local
            // 
            this.tab_Local.Controls.Add(this.lbl_LocalRecordsNum);
            this.tab_Local.Controls.Add(this.label3);
            this.tab_Local.Controls.Add(this.label1);
            this.tab_Local.Controls.Add(this.dgv_LocalLicense);
            this.tab_Local.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tab_Local.Location = new System.Drawing.Point(4, 27);
            this.tab_Local.Name = "tab_Local";
            this.tab_Local.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Local.Size = new System.Drawing.Size(811, 157);
            this.tab_Local.TabIndex = 0;
            this.tab_Local.Text = "Local";
            this.tab_Local.UseVisualStyleBackColor = true;
            // 
            // lbl_LocalRecordsNum
            // 
            this.lbl_LocalRecordsNum.AutoSize = true;
            this.lbl_LocalRecordsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LocalRecordsNum.Location = new System.Drawing.Point(105, 133);
            this.lbl_LocalRecordsNum.Name = "lbl_LocalRecordsNum";
            this.lbl_LocalRecordsNum.Size = new System.Drawing.Size(19, 16);
            this.lbl_LocalRecordsNum.TabIndex = 19;
            this.lbl_LocalRecordsNum.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "# Records :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Local Licenses History:";
            // 
            // dgv_LocalLicense
            // 
            this.dgv_LocalLicense.AllowUserToAddRows = false;
            this.dgv_LocalLicense.AllowUserToDeleteRows = false;
            this.dgv_LocalLicense.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LocalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LocalLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_LocalLicense.Location = new System.Drawing.Point(16, 23);
            this.dgv_LocalLicense.MultiSelect = false;
            this.dgv_LocalLicense.Name = "dgv_LocalLicense";
            this.dgv_LocalLicense.ReadOnly = true;
            this.dgv_LocalLicense.Size = new System.Drawing.Size(779, 104);
            this.dgv_LocalLicense.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 42);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseInfoToolStripMenuItem.Image")));
            this.showLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // tab_International
            // 
            this.tab_International.Controls.Add(this.lbl_InternationalRecordsNum);
            this.tab_International.Controls.Add(this.label5);
            this.tab_International.Controls.Add(this.label2);
            this.tab_International.Controls.Add(this.dgv_InternationalLicense);
            this.tab_International.Location = new System.Drawing.Point(4, 27);
            this.tab_International.Name = "tab_International";
            this.tab_International.Padding = new System.Windows.Forms.Padding(3);
            this.tab_International.Size = new System.Drawing.Size(811, 157);
            this.tab_International.TabIndex = 1;
            this.tab_International.Text = "International";
            this.tab_International.UseVisualStyleBackColor = true;
            // 
            // lbl_InternationalRecordsNum
            // 
            this.lbl_InternationalRecordsNum.AutoSize = true;
            this.lbl_InternationalRecordsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InternationalRecordsNum.Location = new System.Drawing.Point(105, 133);
            this.lbl_InternationalRecordsNum.Name = "lbl_InternationalRecordsNum";
            this.lbl_InternationalRecordsNum.Size = new System.Drawing.Size(19, 16);
            this.lbl_InternationalRecordsNum.TabIndex = 21;
            this.lbl_InternationalRecordsNum.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "# Records :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "International License History:";
            // 
            // dgv_InternationalLicense
            // 
            this.dgv_InternationalLicense.AllowUserToAddRows = false;
            this.dgv_InternationalLicense.AllowUserToDeleteRows = false;
            this.dgv_InternationalLicense.BackgroundColor = System.Drawing.Color.White;
            this.dgv_InternationalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InternationalLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_InternationalLicense.Location = new System.Drawing.Point(16, 23);
            this.dgv_InternationalLicense.MultiSelect = false;
            this.dgv_InternationalLicense.Name = "dgv_InternationalLicense";
            this.dgv_InternationalLicense.ReadOnly = true;
            this.dgv_InternationalLicense.Size = new System.Drawing.Size(779, 104);
            this.dgv_InternationalLicense.TabIndex = 18;
            // 
            // DriverLicensesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gb_DriverLicenses);
            this.Name = "DriverLicensesControl";
            this.Size = new System.Drawing.Size(844, 248);
            this.gb_DriverLicenses.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tab_Local.ResumeLayout(false);
            this.tab_Local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tab_International.ResumeLayout(false);
            this.tab_International.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InternationalLicense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DriverLicenses;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_Local;
        private System.Windows.Forms.TabPage tab_International;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_LocalLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_InternationalLicense;
        private System.Windows.Forms.Label lbl_LocalRecordsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_InternationalRecordsNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}
