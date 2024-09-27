namespace DVLD.Controls.License
{
    partial class RetakeTestInfoControl
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.lbl_TotalFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_RTestAppID = new System.Windows.Forms.Label();
            this.lbl_RAppFees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.lbl_TotalFees);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.lbl_RTestAppID);
            this.gb.Controls.Add(this.lbl_RAppFees);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.label1);
            this.gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(8, 4);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(427, 71);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "Retake Test Info";
            // 
            // lbl_TotalFees
            // 
            this.lbl_TotalFees.AutoSize = true;
            this.lbl_TotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalFees.Location = new System.Drawing.Point(354, 23);
            this.lbl_TotalFees.Name = "lbl_TotalFees";
            this.lbl_TotalFees.Size = new System.Drawing.Size(19, 16);
            this.lbl_TotalFees.TabIndex = 11;
            this.lbl_TotalFees.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(256, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Fees :";
            // 
            // lbl_RTestAppID
            // 
            this.lbl_RTestAppID.AutoSize = true;
            this.lbl_RTestAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RTestAppID.Location = new System.Drawing.Point(152, 49);
            this.lbl_RTestAppID.Name = "lbl_RTestAppID";
            this.lbl_RTestAppID.Size = new System.Drawing.Size(19, 16);
            this.lbl_RTestAppID.TabIndex = 11;
            this.lbl_RTestAppID.Text = "...";
            // 
            // lbl_RAppFees
            // 
            this.lbl_RAppFees.AutoSize = true;
            this.lbl_RAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RAppFees.Location = new System.Drawing.Point(152, 23);
            this.lbl_RAppFees.Name = "lbl_RAppFees";
            this.lbl_RAppFees.Size = new System.Drawing.Size(19, 16);
            this.lbl_RAppFees.TabIndex = 11;
            this.lbl_RAppFees.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "R.Test.App.ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "R.App.Fees :";
            // 
            // RetakeTestInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gb);
            this.Name = "RetakeTestInfoControl";
            this.Size = new System.Drawing.Size(442, 81);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TotalFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_RTestAppID;
        private System.Windows.Forms.Label lbl_RAppFees;
        private System.Windows.Forms.Label label5;
    }
}
