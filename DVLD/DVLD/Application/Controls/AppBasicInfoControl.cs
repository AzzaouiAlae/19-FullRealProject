using DVLD.Forms;
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
    public partial class AppBasicInfoControl : UserControl
    {
        public AppBasicInfoControl()
        {
            InitializeComponent();
        }
        public void FillAppForm(int AppID)
        {
            clsApplications App = clsApplications.Find(AppID);
            if(App == null) 
            {
                MessageBox.Show(clsApplications.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbl_ID.Text = AppID.ToString();
            switch(App.ApplicationStatus)
            {
                case 1:
                    lbl_Status.Text = "New";
                    break;
                case 2:
                    lbl_Status.Text = "Canceled";
                    break;
                case 3:
                    lbl_Status.Text = "Complet";
                    break;
            }
            txt_Fees.Text = App.ApplicationFees.ToString("0.00");
            lbl_Type.Text = App.ApplicationTypeTitle;
            lbl_Name.Text = clsPerson.GetFullNameByID(App.PersonID);
            lbl_Date.Text = App.ApplicationDate.ToString("dd MMM yyyy");
            lbl_StatusDate.Text = App.LastStatusDate.ToString("dd MMM yyyy");
            lbl_CreatedBy.Text = clsUser.GetUsernameByID(App.CreatedByUserID);
            PersonID = App.PersonID;
            lbl_PersonInfo.Enabled = true;
        }

        int PersonID = -1;
        private void lbl_PersonInfo_Click(object sender, EventArgs e)
        {
            PersonInfoFrm PersonInfo = new PersonInfoFrm(PersonID);
            PersonInfo.Show();
        }
    }
}
