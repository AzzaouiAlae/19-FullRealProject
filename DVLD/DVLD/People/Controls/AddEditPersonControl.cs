using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace DVLD
{
    public partial class AddEditPersonControl : UserControl
    {
        enum enMode { enAddNew, enUpdate }

        enMode Mode = enMode.enAddNew;
        public AddEditPersonControl()
        {
            InitializeComponent();
            dtp_DateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            _FillCountries();
        }

        public event Action<AddEditPersonControl> onExitClick;
        protected virtual void ExitClick(AddEditPersonControl AddEdit)
        {
            Action<AddEditPersonControl> Handler = onExitClick;
            if (Handler != null)
            {
                Handler(AddEdit);
            }
        }

        clsPerson Person;

        public event Action<int> onSaveClick;
        protected virtual void SaveClick(int ID)
        {
            Action<int> Handler = onSaveClick;
            if (Handler != null)
            {
                Handler(ID);
            }
        }
        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "openFileDialog1")
                return;

            if (rb_Female.Checked)
                picBox.Image = Resources.person_girl72;
        }
        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "openFileDialog1")
                return;

            if (rb_Male.Checked)
                picBox.Image = Resources.person_boy72;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (onExitClick != null)
                ExitClick(this);
        }
        void _SetPersonData()
        {
            if (Person == null)
                Person = new clsPerson();

            Person.FirstName = txt_FirstName.Text;
            Person.SecondName = txt_SecondName.Text;
            Person.ThirdName = txt_ThirdName.Text;
            Person.LastName = txt_LastName.Text;
            Person.NationalNo = txt_NationalNum.Text;
            Person.DateOfBirth = dtp_DateOfBirth.Value;
            Person.Gendor = rb_Female.Checked;
            Person.Phone = txt_Phone.Text;
            Person.Email = txt_Email.Text;
            Person.CountryID = cb_Country.SelectedIndex + 1;
            Person.Address = txt_Address.Text;
        }
        void _ShowMess(string Msg)
        {
            MessageBox.Show($"{Msg} is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        bool _CheckPersonForm()
        {
            FormValidation();
            Regex regex = new Regex(@"^(\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)?$");
            if (txt_FirstName.Text == "")
            {
                _ShowMess("FirstName");
                return false;
            }
            else if (txt_LastName.Text == "")
            {
                _ShowMess("LastName");
                return false;
            }
            else if (txt_NationalNum.Text == "")
            {
                _ShowMess("National no");
                return false;
            }
            else if (txt_Phone.Text == "")
            {
                _ShowMess("Phone");
                return false;
            }
            else if (!regex.IsMatch(txt_Email.Text))
            {
                MessageBox.Show("Email is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txt_Address.Text == "")
            {
                _ShowMess("Address");
                return false;
            }
            else if (cb_Country.SelectedIndex == -1)
            {
                _ShowMess("Country");
                return false;
            }
            return true;
        }

        FileStream File;
        public void SetDataToForm(int ID)
        {
            Person = clsPerson.FindPerson(ID);
            if (Person == null)
            {
                MessageBox.Show(clsPerson.Log);
                return;
            }
            Mode = enMode.enUpdate;
            txt_FirstName.Text = Person.FirstName;
            txt_SecondName.Text = Person.SecondName;
            txt_ThirdName.Text = Person.ThirdName;
            txt_LastName.Text = Person.LastName;
            txt_NationalNum.Text = Person.NationalNo;
            dtp_DateOfBirth.Value = Person.DateOfBirth;
            rb_Female.Checked = Person.Gendor;
            rb_Male.Checked = !Person.Gendor;
            txt_Phone.Text = Person.Phone;
            txt_Email.Text = Person.Email;
            cb_Country.SelectedIndex = Person.CountryID - 1;
            txt_Address.Text = Person.Address;
            if (System.IO.File.Exists(Person.ImagePath))
            {
                File = new FileStream(Person.ImagePath, FileMode.Open, FileAccess.Read);
                picBox.Image = Image.FromStream(File);
                lbl_RemoveImg.Visible = true;
            }
        }
        void _FillCountries()
        {
            List<string> list = clsCountries.GetAllCountries();
            if (list != null && list.Count > 0)
            {
                cb_Country.Items.AddRange(list.ToArray());
                cb_Country.SelectedIndex = 118;
            }
        }
        private void txt_NationalNum_Leave(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_NationalNum.Text == "")
                ep.SetError(txt_NationalNum, "National Number is empty");

            else if (clsPerson.IsPersonExist(txt_NationalNum.Text))
                ep.SetError(txt_NationalNum, "National is exist");
        }
        private void txt_NationalNum_TextChanged(object sender, EventArgs e)
        {
            ep.Clear();
        }
        private void lbl_RemoveImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "openFileDialog1";

            if (rb_Male.Checked)
                picBox.Image = Resources.person_boy72;

            else
                picBox.Image = Resources.person_girl72;

            if (Person != null)
            {
                if (System.IO.File.Exists(Person.ImagePath))
                {
                    File.Close();
                    System.IO.File.Delete(Person.ImagePath);
                    Person.ImagePath = "";
                }
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!_CheckPersonForm()) return;
            _SetPersonData();

            if (Person.Save())
            {
                if (Mode == enMode.enAddNew)
                    CreateNewPerson(Person.PersonID);

                Mode = enMode.enUpdate;
                MessageBox.Show("Person saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveClick(Person.PersonID);
            }

            else
                MessageBox.Show(clsPerson.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void lbl_SetImage_Click(object sender, EventArgs e)
        {
            if (Person != null)
            {
                if (System.IO.File.Exists(Person.ImagePath))
                {
                    File.Close();
                    System.IO.File.Delete(Person.ImagePath);
                }
            }

            Guid g = Guid.NewGuid();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imgPath = "C:\\DVDL-Pepole-Images\\" + g.ToString() + Path.GetExtension(openFileDialog1.FileName);
                System.IO.File.Copy(Path.Combine(Path.GetDirectoryName(openFileDialog1.FileName), Path.GetFileName(openFileDialog1.FileName)), Path.Combine("C:\\DVDL-Pepole-Images\\", g.ToString() + Path.GetExtension(openFileDialog1.FileName)), true);
                File = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                picBox.Image = Image.FromStream(File);
                lbl_RemoveImg.Visible = true;

                if (Person == null)
                    Person = new clsPerson();

                Person.ImagePath = imgPath;
            }
        }
        void FormValidation()
        {
            ep.Clear();
            if (txt_FirstName.Text == "")
            {
                ep.SetError(txt_FirstName, "FirstName is empty");
            }
            if (txt_LastName.Text == "")
            {
                ep.SetError(txt_LastName, "LastName is empty");
            }
            if (txt_NationalNum.Text == "")
            {
                ep.SetError(txt_NationalNum, "National No is empty");
            }
            if (txt_Phone.Text == "")
            {
                ep.SetError(txt_Phone, "Phone is empty");
            }
            Regex regex = new Regex(@"^(\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)?$");
            if (!regex.IsMatch(txt_Email.Text))
            {
                ep.SetError(txt_Email, "Email is not valid");
            }
            if (txt_Address.Text == "")
            {
                ep.SetError(txt_Address, "Address is empty");
            }
        }
        private void txt_Email_Leave(object sender, EventArgs e)
        {
            ep.Clear();
            Regex regex = new Regex(@"^(\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)?$");
            if (!regex.IsMatch(txt_Email.Text))
            {
                ep.SetError(txt_Email, "Email is not valid");
            }
        }
        private void txt_FirstName_Leave(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_FirstName.Text == "")
            {
                ep.SetError(txt_FirstName, "FirstName is empty");
            }
        }
        private void txt_LastName_Leave(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_LastName.Text == "")
            {
                ep.SetError(txt_LastName, "LastName is empty");
            }
        }
        private void txt_Address_Leave(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_Address.Text == "")
            {
                ep.SetError(txt_Address, "Address is empty");
            }
        }
        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+')
                e.Handled = true;
        }
        private void txt_Phone_Leave(object sender, EventArgs e)
        {
            ep.Clear();
            if (txt_Phone.Text == "")
            {
                ep.SetError(txt_Phone, "Phone is empty");
            }
        }

        public event Action<int> onCreateNewPerson;
        protected virtual void CreateNewPerson(int PersonID)
        {
            Action<int> Handler = onCreateNewPerson;
            if (Handler != null)
            {
                Handler(PersonID);
            }
        }
    }
}
