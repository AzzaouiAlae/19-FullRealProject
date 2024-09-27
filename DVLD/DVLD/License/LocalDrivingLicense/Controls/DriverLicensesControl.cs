using DVLD.Forms.License;
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
    public partial class DriverLicensesControl : UserControl
    {
        public DriverLicensesControl()
        {
            InitializeComponent();
        }

        DataTable DT;

        DataTable DT_International;
        public void FillData(int PersonID)
        {
            DT = clsLocalLicenseApp.FindLocalLicenseByPersonID(PersonID);
            if (DT != null) 
            {
                dgv_LocalLicense.DataSource = DT;
                lbl_LocalRecordsNum.Text = dgv_LocalLicense.RowCount.ToString();
            }
            DT_International = clsInternationalLicense.FindInterLicensesByPersonID(PersonID);
            if (DT_International != null)
            {
                dgv_InternationalLicense.DataSource = DT_International;
                lbl_InternationalRecordsNum.Text = dgv_InternationalLicense.RowCount.ToString();
            }
        }
        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex == 0)
            {
                if (dgv_LocalLicense.CurrentRow != null)
                {
                    if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int LicenseID))
                    {
                        DriverLicenseInfoFrm Frm = new DriverLicenseInfoFrm(LicenseID);
                        Frm.Show();
                    }
                }
            }
            else
            {
                if (dgv_InternationalLicense.CurrentRow != null)
                {
                    if (int.TryParse(dgv_InternationalLicense.CurrentRow.Cells[0].Value.ToString(), out int iLicenseID))
                    {
                        DriverLicenseInfoFrm Frm = new DriverLicenseInfoFrm(-1, iLicenseID);
                        Frm.Show();
                    }
                }
            }
            
        }
    }
}
