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

namespace DVLD.Forms
{
    public partial class ListDetainedLicensesFrm : Form
    {
        public ListDetainedLicensesFrm()
        {
            InitializeComponent();
            _Refresh();
        }
        void _Refresh()
        {
            DT = clsDetainedLicenses.GetAllDetainedLicense();
            dgv_DetainedLicenses.DataSource = null;
            dgv_DetainedLicenses.DataSource = DT;
            lbl_RecordsNum.Text = dgv_DetainedLicenses.RowCount.ToString();

            if (DT != null)
                dv = DT.DefaultView;
        }

        DataTable DT;

        DataView dv;
        private void cbx_FiltterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_FiltterBy.Text == "None")
            {
                txt_Find.Visible = false;
                cbx_Active.Visible = false;
                txt_Find.Text = "";
                cbx_Active.SelectedIndex = 0;

                if (dv != null)
                    dv.RowFilter = "";
            }
            else if (cbx_FiltterBy.Text == "Is Active")
            {
                txt_Find.Visible = false;
                cbx_Active.Visible = true;
                txt_Find.Text = "";

                if (dv != null)
                    dv.RowFilter = "";
            }
            else
            {
                txt_Find.Visible = true;
                cbx_Active.Visible = false;
                cbx_Active.SelectedIndex = 0;

                if (dv != null)
                    dv.RowFilter = "";
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_ReleaseLicense_Click(object sender, EventArgs e)
        {
            ReleaseDetainLicenseFrm Frm = new ReleaseDetainLicenseFrm();
            Frm.FormClosed += Frm_FormClosed;
            Frm.ShowDialog();
        }
        private void btn_DetainedLicenses_Click(object sender, EventArgs e)
        {
            DetainLicenseFrm Frm = new DetainLicenseFrm();
            Frm.FormClosed += Frm_FormClosed;
            Frm.ShowDialog();
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Refresh();
        }
        void FindByID(string str)
        {
            DataView dv = DT.DefaultView;
            if (int.TryParse(txt_Find.Text, out int ID))
                dv.RowFilter = $"[{str}] = {ID}";
            else
                dv.RowFilter = "";
        }
        void Find(string str)
        {
            DataView dv = DT.DefaultView;
            if(str == "Is Released")
            {
                if (cbx_Active.SelectedIndex == 0)
                    dv.RowFilter = "";
                else if (cbx_Active.SelectedIndex == 1)
                    dv.RowFilter = $"[{str}] = {true}";
                else if (cbx_Active.SelectedIndex == 2)
                    dv.RowFilter = $"[{str}] = {false}";
            }
            else
            {
                if (txt_Find.Text == "")
                    dv.RowFilter = "";
                else
                    dv.RowFilter = $"[{str}] = [{txt_Find.Text}]";
            }
        }
        void Search()
        {
            if (DT == null) return;

            switch (cbx_FiltterBy.Text)
            {
                case "D.ID":
                    FindByID("D.ID");
                    break;
                case "L.ID":
                    FindByID("L.ID");
                    break;
                case "Is Released":
                    Find("Is Released");
                    break;
                case "N.No":
                    Find("N.No");
                    break;
                case "Full Name":
                    Find("Full Name");
                    break;
                case "Release App.ID":
                    Find("Release App.ID");
                    break;
            }
        }
        private void cbx_Active_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgv_DetainedLicenses.CurrentRow == null) return;

            int DetainID = 0;
            if (!int.TryParse(dgv_DetainedLicenses.CurrentRow.Cells[0].Value.ToString(), out DetainID)) return;
            
            releaseDetaibedLicenseTSMI.Enabled = true;

            if (clsDetainedLicenses.IsRelease(DetainID))
            {
                releaseDetaibedLicenseTSMI.Enabled = false;
            }
        }
        private void showPersonDetailsTSMI_Click(object sender, EventArgs e)
        {
            PersonInfoFrm PersonInfo = new PersonInfoFrm(dgv_DetainedLicenses.CurrentRow.Cells[6].Value.ToString());
            PersonInfo.MdiParent = MdiParent;
            PersonInfo.Show();
        }
        private void showLicenseDetailsTSMI_Click(object sender, EventArgs e)
        {
            int LicenceID = 0;
            if (!int.TryParse(dgv_DetainedLicenses.CurrentRow.Cells[1].Value.ToString(), out LicenceID)) return;

            DriverLicenseInfoFrm Frm = new DriverLicenseInfoFrm(LicenceID);
            Frm.MdiParent = MdiParent;
            Frm.Show();
        }
        private void showPersonLicenseHistoryTSMI_Click(object sender, EventArgs e)
        {
            if (dgv_DetainedLicenses.CurrentRow == null) return;

            LicenseHistoryFrm Frm = new LicenseHistoryFrm(dgv_DetainedLicenses.CurrentRow.Cells[6].Value.ToString());
            Frm.MdiParent = MdiParent;
            Frm.Show();
        }
        private void releaseDetaibedLicenseTSMI_Click(object sender, EventArgs e)
        {
            if (dgv_DetainedLicenses.CurrentRow == null) return;

            int LicenceID = 0;
            if (!int.TryParse(dgv_DetainedLicenses.CurrentRow.Cells[1].Value.ToString(), out LicenceID)) return;

            ReleaseDetainLicenseFrm Frm = new ReleaseDetainLicenseFrm(LicenceID);
            Frm.onLisenseReleased += Frm_onLisenseReleased;
            Frm.ShowDialog();
        }
        private void Frm_onLisenseReleased(int ReleasedAppID)
        {
            _Refresh();
        }
    }
}
