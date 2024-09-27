namespace DVLD.Controls
{
    partial class FindPersonControl
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
            this.personFillter1 = new DVLD.Controls.PersonFillter();
            this.personInfo = new DVLD.PersonInfoControl();
            this.SuspendLayout();
            // 
            // personFillter1
            // 
            this.personFillter1.BackColor = System.Drawing.Color.White;
            this.personFillter1.Location = new System.Drawing.Point(4, 3);
            this.personFillter1.Name = "personFillter1";
            this.personFillter1.Size = new System.Drawing.Size(600, 69);
            this.personFillter1.TabIndex = 63;
            this.personFillter1.onBtnOk += new System.Action<System.Windows.Forms.TextBox, System.Windows.Forms.ComboBox>(this.personFillter1_onBtnOk);
            this.personFillter1.onBtnAdd += new System.Action<System.Windows.Forms.Button>(this.personFillter1_onBtnAdd);
            // 
            // personInfo
            // 
            this.personInfo.BackColor = System.Drawing.Color.White;
            this.personInfo.Location = new System.Drawing.Point(4, 76);
            this.personInfo.Name = "personInfo";
            this.personInfo.Size = new System.Drawing.Size(599, 187);
            this.personInfo.TabIndex = 62;
            this.personInfo.onPersonSelected += new System.Action<int>(this.personInfo_onPersonSelected);
            // 
            // FindPersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.personFillter1);
            this.Controls.Add(this.personInfo);
            this.Name = "FindPersonControl";
            this.Size = new System.Drawing.Size(610, 269);
            this.ResumeLayout(false);

        }

        #endregion
        public PersonInfoControl personInfo;
        public PersonFillter personFillter1;
    }
}
