using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD_Business;
using System.IO;
using DVLD.Properties;

namespace DVLD
{
    public partial class PersonInfoControl : UserControl
    {
        public PersonInfoControl()
        {
            InitializeComponent();
        }

        int PersonID = -1;
        void FillPersonData(clsPerson P)
        {
            PersonID = P.PersonID;
            lbl_EditPerson.Enabled = true;
            lbl_ID.Text = P.PersonID.ToString();
            lbl_Name.Text = P.FullName();
            lbl_NationalNo.Text = P.NationalNo;
            lbl_Gender.Text = P.Gendor ? "Femal" : "Male";
            if(!string.IsNullOrEmpty(P.Email))
                lbl_Email.Text = P.Email;
            lbl_Address.Text = P.Address;
            lbl_DateOfBirth.Text = P.DateOfBirth.ToString("dd MMM yyyy");
            lbl_Phone.Text = P.Phone;
            lbl_Country.Text = P.CountryName;
            if (!string.IsNullOrEmpty(P.Email) && File.Exists(P.ImagePath))
                picBox.Image = Image.FromFile(P.ImagePath);
            else            
                picBox.Image = P.Gendor ? Resources.person_girl72 : Resources.person_boy72;            
        }
        public bool FindPerson(int ID)
        {
            clsPerson P = clsPerson.FindPerson(ID);
            if(P == null)
            {
                MessageBox.Show(clsPerson.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetForm();
                return false;
            }
            else
            {
                FillPersonData(P);
                PersonSelected(P.PersonID);
                return true;
            }
        }
        public bool FindPerson(string NationalNo)
        {
            clsPerson P = clsPerson.FindPerson(NationalNo);
            if (P == null)
            {
                MessageBox.Show(clsPerson.Log);
                return false;
            }
            else
            {
                FillPersonData(P);
                PersonSelected(P.PersonID);
                return true;
            }
        }
        private void lbl_EditPerson_Click(object sender, EventArgs e)
        {            
            Add_Edit_PersonInfoFrm PersonInfo = new Add_Edit_PersonInfoFrm(PersonID);
            PersonInfo.Show();
        }

        public event Action<int> onPersonSelected;
        protected virtual void PersonSelected(int ID)
        {
            Action<int> Handler = onPersonSelected;

            if(Handler != null)
                Handler(PersonID);
        }
        void ResetForm()
        {
            PersonID = -1;
            lbl_EditPerson.Enabled = false;
            lbl_ID.Text = "...";
            lbl_Name.Text = "...";
            lbl_NationalNo.Text = "...";
            lbl_Gender.Text = "...";
            lbl_Email.Text = "...";
            lbl_Address.Text = "...";
            lbl_DateOfBirth.Text = "...";
            lbl_Phone.Text = "...";
            lbl_Country.Text = "...";
            picBox.Image = Resources.person_boy72;
        }
    }
}
