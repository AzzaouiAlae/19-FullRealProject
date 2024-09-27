namespace DVLD.Controls
{
    partial class DetainInfoControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_DetainID = new System.Windows.Forms.Label();
            this.lbl_DetainDate = new System.Windows.Forms.Label();
            this.lbl_LicenseID = new System.Windows.Forms.Label();
            this.lbl_CreatedBy = new System.Windows.Forms.Label();
            this.txt_FineFees = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_FineFees);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_CreatedBy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_LicenseID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_DetainDate);
            this.groupBox1.Controls.Add(this.lbl_DetainID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detain Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fine Fees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "License ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Created By :";
            // 
            // lbl_DetainID
            // 
            this.lbl_DetainID.AutoSize = true;
            this.lbl_DetainID.Location = new System.Drawing.Point(121, 31);
            this.lbl_DetainID.Name = "lbl_DetainID";
            this.lbl_DetainID.Size = new System.Drawing.Size(19, 16);
            this.lbl_DetainID.TabIndex = 0;
            this.lbl_DetainID.Text = "...";
            // 
            // lbl_DetainDate
            // 
            this.lbl_DetainDate.AutoSize = true;
            this.lbl_DetainDate.Location = new System.Drawing.Point(121, 57);
            this.lbl_DetainDate.Name = "lbl_DetainDate";
            this.lbl_DetainDate.Size = new System.Drawing.Size(19, 16);
            this.lbl_DetainDate.TabIndex = 0;
            this.lbl_DetainDate.Text = "...";
            // 
            // lbl_LicenseID
            // 
            this.lbl_LicenseID.AutoSize = true;
            this.lbl_LicenseID.Location = new System.Drawing.Point(424, 31);
            this.lbl_LicenseID.Name = "lbl_LicenseID";
            this.lbl_LicenseID.Size = new System.Drawing.Size(19, 16);
            this.lbl_LicenseID.TabIndex = 0;
            this.lbl_LicenseID.Text = "...";
            // 
            // lbl_CreatedBy
            // 
            this.lbl_CreatedBy.AutoSize = true;
            this.lbl_CreatedBy.Location = new System.Drawing.Point(424, 57);
            this.lbl_CreatedBy.Name = "lbl_CreatedBy";
            this.lbl_CreatedBy.Size = new System.Drawing.Size(19, 16);
            this.lbl_CreatedBy.TabIndex = 0;
            this.lbl_CreatedBy.Text = "...";
            // 
            // txt_FineFees
            // 
            this.txt_FineFees.Location = new System.Drawing.Point(124, 82);
            this.txt_FineFees.Name = "txt_FineFees";
            this.txt_FineFees.Size = new System.Drawing.Size(138, 22);
            this.txt_FineFees.TabIndex = 1;
            this.txt_FineFees.TextChanged += new System.EventHandler(this.txt_FineFees_TextChanged);
            this.txt_FineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FineFees_KeyPress);
            // 
            // DetainInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "DetainInfoControl";
            this.Size = new System.Drawing.Size(635, 121);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FineFees;
        private System.Windows.Forms.Label lbl_CreatedBy;
        private System.Windows.Forms.Label lbl_LicenseID;
        private System.Windows.Forms.Label lbl_DetainDate;
        private System.Windows.Forms.Label lbl_DetainID;
    }
}
