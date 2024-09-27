using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls
{
    public partial class UserInfoControl : UserControl
    {
        public UserInfoControl()
        {
            InitializeComponent();
        }
        void FillUserCard(clsUser User)
        {
            personInfo.FindPerson(User.PersonID);
            lbl_UserID.Text = User.UserID.ToString();
            lbl_Username.Text = User.UserName.ToString();
            lbl_IsActive.Text = User.IsActive ? "Yes" : "No";
        }
        public bool FindUser(int UserID)
        {
            clsUser u = clsUser.FindByID(UserID);
            if(u != null)
            {
                FillUserCard(u);
                return true;
            }
            return false;
        }
    }
}
