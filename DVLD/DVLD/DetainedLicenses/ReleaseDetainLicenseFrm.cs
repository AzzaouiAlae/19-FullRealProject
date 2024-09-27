using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD.Forms.License
{
    public partial class ReleaseDetainLicenseFrm : Form
    {
        public ReleaseDetainLicenseFrm()
        {
            InitializeComponent();
        }
        public ReleaseDetainLicenseFrm(int LicenceID)
        {
            InitializeComponent();
            FillForm(LicenceID);
        }
        void FillForm(int LicenceID)
        {
            licenseFilter.txt_Find.Text = LicenceID.ToString();
            licenseFilterControl1_Find(licenseFilter.txt_Find);
            licenseFilter.Enabled = false;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void licenseFilterControl1_Find(TextBox txt_Find)
        {
            if(int.TryParse(txt_Find.Text, out int LicenseID))            
                LicenseInfo.FindLicense(LicenseID);            
        }
        private void LicenseInfo_onLicenseFound(int LicenseID)
        {
            DetaineID = clsDetainedLicenses.FindDetaineID(LicenseID);
            if (DetaineID != 0)
            {
                releaseDetainLicense.FindDetainInfo(DetaineID);
                btn_Release.Enabled = true;
                this.LicenseID = LicenseID;
            }
            else
            {
                releaseDetainLicense.ResetDetainInfo();
                btn_Release.Enabled = false;
                MessageBox.Show("This License is not detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LicenseID = -1;
            }
        }

        int LicenseID = -1;

        int DetaineID = -1;
        private void btn_Release_Click(object sender, EventArgs e)
        {
            clsApplications ReleaseApp = clsApplications.NewReleaseDetainedLicsense(LicenseID, MainForm.UserID, DetaineID);
            if (ReleaseApp != null)
            {
                releaseDetainLicense.UpdateAppID(ReleaseApp.ApplicationID);
                MessageBox.Show("The License released Successfully", "released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LisenseReleased(ReleaseApp.ApplicationID);
                btn_Release.Enabled = false;
            }
            else
                MessageBox.Show(clsApplications.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public event Action<int> onLisenseReleased;
        virtual protected void LisenseReleased(int ReleaseAppID)
        {
            Action<int> Handler = onLisenseReleased;
            if (Handler != null)
                Handler(ReleaseAppID);
        }
    }
}
