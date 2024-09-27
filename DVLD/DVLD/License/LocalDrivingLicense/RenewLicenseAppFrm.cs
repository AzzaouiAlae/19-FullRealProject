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

namespace DVLD.Forms.License
{
    public partial class RenewLicenseAppFrm : Form
    {
        public RenewLicenseAppFrm()
        {
            InitializeComponent();
        }

        int OldLicenseID = -1;        
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
            appRenewLicenseInfo.UpdateOldLicense(LicenseID);
            btn_Save.Enabled = true;
            OldLicenseID = LicenseID;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            clsLicense license = clsLicense.RenewLicense(OldLicenseID, MainForm.UserID, appRenewLicenseInfo.txt_Notes.Text);
            if(license != null)
            {
                MessageBox.Show($"Renew License successfully ID = {license.LicenseID}", "Renew License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                appRenewLicenseInfo.UpdateRenewedLicense(license.AppID, license.LicenseID);
            }
            else
                MessageBox.Show(clsLicense.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
