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
    public partial class DetainLicenseFrm : Form
    {
        public DetainLicenseFrm()
        {
            InitializeComponent();
            detainInfo.FillFormData(LicenseID, clsUser.GetUsernameByID(MainForm.UserID));
        }

        int LicenseID = -1;

        decimal DetainFee = -1;
        private void detainInfo_onTextChange(TextBox txt_Fee)
        {
            if (decimal.TryParse(txt_Fee.Text, out decimal fee))
                DetainFee = fee;

            if (txt_Fee.Text == "")
                btn_Save.Enabled = false;
            else
                btn_Save.Enabled = true;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            clsDetainedLicenses dl = clsDetainedLicenses.DetaineLicense(LicenseID, DetainFee, MainForm.UserID);
            if (dl != null)
            {
                detainInfo.UpdateDetainID(dl.DetainID);
                MessageBox.Show("License Detained Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
                MessageBox.Show(clsDetainedLicenses.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void licenseFilterControl1_Find(TextBox txt_Find)
        {
            if(int.TryParse(txt_Find.Text, out int LicenseID))
                LicenseInfo.FindLicense(LicenseID);
        }
        private void LicenseInfo_onLicenseFound(int LicenseID)
        {
            this.LicenseID = LicenseID;
            detainInfo.FillFormData(LicenseID, clsUser.GetUsernameByID(MainForm.UserID));
        }
    }
}
