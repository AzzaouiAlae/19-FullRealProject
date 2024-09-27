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

namespace DVLD.Controls.License
{
    public partial class InternationalAppInfoControl : UserControl
    {
        public InternationalAppInfoControl()
        {
            InitializeComponent();
            FillForm();
        }
        void FillForm()
        {
            lbl_ApplicationDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbl_IssueDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbl_CreatedBy.Text = clsUser.GetUsernameByID(MainForm.UserID);
            lbl_ExpirationDate.Text = DateTime.Now.AddYears(10).ToString("dd MMM yyyy");
            lbl_Fees.Text = clsApplicationTypes.GetApplicationFees(6).ToString("00.00");
        }
        public void UpdateLocalLicenseID(int LicenseID)
        {
            lbl_LocalLicenseID.Text = LicenseID.ToString();
        }
        public void UpdateAppLicenseID(int ILApplicationID, int ILicenseID)
        {
            lbl_ILApplicationID.Text = ILApplicationID.ToString();
            lbl_ILicenseID.Text = ILicenseID.ToString();
        }
    }
}
