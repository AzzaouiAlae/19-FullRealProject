using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Forms.License;
using DVLD_Business;

namespace DVLD.Controls
{
    public partial class LicenseAppInfoControl : UserControl
    {
        public LicenseAppInfoControl()
        {
            InitializeComponent();
        }
        public void FindLocalLicense(int ID)
        {
            clsLocalLicenseApp LicenseApp = clsLocalLicenseApp.Find(ID);
            if(LicenseApp != null)
            {
                LicenseID = clsLicense.FindIDByAppID(LicenseApp.ApplicationID);
                if(LicenseID != -1)
                    lbl_ShowLicenseInfo.Enabled = true;

                lbl_DLAppID.Text = LicenseApp.LocalLicenseID.ToString();
                lbl_LicenseClassName.Text = clsLicenseClasses.LicenseClassesName(LicenseApp.LicenseClassID);
                lbl_PassedTests.Text = $"{clsTest.PassTests(LicenseApp.LocalLicenseID)}/3";
                FormFill(LicenseApp.ApplicationID);
            }
        }

        int LicenseID = -1;

        public event Action<int> OnFormFill;
        protected virtual void FormFill(int appID)
        {
            Action<int> Handler = OnFormFill;
            if (Handler != null)
            {
                Handler(appID);
            }
        }
        private void lbl_ShowLicenseInfo_Click(object sender, EventArgs e)
        {
            DriverLicenseInfoFrm Frm = new DriverLicenseInfoFrm(LicenseID);
            Frm.Show();
        }
    }
}