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
    public partial class FindPersonFrm : Form
    {
        public FindPersonFrm()
        {
            InitializeComponent();
        }
        public event Action<int> onExitClick;
        protected virtual void ExitClick(int ID)
        {
            Action<int> Handler = onExitClick;
            if (Handler != null)
            {
                Handler(ID);
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }        
    }
}
