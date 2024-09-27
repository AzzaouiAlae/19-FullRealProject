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
    public partial class ManageDriversFrm : Form
    {
        public ManageDriversFrm()
        {
            InitializeComponent();
            FillForm();
        }

        DataTable DT;
        void FillForm()
        {
            DT = clsDrivers.GetAllDrivers();
            dgv_Drivers.DataSource = null;
            dgv_Drivers.DataSource = DT;
            
            lbl_RecordsNum.Text = dgv_Drivers.RowCount.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ShowPersonInfoTSMI_Click(object sender, EventArgs e)
        {
            if (dgv_Drivers.CurrentRow != null)
            {
                if(int.TryParse(dgv_Drivers.CurrentRow.Cells[1].Value.ToString(), out int PersonID))
                {
                    PersonInfoFrm PersonInfo = new PersonInfoFrm(PersonID);
                    PersonInfo.MdiParent = MdiParent;
                    PersonInfo.Show();
                }
            }
        }
        private void ShowPersonLicenseHistoryTSMI_Click(object sender, EventArgs e)
        {
            if (dgv_Drivers.CurrentRow != null)
            {
                if (int.TryParse(dgv_Drivers.CurrentRow.Cells[1].Value.ToString(), out int PersonID))
                {
                    LicenseHistoryFrm Frm = new LicenseHistoryFrm(-1, -1, PersonID);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                }
            }
        }

        private void issueInternationalLicenseTSMI_Click(object sender, EventArgs e)
        {
            if (dgv_Drivers.CurrentRow != null)
            {
                if (int.TryParse(dgv_Drivers.CurrentRow.Cells[1].Value.ToString(), out int PersonID))
                {
                    NewInternationalLicenseFrm Frm = new NewInternationalLicenseFrm(PersonID);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                }
            }
        }

        private void cbx_FiltterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_FiltterBy.Text == "None")
                txt_Find.Visible = false;
            else
                txt_Find.Visible = true;
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
            if (txt_Find.Text != "")
                dv.RowFilter = $"[{str}] LIKE '{txt_Find.Text}%'";

            else
                dv.RowFilter = "";
        }
        void Search()
        {
            if (DT == null) return;

            switch (cbx_FiltterBy.Text)
            {
                case "DriverID":
                    FindByID("DriverID");
                    break;
                case "PersonID":
                    FindByID("PersonID");
                    break;
                case "NationalNo":
                    Find("NationalNo");
                    break;
                case "Full Name":
                    Find("Full Name");
                    break;                
            }
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
