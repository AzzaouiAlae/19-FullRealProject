using DVLD.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD
{
    public partial class ManagePeopleFrm : Form
    {
        public ManagePeopleFrm()
        {
            InitializeComponent();
            _Refresh();
        }

        DataTable DT;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        void _Refresh()
        {
            DT = clsPerson.GetAllPeople();
            dgv_People.DataSource = null;
            dgv_People.DataSource = DT;
            lbl_RecordsNum.Text = dgv_People.RowCount.ToString();
        }
        private void PersonInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Refresh();
        }
        private void AddNewPerson_Click(object sender, EventArgs e)
        {
            Add_Edit_PersonInfoFrm PersonInfo = new Add_Edit_PersonInfoFrm();
            PersonInfo.MdiParent = MdiParent;
            PersonInfo.Show();
            PersonInfo.FormClosed += PersonInfo_FormClosed;
        }
        private void show_Details_Click(object sender, EventArgs e)
        {
            if (dgv_People.CurrentRow != null)
            {
                int.TryParse(dgv_People.CurrentRow.Cells[0].Value.ToString(), out int ID);
                PersonInfoFrm PersonInfo = new PersonInfoFrm(ID);
                PersonInfo.MdiParent = MdiParent;
                PersonInfo.Show();
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgv_People.CurrentRow != null)
            {
                int.TryParse(dgv_People.CurrentRow.Cells[0].Value.ToString(), out int ID);
                Add_Edit_PersonInfoFrm PersonInfo = new Add_Edit_PersonInfoFrm(ID);
                PersonInfo.MdiParent = MdiParent;
                PersonInfo.Show();
                PersonInfo.FormClosed += PersonInfo_FormClosed;
            }
        }
        private void ManagePeopleFrm_Load(object sender, EventArgs e)
        {
            _Refresh();
        }        
        private void cbx_FiltterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_FiltterBy.Text == "None")
                txt_Find.Visible = false;
            else
                txt_Find.Visible = true;
        }
        void FindByID()
        {
            DataView dv = DT.DefaultView;
            if (int.TryParse(txt_Find.Text, out int ID))
                dv.RowFilter = $"PersonID = {ID}";
            
            else
                dv.RowFilter = "";
        }
        void Find(string str)
        {
            DataView dv = DT.DefaultView;
            if (txt_Find.Text != "")
                dv.RowFilter = $"{str} LIKE '{txt_Find.Text}%'";

            else
                dv.RowFilter = "";
        }
        void Search()
        {
            if (DT == null) return;

            switch (cbx_FiltterBy.Text)
            {
                case "Person ID":
                    FindByID();
                    break;
                case "National No.":
                    Find("NationalNo");
                    break;
                case "First Name":
                    Find("FirstName");
                    break;
                case "Second Name":
                    Find("SecondName");
                    break;
                case "Third Name":
                    Find("ThirdName");
                    break;
                case "Last Name":
                    Find("LastName");
                    break;
                case "Nationalily":
                    Find("NationalityCountryID");
                    break;
                case "Gender":
                    Find("Gender");
                    break;
                case "Phone":
                    Find("Phone");
                    break;
                case "Email":
                    Find("Email");
                    break;
            }
        }
        private void txt_Find_TextChanged(object sender, EventArgs e)
        {            
            Search();
        }
        void DeletePerson(int ID)
        {
            if (MessageBox.Show("Are you sure you want to delet this Person?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;

            if (clsPerson.Delete(ID))
            {
                MessageBox.Show("Person Deleted Successufully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Refresh();
            }
            else
                MessageBox.Show(clsPerson.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgv_People.CurrentRow == null) return;

            if (int.TryParse(dgv_People.CurrentRow.Cells[0].Value.ToString(), out int ID))
            {
                DeletePerson(ID);
            }
        }
        private void Send_Email_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not implemented yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void PhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature is not implemented yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            Add_Edit_PersonInfoFrm PersonInfo = new Add_Edit_PersonInfoFrm();
            PersonInfo.MdiParent = MdiParent;
            PersonInfo.Show();
            PersonInfo.FormClosed += PersonInfo_FormClosed;
        }
        private void txt_Find_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbx_FiltterBy.Text == "Person ID")
            {
                e.Handled = false;
                if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}