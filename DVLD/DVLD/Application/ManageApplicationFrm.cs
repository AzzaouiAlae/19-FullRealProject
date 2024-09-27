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
    public partial class ManageApplicationFrm : Form
    {
        public ManageApplicationFrm()
        {
            InitializeComponent();
            _Refresh();
        }
        void _Refresh()
        {
            dgv_AppTypes.DataSource = null;
            DataTable dt = clsApplicationTypes.GetAllApplicationTypes();
            dgv_AppTypes.DataSource = dt;
            if(dt != null ) 
                lbl_RecordsNum.Text = dt.Rows.Count.ToString();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_AppTypes.CurrentRow != null)
            {
                if (int.TryParse(dgv_AppTypes.CurrentRow.Cells[0].Value.ToString(), out int AppTypeID))
                {
                    UpdateApplicationTypeFrm Frm = new UpdateApplicationTypeFrm(AppTypeID);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                }
            }
        }
    }
}
