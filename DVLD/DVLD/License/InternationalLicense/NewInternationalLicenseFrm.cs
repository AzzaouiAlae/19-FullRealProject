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
    public partial class NewInternationalLicenseFrm : Form
    {
        public NewInternationalLicenseFrm()
        {
            InitializeComponent();
        }
        public NewInternationalLicenseFrm(int PersonID)
        {
            InitializeComponent();
            FindDriverLicense(PersonID);
        }
        void FindDriverLicense(int PersonID)
        {
            int LicenseID = clsLicense.FindLicenseIDForIssueNewInteLicense(PersonID);
            if (LicenseID != -1)
            {
                licenseFilterControl1.txt_Find.Text = LicenseID.ToString();
                driverLicenseInfo.FindLicense(LicenseID);
                lbl_ShowLicensesHistory.Enabled = true;
                this.LicenseID = LicenseID;
            }
            else
                MessageBox.Show(clsLicense.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
        }
        private void licenseFilterControl1_Find(TextBox txt_Find)
        {
            if (int.TryParse(txt_Find.Text, out int LicenseID))
            {
                driverLicenseInfo.FindLicense(LicenseID);
                lbl_ShowLicensesHistory.Enabled = true;
            }
        }
        private void driverLicenseInfo_onLicenseFound(int LicenseID)
        {
            internationalAppInfo.UpdateLocalLicenseID(LicenseID);
            this.LicenseID = LicenseID;
            btn_Save.Enabled = true;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        int LicenseID = -1;

        int iLicenseID = -1;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            clsInternationalLicense iLicense = clsInternationalLicense.IssueInternationalLicense(MainForm.UserID, LicenseID);
            if(iLicense != null)
            {
                MessageBox.Show($"International License Issued successefully ID = {iLicense.InternationalLicenseID}", "Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Save.Enabled =false;
                internationalAppInfo.UpdateAppLicenseID(iLicense.ApplicationID, iLicense.InternationalLicenseID);
                iLicenseID = iLicense.InternationalLicenseID;
                lbl_ShowNewLicensesInfo.Enabled = true;
            }
            else
                MessageBox.Show(clsInternationalLicense.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void lbl_ShowLicensesHistory_Click(object sender, EventArgs e)
        {
            if (LicenseID != -1)
            {
                LicenseHistoryFrm Frm = new LicenseHistoryFrm(-1, LicenseID);
                Frm.MdiParent = MdiParent;
                Frm.Show();
            }
        }
        private void lbl_ShowNewLicensesInfo_Click(object sender, EventArgs e)
        {
            DriverLicenseInfoFrm Frm = new DriverLicenseInfoFrm(-1, iLicenseID);
            Frm.Show();
        }
    }
}
