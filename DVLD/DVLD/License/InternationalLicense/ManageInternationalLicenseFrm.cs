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
    public partial class ManageInternationalLicenseFrm : Form
    {
        public ManageInternationalLicenseFrm()
        {
            InitializeComponent();
            _Refresh();
            cbx_Active.SelectedIndex = 0;
        }
        void _Refresh()
        {
            DT = clsInternationalLicense.GetAllIntLicense();
            dgv_InternationalLicense.DataSource = null;
            dgv_InternationalLicense.DataSource = DT;
            lbl_RecordsNum.Text = dgv_InternationalLicense.RowCount.ToString();

            if (DT != null)
                dv = DT.DefaultView;
        }

        DataTable DT;

        DataView dv;
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_AddLDLApp_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseFrm Frm = new NewInternationalLicenseFrm();
            Frm.FormClosed += Frm_FormClosed;
            Frm.ShowDialog();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Refresh();
        }

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
            else if(cbx_FiltterBy.Text == "Is Active")
            {
                txt_Find.Visible = false;
                cbx_Active.Visible = true;
                txt_Find.Text = "";
            }
            else
            {
                txt_Find.Visible = true;
                cbx_Active.Visible = false;
                cbx_Active.SelectedIndex = 0;
            }
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
            if (cbx_Active.SelectedIndex == 0)
                dv.RowFilter = "";
            else if(cbx_Active.SelectedIndex == 1)
                dv.RowFilter = $"[{str}] = {true}";
            else if (cbx_Active.SelectedIndex == 2)
                dv.RowFilter = $"[{str}] = {false}";
        }
        void Search()
        {
            if (DT == null) return;

            switch (cbx_FiltterBy.Text)
            {
                case "Int.License ID":
                    FindByID("Int.License ID");
                    break;
                case "Application ID":
                    FindByID("Application ID");
                    break;
                case "Driver ID":
                    FindByID("Driver ID");
                    break;
                case "L.License ID":
                    FindByID("L.License ID");
                    break;
                case "Is Active":
                    Find("Is Active");
                    break;
            }
        }
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void cbx_Active_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void showPersonDetailsTSMI_Click(object sender, EventArgs e)
        {
            if (dgv_InternationalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_InternationalLicense.CurrentRow.Cells[2].Value.ToString(), out int DriverID))
                {
                    clsDrivers d = clsDrivers.Find(DriverID);
                    PersonInfoFrm PersonInfo = new PersonInfoFrm(d.PersonID);
                    PersonInfo.MdiParent = MdiParent;
                    PersonInfo.Show();
                }
            }
        }
        private void showLicenseDetailsTSMI_Click(object sender, EventArgs e)
        {
            if (dgv_InternationalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_InternationalLicense.CurrentRow.Cells[0].Value.ToString(), out int InteLicense))
                {
                    DriverLicenseInfoFrm Frm = new DriverLicenseInfoFrm(-1, InteLicense);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                }
            }
        }
        private void showPersonLicenseHistoryTSMI_Click(object sender, EventArgs e)
        {
            if (dgv_InternationalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_InternationalLicense.CurrentRow.Cells[2].Value.ToString(), out int DriverID))
                {
                    clsDrivers d = clsDrivers.Find(DriverID);
                    LicenseHistoryFrm Frm = new LicenseHistoryFrm(-1,-1, d.PersonID);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                }
            }
        }
    }
}
