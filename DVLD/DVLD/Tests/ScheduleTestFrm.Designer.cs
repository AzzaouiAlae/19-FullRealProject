namespace DVLD.Forms
{
    partial class ScheduleTestFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleTestFrm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.visionTest = new DVLD.Controls.License.TestControl();
            this.retakeTestInfo = new DVLD.Controls.License.RetakeTestInfoControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(351, 514);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 30);
            this.btn_Exit.TabIndex = 61;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // visionTest
            // 
            this.visionTest.BackColor = System.Drawing.Color.White;
            this.visionTest.Location = new System.Drawing.Point(0, 84);
            this.visionTest.Name = "visionTest";
            this.visionTest.Size = new System.Drawing.Size(448, 352);
            this.visionTest.TabIndex = 8;
            this.visionTest.onSave += new System.Action<DVLD_Business.clsTestAppointment>(this.visionTest_onSave);
            // 
            // retakeTestInfo
            // 
            this.retakeTestInfo.BackColor = System.Drawing.Color.White;
            this.retakeTestInfo.Enabled = false;
            this.retakeTestInfo.Location = new System.Drawing.Point(0, 435);
            this.retakeTestInfo.Name = "retakeTestInfo";
            this.retakeTestInfo.Size = new System.Drawing.Size(448, 74);
            this.retakeTestInfo.TabIndex = 62;
            // 
            // ScheduleTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 550);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.retakeTestInfo);
            this.Controls.Add(this.visionTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScheduleTestFrm";
            this.Text = "Schedule Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.License.TestControl visionTest;
        private System.Windows.Forms.Button btn_Exit;
        private Controls.License.RetakeTestInfoControl retakeTestInfo;
    }
}