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
    public partial class RepLostLicenseFrm : Form
    {
        enum enRepFor { enDamagedLicense, enLostLicense }
        public RepLostLicenseFrm()
        {
            InitializeComponent();
        }

        int OldLicenseID = -1;

        int LicenseID = -1;

        private void licenseFilter_Find(TextBox txt_Find)
        {
            if(int.TryParse(txt_Find.Text, out int LicenseID))
                LicenseInfo.FindLicense(LicenseID);
        }
        private void rb_Damaged_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_Damaged.Checked)
                appInfoRepLost.Updatefee((int)enRepFor.enDamagedLicense);

            else
                appInfoRepLost.Updatefee((int)enRepFor.enLostLicense);
        }
        private void lbl_ShowLicensesHistory_Click(object sender, EventArgs e)
        {
            if(OldLicenseID != -1)
            {
                LicenseHistoryFrm Frm = new LicenseHistoryFrm(-1, OldLicenseID);
                Frm.MdiParent = MdiParent;
                Frm.Show();
            }
        }        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            /// 4 = Damaged and 3 = Lost
            int AppTypesID = rb_Damaged.Checked ? 4 : 3;
            clsLicense License = clsLicense.IssueReplacedLicense(OldLicenseID, AppTypesID, MainForm.UserID);
            if (License != null)
            {
                appInfoRepLost.Update(License.LRAppID, License.LicenseID);
                MessageBox.Show("License Issued successfully", "Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LicenseID = License.LicenseID;
                lbl_ShowNewLicensesInfo.Enabled = true;
                btn_Save.Enabled = false;
            }
            else
                MessageBox.Show(clsLicense.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void lbl_ShowNewLicensesInfo_Click(object sender, EventArgs e)
        {
            DriverLicenseInfoFrm Frm = new DriverLicenseInfoFrm(LicenseID);
            Frm.Show();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LicenseInfo_onLicenseFound(int OldLicenseID)
        {
            appInfoRepLost.UpdateOldLicenseID(OldLicenseID);
            btn_Save.Enabled = true;
            lbl_ShowLicensesHistory.Enabled = true;
            this.OldLicenseID = OldLicenseID;
        }
        private void rb_Lost_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Damaged.Checked)
                appInfoRepLost.Updatefee((int)enRepFor.enDamagedLicense);

            else
                appInfoRepLost.Updatefee((int)enRepFor.enLostLicense);
        }
    }
}
