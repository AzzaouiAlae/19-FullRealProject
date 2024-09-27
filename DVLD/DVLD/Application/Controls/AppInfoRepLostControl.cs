using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Controls.License
{
    public partial class AppInfoRepLostControl : UserControl
    {
        enum enRepFor { enDamagedLicense, enLostLicense}
        public AppInfoRepLostControl()
        {
            InitializeComponent();
            FillForm();
        }

        public void FillForm(int ReplacementFor = (int)enRepFor.enDamagedLicense)
        {
            //lbl_LRApplicationID.Text
            //lbl_ReplacedLicenseID
            //lbl_OldLicenseID
            lbl_ApplicationDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            decimal fee = ReplacementFor == (int)enRepFor.enDamagedLicense ? clsApplicationTypes.GetApplicationFees(4) : clsApplicationTypes.GetApplicationFees(3);
            lbl_ApplicationFees.Text = fee.ToString("0.00");
            lbl_CreatedBy.Text = clsUser.GetUsernameByID(MainForm.UserID);
        }
        public void Update(int LRAppID, int ReplacedLicenseID)
        {
            lbl_LRApplicationID.Text = LRAppID.ToString();
            lbl_ReplacedLicenseID.Text = ReplacedLicenseID.ToString();
        }
        public void Updatefee(int ReplacementFor)
        {
            decimal fee = ReplacementFor == (int)enRepFor.enDamagedLicense ? clsApplicationTypes.GetApplicationFees(4) : clsApplicationTypes.GetApplicationFees(3);
            lbl_ApplicationFees.Text = fee.ToString("0.00");
        }
        public void UpdateOldLicenseID(int OldLicenseID)
        {
            lbl_OldLicenseID.Text = OldLicenseID.ToString();
        }
    }
}
