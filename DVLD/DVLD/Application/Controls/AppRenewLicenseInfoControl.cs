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
    public partial class AppRenewLicenseInfoControl : UserControl
    {
        public AppRenewLicenseInfoControl()
        {
            InitializeComponent();
            FillForm();
        }
        void FillForm()
        {
            lbl_ApplicationDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbl_IssueDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbl_ApplicationFees.Text = clsApplicationTypes.GetApplicationFees(2).ToString("0.00");
            lbl_CreatedBy.Text = clsUser.GetUsernameByID(MainForm.UserID);
        }
        public void UpdateOldLicense(int LicenseID)
        {
            clsLicense License = clsLicense.Find(LicenseID);
            lbl_OldLicenseID.Text = LicenseID.ToString();
            lbl_ExpirationDate.Text = DateTime.Now.AddYears(License.DefaultValidityLength).ToString("dd MMM yyyy");
            lbl_LicenseFees.Text = License.ClassFees.ToString("0.00");
            lbl_TotalFees.Text = (License.ClassFees + clsApplicationTypes.GetApplicationFees(2)).ToString();
        }
        public void UpdateRenewedLicense(int LRApplicationID, int RenewedLicenseID)
        {
            lbl_LRApplicationID.Text = LRApplicationID.ToString();
            lbl_RenewedLicenseID.Text = RenewedLicenseID.ToString();
        }
    }
}
