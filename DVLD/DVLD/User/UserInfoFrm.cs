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

namespace DVLD.Forms
{
    public partial class UserInfoFrm : Form
    {
        public UserInfoFrm(int ID)
        {
            InitializeComponent();
            userInfo.FindUser(ID);
        }        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
