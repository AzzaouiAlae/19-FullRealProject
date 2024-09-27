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
    public partial class PersonInfoFrm : Form
    {
        public PersonInfoFrm(int ID)
        {
            InitializeComponent();
            personInfo.FindPerson(ID);
        }
        public PersonInfoFrm(string NationalNo)
        {
            InitializeComponent();
            personInfo.FindPerson(NationalNo);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
