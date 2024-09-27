namespace DVLD.Forms.Tests
{
    partial class TakeTestFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeTestFrm));
            this.visionTestControl1 = new DVLD.Controls.License.TestControl();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_Pass = new System.Windows.Forms.RadioButton();
            this.rb_Fail = new System.Windows.Forms.RadioButton();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // visionTestControl1
            // 
            this.visionTestControl1.BackColor = System.Drawing.Color.White;
            this.visionTestControl1.Location = new System.Drawing.Point(0, 0);
            this.visionTestControl1.Name = "visionTestControl1";
            this.visionTestControl1.Size = new System.Drawing.Size(448, 379);
            this.visionTestControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result :";
            // 
            // rb_Pass
            // 
            this.rb_Pass.AutoSize = true;
            this.rb_Pass.Checked = true;
            this.rb_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Pass.Location = new System.Drawing.Point(177, 380);
            this.rb_Pass.Name = "rb_Pass";
            this.rb_Pass.Size = new System.Drawing.Size(56, 20);
            this.rb_Pass.TabIndex = 2;
            this.rb_Pass.TabStop = true;
            this.rb_Pass.Text = "Pass";
            this.rb_Pass.UseVisualStyleBackColor = true;
            // 
            // rb_Fail
            // 
            this.rb_Fail.AutoSize = true;
            this.rb_Fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Fail.Location = new System.Drawing.Point(239, 380);
            this.rb_Fail.Name = "rb_Fail";
            this.rb_Fail.Size = new System.Drawing.Size(47, 20);
            this.rb_Fail.TabIndex = 3;
            this.rb_Fail.Text = "Fail";
            this.rb_Fail.UseVisualStyleBackColor = true;
            // 
            // txt_Note
            // 
            this.txt_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Note.Location = new System.Drawing.Point(177, 406);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(256, 77);
            this.txt_Note.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Note :";
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(343, 489);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 30);
            this.btn_Save.TabIndex = 61;
            this.btn_Save.Text = "   Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(255, 489);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 30);
            this.btn_Exit.TabIndex = 62;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // TakeTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 526);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.rb_Fail);
            this.Controls.Add(this.rb_Pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visionTestControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TakeTestFrm";
            this.Text = "TakeTestFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.License.TestControl visionTestControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_Pass;
        private System.Windows.Forms.RadioButton rb_Fail;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
    }
}