namespace DVLD
{
    partial class ManagePeopleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePeopleFrm));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_FiltterBy = new System.Windows.Forms.ComboBox();
            this.dgv_People = new System.Windows.Forms.DataGridView();
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.show_Details = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Send_Email = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_RecordsNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_AddPerson = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_People)).BeginInit();
            this.conMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(404, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(177, 129);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(414, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtter By : ";
            // 
            // cbx_FiltterBy
            // 
            this.cbx_FiltterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_FiltterBy.FormattingEnabled = true;
            this.cbx_FiltterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationalily",
            "Gender",
            "Phone",
            "Email"});
            this.cbx_FiltterBy.Location = new System.Drawing.Point(98, 179);
            this.cbx_FiltterBy.Name = "cbx_FiltterBy";
            this.cbx_FiltterBy.Size = new System.Drawing.Size(121, 24);
            this.cbx_FiltterBy.TabIndex = 3;
            this.cbx_FiltterBy.Text = "None";
            this.cbx_FiltterBy.SelectedIndexChanged += new System.EventHandler(this.cbx_FiltterBy_SelectedIndexChanged);
            // 
            // dgv_People
            // 
            this.dgv_People.AllowUserToAddRows = false;
            this.dgv_People.AllowUserToDeleteRows = false;
            this.dgv_People.BackgroundColor = System.Drawing.Color.White;
            this.dgv_People.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_People.ContextMenuStrip = this.conMenu;
            this.dgv_People.Location = new System.Drawing.Point(12, 209);
            this.dgv_People.MultiSelect = false;
            this.dgv_People.Name = "dgv_People";
            this.dgv_People.ReadOnly = true;
            this.dgv_People.Size = new System.Drawing.Size(967, 200);
            this.dgv_People.TabIndex = 4;
            // 
            // conMenu
            // 
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_Details,
            this.toolStripSeparator1,
            this.AddNewPerson,
            this.Edit,
            this.Delete,
            this.toolStripSeparator2,
            this.Send_Email,
            this.PhoneCall});
            this.conMenu.Name = "conMenu";
            this.conMenu.Size = new System.Drawing.Size(179, 244);
            // 
            // show_Details
            // 
            this.show_Details.Image = ((System.Drawing.Image)(resources.GetObject("show_Details.Image")));
            this.show_Details.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.show_Details.Name = "show_Details";
            this.show_Details.Size = new System.Drawing.Size(178, 38);
            this.show_Details.Text = "Show Details";
            this.show_Details.Click += new System.EventHandler(this.show_Details_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // AddNewPerson
            // 
            this.AddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("AddNewPerson.Image")));
            this.AddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPerson.Name = "AddNewPerson";
            this.AddNewPerson.Size = new System.Drawing.Size(178, 38);
            this.AddNewPerson.Text = "Add New Person";
            this.AddNewPerson.Click += new System.EventHandler(this.AddNewPerson_Click);
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(178, 38);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(178, 38);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // Send_Email
            // 
            this.Send_Email.Image = ((System.Drawing.Image)(resources.GetObject("Send_Email.Image")));
            this.Send_Email.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Send_Email.Name = "Send_Email";
            this.Send_Email.Size = new System.Drawing.Size(178, 38);
            this.Send_Email.Text = "Send Email";
            this.Send_Email.Click += new System.EventHandler(this.Send_Email_Click);
            // 
            // PhoneCall
            // 
            this.PhoneCall.Image = ((System.Drawing.Image)(resources.GetObject("PhoneCall.Image")));
            this.PhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PhoneCall.Name = "PhoneCall";
            this.PhoneCall.Size = new System.Drawing.Size(178, 38);
            this.PhoneCall.Text = "Phone Call";
            this.PhoneCall.Click += new System.EventHandler(this.PhoneCall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "# Records :";
            // 
            // lbl_RecordsNum
            // 
            this.lbl_RecordsNum.AutoSize = true;
            this.lbl_RecordsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsNum.Location = new System.Drawing.Point(104, 426);
            this.lbl_RecordsNum.Name = "lbl_RecordsNum";
            this.lbl_RecordsNum.Size = new System.Drawing.Size(19, 16);
            this.lbl_RecordsNum.TabIndex = 6;
            this.lbl_RecordsNum.Text = "...";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(882, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "   Exit";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_AddPerson
            // 
            this.btn_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPerson.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddPerson.Image")));
            this.btn_AddPerson.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_AddPerson.Location = new System.Drawing.Point(919, 148);
            this.btn_AddPerson.Name = "btn_AddPerson";
            this.btn_AddPerson.Size = new System.Drawing.Size(60, 56);
            this.btn_AddPerson.TabIndex = 8;
            this.btn_AddPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddPerson.UseVisualStyleBackColor = true;
            this.btn_AddPerson.Click += new System.EventHandler(this.btn_AddPerson_Click);
            // 
            // txt_Find
            // 
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Find.Location = new System.Drawing.Point(231, 181);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(168, 22);
            this.txt_Find.TabIndex = 9;
            this.txt_Find.Visible = false;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            this.txt_Find.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Find_KeyPress);
            // 
            // ManagePeopleFrm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 451);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.btn_AddPerson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_RecordsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_People);
            this.Controls.Add(this.cbx_FiltterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ManagePeopleFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Manage People";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.ManagePeopleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_People)).EndInit();
            this.conMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_FiltterBy;
        private System.Windows.Forms.DataGridView dgv_People;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_RecordsNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_AddPerson;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem show_Details;
        private System.Windows.Forms.ToolStripMenuItem AddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Send_Email;
        private System.Windows.Forms.ToolStripMenuItem PhoneCall;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txt_Find;
    }
}