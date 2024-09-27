namespace DVLD.Forms.License
{
    partial class NewDrivingLicenseFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDrivingLicenseFrm));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.findPerson = new DVLD.Controls.FindPersonControl();
            this.btn_Next = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbx_ClassList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_CreatedBy = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lbl_AppFees = new System.Windows.Forms.Label();
            this.lbl_AppDate = new System.Windows.Forms.Label();
            this.lbl_AppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Red;
            this.lbl_Title.Location = new System.Drawing.Point(122, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(368, 24);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "New Local Driving License Application";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 341);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.findPerson);
            this.tabPage1.Controls.Add(this.btn_Next);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(611, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // findPerson
            // 
            this.findPerson.BackColor = System.Drawing.Color.White;
            this.findPerson.Location = new System.Drawing.Point(6, 6);
            this.findPerson.Name = "findPerson";
            this.findPerson.Size = new System.Drawing.Size(610, 269);
            this.findPerson.TabIndex = 63;
            this.findPerson.onPersonSelected += new System.Action<int>(this.findPerson_onPersonSelected);
            // 
            // btn_Next
            // 
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Next.Location = new System.Drawing.Point(523, 276);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(82, 30);
            this.btn_Next.TabIndex = 62;
            this.btn_Next.Text = "Next";
            this.btn_Next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbx_ClassList);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lbl_CreatedBy);
            this.tabPage2.Controls.Add(this.lbl_);
            this.tabPage2.Controls.Add(this.lbl_AppFees);
            this.tabPage2.Controls.Add(this.lbl_AppDate);
            this.tabPage2.Controls.Add(this.lbl_AppID);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(611, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbx_ClassList
            // 
            this.cbx_ClassList.FormattingEnabled = true;
            this.cbx_ClassList.Location = new System.Drawing.Point(221, 119);
            this.cbx_ClassList.Name = "cbx_ClassList";
            this.cbx_ClassList.Size = new System.Drawing.Size(253, 24);
            this.cbx_ClassList.TabIndex = 4;
            this.cbx_ClassList.SelectedIndexChanged += new System.EventHandler(this.cbx_ClassList_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(77, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Created By :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(77, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application Fees :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(77, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "License Class :";
            // 
            // lbl_CreatedBy
            // 
            this.lbl_CreatedBy.AutoSize = true;
            this.lbl_CreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CreatedBy.Location = new System.Drawing.Point(221, 180);
            this.lbl_CreatedBy.Name = "lbl_CreatedBy";
            this.lbl_CreatedBy.Size = new System.Drawing.Size(19, 16);
            this.lbl_CreatedBy.TabIndex = 1;
            this.lbl_CreatedBy.Text = "...";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_.Location = new System.Drawing.Point(77, 96);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(130, 16);
            this.lbl_.TabIndex = 2;
            this.lbl_.Text = "Application Date :";
            // 
            // lbl_AppFees
            // 
            this.lbl_AppFees.AutoSize = true;
            this.lbl_AppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_AppFees.Location = new System.Drawing.Point(221, 152);
            this.lbl_AppFees.Name = "lbl_AppFees";
            this.lbl_AppFees.Size = new System.Drawing.Size(19, 16);
            this.lbl_AppFees.TabIndex = 1;
            this.lbl_AppFees.Text = "...";
            // 
            // lbl_AppDate
            // 
            this.lbl_AppDate.AutoSize = true;
            this.lbl_AppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_AppDate.Location = new System.Drawing.Point(221, 96);
            this.lbl_AppDate.Name = "lbl_AppDate";
            this.lbl_AppDate.Size = new System.Drawing.Size(19, 16);
            this.lbl_AppDate.TabIndex = 1;
            this.lbl_AppDate.Text = "...";
            // 
            // lbl_AppID
            // 
            this.lbl_AppID.AutoSize = true;
            this.lbl_AppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_AppID.Location = new System.Drawing.Point(221, 69);
            this.lbl_AppID.Name = "lbl_AppID";
            this.lbl_AppID.Size = new System.Drawing.Size(19, 16);
            this.lbl_AppID.TabIndex = 1;
            this.lbl_AppID.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(77, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L.Application ID :";
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(532, 383);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 30);
            this.btn_Save.TabIndex = 63;
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
            this.btn_Exit.Location = new System.Drawing.Point(441, 383);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 30);
            this.btn_Exit.TabIndex = 62;
            this.btn_Exit.Text = "   Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // NewDrivingLicenseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 419);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewDrivingLicenseFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "New Local Driving License Application";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_CreatedBy;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lbl_AppFees;
        private System.Windows.Forms.Label lbl_AppDate;
        private System.Windows.Forms.Label lbl_AppID;
        private System.Windows.Forms.ComboBox cbx_ClassList;
        private Controls.FindPersonControl findPerson;
    }
}