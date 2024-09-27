namespace DVLD.Forms
{
    partial class ManageUsersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersFrm));
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.lbl_RecordsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.conMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.show_Details = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Send_Email = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_FiltterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.cb_IsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.conMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Find
            // 
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Find.Location = new System.Drawing.Point(257, 195);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(168, 22);
            this.txt_Find.TabIndex = 19;
            this.txt_Find.Visible = false;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            this.txt_Find.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Find_KeyPress);
            // 
            // lbl_RecordsNum
            // 
            this.lbl_RecordsNum.AutoSize = true;
            this.lbl_RecordsNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecordsNum.Location = new System.Drawing.Point(130, 440);
            this.lbl_RecordsNum.Name = "lbl_RecordsNum";
            this.lbl_RecordsNum.Size = new System.Drawing.Size(19, 16);
            this.lbl_RecordsNum.TabIndex = 16;
            this.lbl_RecordsNum.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "# Records :";
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            this.dgv_Users.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.ContextMenuStrip = this.conMenu;
            this.dgv_Users.Location = new System.Drawing.Point(23, 223);
            this.dgv_Users.MultiSelect = false;
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.ReadOnly = true;
            this.dgv_Users.Size = new System.Drawing.Size(644, 200);
            this.dgv_Users.TabIndex = 14;
            // 
            // conMenu
            // 
            this.conMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_Details,
            this.toolStripSeparator1,
            this.AddNewPerson,
            this.Edit,
            this.Delete,
            this.ChangePassword,
            this.toolStripSeparator2,
            this.Send_Email,
            this.PhoneCall});
            this.conMenu.Name = "conMenu";
            this.conMenu.Size = new System.Drawing.Size(185, 282);
            // 
            // show_Details
            // 
            this.show_Details.Image = ((System.Drawing.Image)(resources.GetObject("show_Details.Image")));
            this.show_Details.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.show_Details.Name = "show_Details";
            this.show_Details.Size = new System.Drawing.Size(184, 38);
            this.show_Details.Text = "Show Details";
            this.show_Details.Click += new System.EventHandler(this.show_Details_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // AddNewPerson
            // 
            this.AddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("AddNewPerson.Image")));
            this.AddNewPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewPerson.Name = "AddNewPerson";
            this.AddNewPerson.Size = new System.Drawing.Size(184, 38);
            this.AddNewPerson.Text = "Add New User";
            this.AddNewPerson.Click += new System.EventHandler(this.AddNewPerson_Click);
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(184, 38);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(184, 38);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("ChangePassword.Image")));
            this.ChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(184, 38);
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // Send_Email
            // 
            this.Send_Email.Image = ((System.Drawing.Image)(resources.GetObject("Send_Email.Image")));
            this.Send_Email.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Send_Email.Name = "Send_Email";
            this.Send_Email.Size = new System.Drawing.Size(184, 38);
            this.Send_Email.Text = "Send Email";
            this.Send_Email.Click += new System.EventHandler(this.Send_Email_Click);
            // 
            // PhoneCall
            // 
            this.PhoneCall.Image = ((System.Drawing.Image)(resources.GetObject("PhoneCall.Image")));
            this.PhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PhoneCall.Name = "PhoneCall";
            this.PhoneCall.Size = new System.Drawing.Size(184, 38);
            this.PhoneCall.Text = "Phone Call";
            this.PhoneCall.Click += new System.EventHandler(this.PhoneCall_Click);
            // 
            // cbx_FiltterBy
            // 
            this.cbx_FiltterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_FiltterBy.FormattingEnabled = true;
            this.cbx_FiltterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Username",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.cbx_FiltterBy.Location = new System.Drawing.Point(124, 193);
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
            this.label2.Location = new System.Drawing.Point(38, 197);
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
            this.label1.Location = new System.Drawing.Point(258, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Users";
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddUser.Image")));
            this.btn_AddUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_AddUser.Location = new System.Drawing.Point(624, 180);
            this.btn_AddUser.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(42, 37);
            this.btn_AddUser.TabIndex = 18;
            this.btn_AddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(570, 440);
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
            this.picBox.Location = new System.Drawing.Point(248, 21);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(177, 129);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 10;
            this.picBox.TabStop = false;
            // 
            // cb_IsActive
            // 
            this.cb_IsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cb_IsActive.FormattingEnabled = true;
            this.cb_IsActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not Active"});
            this.cb_IsActive.Location = new System.Drawing.Point(258, 194);
            this.cb_IsActive.Name = "cb_IsActive";
            this.cb_IsActive.Size = new System.Drawing.Size(121, 24);
            this.cb_IsActive.TabIndex = 20;
            this.cb_IsActive.Visible = false;
            this.cb_IsActive.SelectedIndexChanged += new System.EventHandler(this.cb_IsActive_SelectedIndexChanged);
            // 
            // ManageUsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 489);
            this.Controls.Add(this.cb_IsActive);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_RecordsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Users);
            this.Controls.Add(this.cbx_FiltterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageUsersFrm";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.conMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_RecordsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.ComboBox cbx_FiltterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.ContextMenuStrip conMenu;
        private System.Windows.Forms.ToolStripMenuItem show_Details;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Send_Email;
        private System.Windows.Forms.ToolStripMenuItem PhoneCall;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword;
        private System.Windows.Forms.ComboBox cb_IsActive;
    }
}