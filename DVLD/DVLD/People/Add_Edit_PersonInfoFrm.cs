using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Add_Edit_PersonInfoFrm : Form
    {
        public Add_Edit_PersonInfoFrm()
        {
            InitializeComponent();
        }
        public Add_Edit_PersonInfoFrm(int PersonID)
        {
            InitializeComponent();
            addEditControl1.SetDataToForm(PersonID);
            lbl_Title.Text = "Update Person Info";
        }
        private void addEditControl1_onExitClick(AddEditPersonControl obj)
        {
            Close();
        }
        private void addEditControl1_onSaveClick(int PersonID)
        {
            lbl_ID.Text = PersonID.ToString();
            lbl_Title.Text = "Update Person Info";
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
        private void addEditControl1_onCreateNewPerson(int PersonID)
        {
            CreateNewPerson(PersonID);
        }
    }
}
