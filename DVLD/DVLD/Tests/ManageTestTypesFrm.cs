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
    public partial class ManageTestTypesFrm : Form
    {
        public ManageTestTypesFrm()
        {
            InitializeComponent();
            FillForm();
        }
        void FillForm()
        {
            DT = clsTestTypes.GetAllTestTypes();
            dgv_TestTypes.DataSource = null;
            dgv_TestTypes.DataSource = DT;
            lbl_RecordsNum.Text = dgv_TestTypes.RowCount.ToString();
        }

        DataTable DT;
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_TestTypes.CurrentRow != null)
            {
                if (int.TryParse(dgv_TestTypes.CurrentRow.Cells[0].Value.ToString(), out int TestTypeID))
                {
                    UpdateTestTypeFrm Frm = new UpdateTestTypeFrm(TestTypeID);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                }
            }
        }
    }
}
