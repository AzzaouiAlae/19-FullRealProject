using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD.Forms
{
    public partial class AddEditUserFrm : Form
    {
        public AddEditUserFrm()
        {
            InitializeComponent();
        }
        public AddEditUserFrm(int ID)
        {
            InitializeComponent();
            _FillFrm(ID);
        }
        void _FillFrm(int ID)
        {
            lbl_Title.Text = "Update New User";
            User = clsUser.FindByID(ID);
            if(User != null)
            {
                FindPerson.FindPersen(User.PersonID);
                FindPerson.personFillter1.Enabled = false;
                lbl_UserID.Text = User.PersonID.ToString();
                txt_Username.Text = User.UserName;
                txt_Password.Text = User.Password;
                txt_ConfirmPassword.Text = User.Password;
                cbx_isActive.Checked = User.IsActive;
            }
        }

        int PersonID = -1;

        clsUser User;
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(isPersonUser)
                MessageBox.Show("This person has user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                tabControl1.SelectTab(1);
        }       
        bool _CheckFormData()
        {
            bool Result = true;
            if (txt_Username.Text == "")
            {
                ep.SetError(txt_Username, "The Username is Required");
                if(Result)
                {
                    MessageBox.Show("The Username is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Result = false;
                }
            }
            if (clsUser.isUserNameExist(txt_Username.Text))
            {
                ep.SetError(txt_Username, "The Username is not valid");

                if (Result)
                {
                    MessageBox.Show("The Username is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Result = false;
                }
            }
            if (txt_Password.Text == "")
            {
                ep.SetError(txt_Password, "The Password is Required");
                if (Result)
                {
                    MessageBox.Show("The Username is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Result = false;
                }
            }
            if (txt_ConfirmPassword.Text == "")
            {
                ep.SetError(txt_Password, "The Confirm Password is Required");
                if (Result)
                {
                    MessageBox.Show("The Confirm Password is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Result = false;
                }
            }
            if (txt_ConfirmPassword.Text == "")
            {
                ep.SetError(txt_Password, "The Password is not Confirm");
                if (Result)
                {
                    MessageBox.Show("The Password is not Confirm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Result = false;
                }
        }
            return Result;
        }
        void _SetUserData()
        {
            User.UserName = txt_Username.Text;
            User.Password = txt_Password.Text;
            User.IsActive = cbx_isActive.Checked;
            User.PersonID = PersonID;
        }
        void _SaveUserData()
        {          
            if(User.Save())
            {
                lbl_UserID.Text = User.UserID.ToString();
                lbl_Title.Text = "Update New User";
                MessageBox.Show("User saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(clsUser.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!_CheckFormData()) return;

            if (User == null)
                User = new clsUser();

            _SetUserData();
            _SaveUserData();
        }
        private void FindPerson_onPersonSelected(int PersonID)
        {
            if (User != null && PersonID == User.PersonID)
            {
                this.PersonID = PersonID;
                isPersonUser = false;
            }
            else if (!clsUser.isPersonHasUser(PersonID))
            {
                this.PersonID = PersonID;
                isPersonUser = false;
            }
            else
            {
                MessageBox.Show("This person has user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isPersonUser = true;
            }            
        }

        bool isPersonUser = false;

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
                ep.SetError(txt_Username, "The Username is Required");

            else if (clsUser.isUserNameExist(txt_Username.Text))
                ep.SetError(txt_Username, "The Username is not valid");
            else
                ep.Clear();
        }
        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
                ep.SetError(txt_Password, "The Password is Required");
            else
                ep.Clear();
        }

        private void txt_ConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txt_ConfirmPassword.Text == "")
                ep.SetError(txt_ConfirmPassword, "The Confirm Password is Required");

            else if (txt_ConfirmPassword.Text != txt_Password.Text)
                ep.SetError(txt_ConfirmPassword, "The Password is not Confirm");
            else
                ep.Clear();
        }
    }
}
