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
    public partial class ReleaseDetainLicenseControl : UserControl
    {
        public ReleaseDetainLicenseControl()
        {
            InitializeComponent();
        }
        public void FindDetainInfo(int DetainID)
        {
            clsDetainedLicenses d = clsDetainedLicenses.Find(DetainID);
            if (d != null)
            {
                lbl_DetainID.Text = d.DetainID.ToString();
                lbl_DetainDate.Text = d.DetainDate.ToString("dd MMM yyyy");
                decimal AppFee = clsApplicationTypes.GetApplicationFees(5);
                lbl_ApplicationFees.Text = AppFee.ToString("0.00");
                // 5 = Release Detained Driving Licsense Application Types                
                lbl_TotalFees.Text = (d.FineFees + AppFee).ToString("0.00");
                lbl_LicenseID.Text = d.LicenseID.ToString();
                lbl_CreatedBy.Text = clsUser.GetUsernameByID(d.CreatedByUserID);
                lbl_FineFees.Text = d.FineFees.ToString("0.00");
                //lbl_ApplicationID.Text = d.ReleaseApplicationID.ToString(); 
            }
        }
        public void ResetDetainInfo()
        {
            lbl_DetainID.Text = "...";
            lbl_DetainDate.Text = "...";
            lbl_ApplicationFees.Text = "...";              
            lbl_TotalFees.Text = "...";
            lbl_LicenseID.Text = "...";
            lbl_CreatedBy.Text = "...";
            lbl_FineFees.Text = "...";
            lbl_ApplicationID.Text = "...";
        }
        public void UpdateAppID(int AppID)
        {
            lbl_ApplicationID.Text = AppID.ToString();
        }
    }
}
