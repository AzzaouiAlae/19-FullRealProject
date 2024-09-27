using System;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD.Forms
{
    public partial class ChangePasswordFrm : Form
    {
        public ChangePasswordFrm(int UserID)
        {
            InitializeComponent();
            FindUser(UserID);
        }
        void FindUser(int UserID)
        {      
            if(!userInfo.FindUser(UserID))
                MessageBox.Show(clsUser.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
                this.UserID = UserID;
        }

        int UserID = -1;
        bool CheckForm()
        {
            bool Result = true;
            if(txt_CurrentPassword.Text == "")
            {
                MessageBox.Show("The Current Password is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                eP.SetError(txt_CurrentPassword, "The Current Password is empty");
                Result = false;
            }
            else if (!clsUser.isPasswordCorrect(UserID, txt_CurrentPassword.Text))
            {                
                MessageBox.Show("Current password is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Result = false;
                eP.SetError(txt_CurrentPassword, "Current password is invalid");
            }

            if (txt_NewPassword.Text == "")
            {
                if (Result)
                    MessageBox.Show("The New password is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Result = false;
                eP.SetError(txt_NewPassword, "The New password is empty");
            }
            if(txt_ConfirmPassword.Text != txt_NewPassword.Text)
            {
                if(Result)
                    MessageBox.Show("Invalid confirm password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Result = false;
                eP.SetError(txt_ConfirmPassword, "Invalid confirm password");
            }            
            return Result;
        }        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
                return;

            if(clsUser.ChangePassword(UserID, txt_NewPassword.Text, txt_CurrentPassword.Text))
                MessageBox.Show("Password saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);       
            else
                MessageBox.Show(clsUser.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txt_CurrentPassword_TextChanged(object sender, EventArgs e)
        {
            eP.SetError(txt_CurrentPassword, null);
        }
        private void txt_CurrentPassword_Leave(object sender, EventArgs e)
        {
            if (txt_CurrentPassword.Text == "")                            
                eP.SetError(txt_CurrentPassword, "The Current Password is empty");
            
            else if (!clsUser.isPasswordCorrect(UserID, txt_CurrentPassword.Text))           
                eP.SetError(txt_CurrentPassword, "Current password is invalid");            
        }
        private void txt_NewPassword_Leave(object sender, EventArgs e)
        {
            if (txt_NewPassword.Text == "")            
                eP.SetError(txt_NewPassword, "The New password is empty");            
        }
        private void txt_NewPassword_TextChanged(object sender, EventArgs e)
        {
            eP.SetError(txt_NewPassword, null);
        }
        private void txt_ConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txt_ConfirmPassword.Text != txt_NewPassword.Text)            
                eP.SetError(txt_ConfirmPassword, "Invalid confirm password");            
        }
        private void txt_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            eP.SetError(txt_ConfirmPassword, null);
        }
    }
}
