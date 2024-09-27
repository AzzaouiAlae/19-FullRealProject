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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Forms.License
{
    public partial class IssueLicenseFirstTimeFrm : Form
    {
        public IssueLicenseFirstTimeFrm(int LDLAppID)
        {
            InitializeComponent();
            FillForm(LDLAppID);
            this.LDLAppID = LDLAppID;
        }

        int AppID;

        int LDLAppID;
        void FillForm(int LDLAppID)
        {
            licenseAppInfo.FindLocalLicense(LDLAppID);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool SetDriverData()
        {
            return true;
        }
        bool SetLicenseData()
        {
            return true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            clsLicense License = clsLicense.IssueNewLicense(AppID, MainForm.UserID, LDLAppID, txt_Note.Text);
            if(License != null )
            {
                FillForm(LDLAppID);
                MessageBox.Show($"The new License ID is {License.LicenseID}", "new License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Save.Enabled = false;
            }
            
            else
                MessageBox.Show(clsLicense.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void licenseAppInfo_OnFormFill(int appID)
        {
            appBasicInfo.FillAppForm(appID);
            AppID = appID;
        }
    }
}
