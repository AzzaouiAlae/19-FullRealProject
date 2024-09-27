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
    public partial class ManageUsersFrm : Form
    {
        public ManageUsersFrm()
        {
            InitializeComponent();
            _Refresh();
        }

        DataTable DT;

        DataView dv;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            AddEditUserFrm AddUser = new AddEditUserFrm();
            AddUser.MdiParent = MdiParent;
            AddUser.Show();
            AddUser.FormClosed += AddUser_FormClosed;
        }
        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Refresh();
        }
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            if (dgv_Users.CurrentRow == null) return;

            if (int.TryParse(dgv_Users.CurrentRow.Cells[0].Value.ToString(), out int ID))
            {
                ChangePasswordFrm Frm = new ChangePasswordFrm(ID);
                Frm.MdiParent = MdiParent;
                Frm.Show();
                Frm.FormClosed += Frm_FormClosed1;
            }
        }
        private void Frm_FormClosed1(object sender, FormClosedEventArgs e)
        {
            _Refresh();
        }
        void _Refresh()
        {
            DT = clsUser.GetAllUsers();
            dgv_Users.DataSource = null;
            dgv_Users.DataSource = DT;
            if(DT != null)
                lbl_RecordsNum.Text = DT.Rows.Count.ToString();
        }
        private void ManageUsersFrm_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
        private void show_Details_Click(object sender, EventArgs e)
        {
            if (dgv_Users.CurrentRow == null) return;

            if (int.TryParse(dgv_Users.CurrentRow.Cells[0].Value.ToString(), out int ID))
            {
                UserInfoFrm frm = new UserInfoFrm(ID);
                frm.MdiParent = MdiParent;
                frm.Show();
            }
        }
        private void AddNewPerson_Click(object sender, EventArgs e)
        {
            AddEditUserFrm AddUser = new AddEditUserFrm();
            AddUser.MdiParent = MdiParent;
            AddUser.Show();
            AddUser.FormClosed += AddUser_FormClosed;
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Users.CurrentRow == null) return;

            if (int.TryParse(dgv_Users.CurrentRow.Cells[0].Value.ToString(), out int ID))
            {
                AddEditUserFrm AddUser = new AddEditUserFrm(ID);
                AddUser.MdiParent = MdiParent;
                AddUser.Show();
                AddUser.FormClosed += AddUser_FormClosed;
            }
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Refresh();
        }
        void DeleteUser(int ID)
        {
            if (MessageBox.Show("Are you sure you want to delet this user?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;

            if (clsUser.Delete(ID))
            {
                MessageBox.Show("User Deleted Successufully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Refresh();
            }
            else
                MessageBox.Show(clsUser.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Users.CurrentRow == null) return;

            if (int.TryParse(dgv_Users.CurrentRow.Cells[0].Value.ToString(), out int ID))
            {
                DeleteUser(ID);
            }
        }
        private void cbx_FiltterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbx_FiltterBy.SelectedIndex;
            dv.RowFilter = "";
            if (i == 0)
            {
                txt_Find.Visible = false;
                cb_IsActive.Visible = false;
            }
            else if(i < 5)
            {
                txt_Find.Visible = true;
                cb_IsActive.Visible = false;
            }
            else if (i == 5)
            {
                txt_Find.Visible = false;
                cb_IsActive.Visible = true;
                cb_IsActive.Text = "All";
            }
        }
        void FindByID(string str)
        {
            dv = DT.DefaultView;
            if(int.TryParse(txt_Find.Text, out int id))
            {
                dv.RowFilter = $"[{str}] = {id}";
            }
            else
                dv.RowFilter = $"";
        }
        void Find(string str)
        {
            dv = DT.DefaultView;
            if (txt_Find.Text != "")
            {
                dv.RowFilter = $"[{str}] Like '{txt_Find.Text}%'";
            }
            else
                dv.RowFilter = $"";
        }
        void Search()
        {
            if (DT == null) return;

            switch (cbx_FiltterBy.Text)
            {
                case "User ID":
                    FindByID("User ID");
                    break;
                case "Username":
                    Find("UserName");
                    break;
                case "Person ID":
                    FindByID("Person ID");
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
        private void Send_Email_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not implemented yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void PhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not implemented yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void txt_Find_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbx_FiltterBy.Text == "User ID" || cbx_FiltterBy.Text == "Person ID")
            {
                e.Handled = false;
                if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void cb_IsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            dv = DT.DefaultView;
            if (cb_IsActive.Text == "Active")
                dv.RowFilter = $"[Is Active] LIKE 'True'";
            else if (cb_IsActive.Text == "Not Active")
                dv.RowFilter = $"[Is Active] LIKE 'False'";
            else
                dv.RowFilter = "";
        }
    }
}
