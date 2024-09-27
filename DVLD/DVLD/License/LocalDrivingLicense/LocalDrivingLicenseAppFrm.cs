using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Forms.License
{
    public partial class LocalDrivingLicenseAppFrm : Form
    {
        enum enTestType { enVision = 1, enWritten = 2, enStreet = 3 }
        public LocalDrivingLicenseAppFrm()
        {
            InitializeComponent();
            _Refresh();
            cbx_FiltterBy.SelectedIndex = 0;
        }
        void _Refresh()
        {
            dt = clsLocalLicenseApp.GetAllLocalLicense();
            dgv_LocalLicense.DataSource = null;
            dgv_LocalLicense.DataSource = dt;
            lbl_RecordsNum.Text = dgv_LocalLicense.RowCount.ToString();
            //dt.Rows[3][""]
            if (dt != null)
                dv = dt.DefaultView;            
        }

        DataTable dt;

        DataView dv;
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if(int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int LDLAppID))
                {
                    LocalDrivingLicenseApplicationInfoFrm Frm = new LocalDrivingLicenseApplicationInfoFrm(LDLAppID);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                }
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[5].Value.ToString(), out int PassTests))
                {
                    showAppDetailsTSM.Enabled = true;
                    editAppTSM.Enabled = true;
                    deleteAppTSM.Enabled = true;
                    cancelAppTSM.Enabled = true;
                    sechduleTestsTSM.Enabled = true;
                    scheduleVisionTestTSM.Enabled = true;
                    scheduleWrittenTestTSM.Enabled = true;
                    scheduleStreetTestTSM.Enabled = true;
                    issueLicenseFirstTimeTSM.Enabled = true;
                    showLicenseTSM.Enabled = true;
                    showLicenseHistoryTSM.Enabled = true;

                    if(dgv_LocalLicense.CurrentRow.Cells[6].Value.ToString() == "Canceled")
                    {
                        editAppTSM.Enabled = false;
                        deleteAppTSM.Enabled = false;
                        cancelAppTSM.Enabled = false;
                        sechduleTestsTSM.Enabled = false;
                        scheduleVisionTestTSM.Enabled = false;
                        scheduleWrittenTestTSM.Enabled = false;
                        scheduleStreetTestTSM.Enabled = false;
                        issueLicenseFirstTimeTSM.Enabled = false;
                        showLicenseTSM.Enabled = false;
                    }
                    else if(dgv_LocalLicense.CurrentRow.Cells[6].Value.ToString() == "Complet")
                    {
                        sechduleTestsTSM.Enabled = false;

                        int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out PassTests);
                        int LicenceID = clsLicense.FindIDByLDLAppID(PassTests);
                        if (LicenceID != -1)
                        {
                            issueLicenseFirstTimeTSM.Enabled = false;
                            cancelAppTSM.Enabled = false;
                            editAppTSM.Enabled = false;
                            deleteAppTSM.Enabled = false;
                        }
                        else
                        {
                            showLicenseTSM.Enabled = false;
                        }
                    }
                    else if (PassTests == 0)
                    {
                        scheduleWrittenTestTSM.Enabled = false;
                        scheduleStreetTestTSM.Enabled = false;
                        issueLicenseFirstTimeTSM.Enabled = false;
                        showLicenseTSM.Enabled = false;
                    }
                    else if(PassTests == 1)
                    {
                        scheduleVisionTestTSM.Enabled = false;
                        scheduleStreetTestTSM.Enabled = false;
                        issueLicenseFirstTimeTSM.Enabled = false;
                        showLicenseTSM.Enabled = false;
                    }
                    else if (PassTests == 2)
                    {
                        scheduleVisionTestTSM.Enabled = false;
                        scheduleWrittenTestTSM.Enabled = false;
                        issueLicenseFirstTimeTSM.Enabled = false;
                        showLicenseTSM.Enabled = false;
                    }
                    else if (PassTests == 3)
                    {
                        sechduleTestsTSM.Enabled = false;

                        int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out PassTests);
                        int LicenceID = clsLicense.FindIDByLDLAppID(PassTests);
                        if (LicenceID != -1)
                        {
                            issueLicenseFirstTimeTSM.Enabled = false;
                            cancelAppTSM.Enabled = false;
                            editAppTSM.Enabled = false;
                            deleteAppTSM.Enabled = false;
                        }
                        else
                        {
                            showLicenseTSM.Enabled = false;
                        }
                    }
                    else
                    {
                        issueLicenseFirstTimeTSM.Enabled = false;
                        showLicenseTSM.Enabled = false;
                    }
                }
                else
                {
                    issueLicenseFirstTimeTSM.Enabled = false;
                    showLicenseTSM.Enabled = false;
                }
            }
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int LDLAppID))
                {
                    LicenseHistoryFrm Frm = new LicenseHistoryFrm(LDLAppID);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                }
            }
        }
        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int LDLAppID))
                {
                    TestAppointmentsFrm Frm = new TestAppointmentsFrm(LDLAppID, 1);
                    Frm.FormClosed += Frm_FormClosed;
                    Frm.ShowDialog();                    
                }
            }
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt = clsLocalLicenseApp.GetAllLocalLicense();
            if (dt == null)
                MessageBox.Show(clsLocalLicenseApp.Log);
            else
            {
                dgv_LocalLicense.DataSource = null;
                dgv_LocalLicense.DataSource = dt;
                lbl_RecordsNum.Text = dt.Rows.Count.ToString();
            }
        }
        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int LDLAppID))
                {
                    TestAppointmentsFrm Frm = new TestAppointmentsFrm(LDLAppID, 2);
                    Frm.FormClosed += Frm_FormClosed;
                    Frm.ShowDialog();
                }
            }
        }
        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int LDLAppID))
                {
                    TestAppointmentsFrm Frm = new TestAppointmentsFrm(LDLAppID, 3);
                    Frm.FormClosed += Frm_FormClosed;
                    Frm.ShowDialog();
                }
            }
        }
        private void issueLicenseFirstTimeTSM_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int LDLAppID))
                {
                    IssueLicenseFirstTimeFrm Frm = new IssueLicenseFirstTimeFrm(LDLAppID);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                    Frm.FormClosed += Frm_FormClosed;
                }
            }
        }
        private void showLicenseTSM_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int ID))
                {
                    int LicenceID = clsLicense.FindIDByLDLAppID(ID);
                    DriverLicenseInfoFrm Frm = new DriverLicenseInfoFrm(LicenceID);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                }
            }
        }
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        void FindByID()
        {
            if (int.TryParse(txt_Find.Text, out int ID))
                dv.RowFilter = $"[L.D.L.AppID] = {ID}";

            else
                dv.RowFilter = "";
        }
        void Find(string str)
        {
            if (txt_Find.Text != "")
                dv.RowFilter = $"[{str}] LIKE '{txt_Find.Text}%'";

            else
                dv.RowFilter = "";
        }
        void Search()
        {
            if (dt == null) return;

            switch (cbx_FiltterBy.Text)
            {
                case "L.D.L.AppID":
                    FindByID();
                    break;
                case "ClassName":
                    Find("ClassName");
                    break;
                case "NationalNo":
                    Find("NationalNo");
                    break;
                case "Full Name":
                    Find("Full Name");
                    break;
                case "ApplicationDate":
                    Find("ApplicationDate");
                    break;
                case "PassTests":
                    Find("PassTests");
                    break;
                case "Status":
                    Find("Status");
                    break;                
            }
        }
        private void cbx_FiltterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_FiltterBy.SelectedIndex == 0)
            {
                txt_Find.Visible = false;
                dv.RowFilter = "";
            }
            else
            {
                txt_Find.Visible = true;
                Search();
            }
        }
        void DeleteApp(int ID)
        {
            if (MessageBox.Show("Are you sure you want to delet this Application?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;

            if (clsLocalLicenseApp.Delete(ID))
            {
                MessageBox.Show("Application Deleted Successufully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Refresh();
            }
            else
                MessageBox.Show(clsLocalLicenseApp.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void deleteAppTSM_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow == null) return;

            if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int ID))
            {
                DeleteApp(ID);
            }
        }
        void CancelApp(int ID)
        {
            if (MessageBox.Show("Are you sure you want to Cancel this Application?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;

            if (clsLocalLicenseApp.CancelApp(ID))
            {
                MessageBox.Show("Application Canceled Successufully", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Refresh();
            }
            else
                MessageBox.Show(clsLocalLicenseApp.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cancelAppTSM_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow == null) return;

            if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int LocalLicenseAppID))
            {
                CancelApp(LocalLicenseAppID);
            }
        }
        private void editAppTSM_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow == null) return;

            if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int LocalLicenseAppID))
            {
                NewDrivingLicenseFrm Frm = new NewDrivingLicenseFrm(MainForm.UserID, LocalLicenseAppID);
                Frm.MdiParent = MdiParent;
                Frm.Show();
            }
        }
        private void btn_AddLDLApp_Click(object sender, EventArgs e)
        {
            NewDrivingLicenseFrm Frm = new NewDrivingLicenseFrm(MainForm.UserID);
            Frm.MdiParent = MdiParent;
            Frm.Saved = () => _Refresh();
            Frm.Show();
        }
    }
}
