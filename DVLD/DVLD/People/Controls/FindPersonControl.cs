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

namespace DVLD.Controls
{
    public partial class FindPersonControl : UserControl
    {
        public FindPersonControl()
        {
            InitializeComponent();
        }

        public event Action<int> onPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = onPersonSelected;
            if(Handler != null)            
                Handler(PersonID);            
        }
        private void personFillter1_onBtnAdd(Button obj)
        {
            Add_Edit_PersonInfoFrm Frm = new Add_Edit_PersonInfoFrm();
            Frm.Show();
            Frm.onCreateNewPerson += Frm_onCreateNewPerson;
        }
        private void Frm_onCreateNewPerson(int PersonID)
        {
            personInfo.FindPerson(PersonID);
            personFillter1.txt_Find.Text = PersonID.ToString();
        }
        private void personFillter1_onBtnOk(TextBox txt_Find, ComboBox cbx_FindBy)
        {
            if (cbx_FindBy.Text == "Person ID")
            {
                if (int.TryParse(txt_Find.Text, out int PersonID))
                    personInfo.FindPerson(PersonID);
            }
            else
                personInfo.FindPerson(txt_Find.Text);
        }
        private void personInfo_onPersonSelected(int PersonID)
        {
            PersonSelected(PersonID);
        }
        public void FindPersen(int PersonID)
        {
            personInfo.FindPerson(PersonID);
        }
    }
}
