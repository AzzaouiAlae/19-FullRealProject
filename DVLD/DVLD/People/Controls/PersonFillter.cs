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
    public partial class PersonFillter : UserControl
    {
        public PersonFillter()
        {
            InitializeComponent();
        }

        public event Action<TextBox, ComboBox> onBtnOk;
        protected virtual void BtnOk(TextBox txt_Find, ComboBox cbx)
        {
            Action<TextBox, ComboBox> Handler = onBtnOk;
            if( Handler != null )
                Handler(txt_Find, cbx);
        }

        public event Action<Button> onBtnAdd;
        protected virtual void BtnAdd(Button btn_Add)
        {
            Action<Button> Handler = onBtnAdd;

            if (Handler != null)
                Handler(btn_Add);
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if(onBtnOk != null)            
                BtnOk(txt_Find, cbx_FindBy);
        }
        private void txt_Find_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            if(cbx_FindBy.Items.Count == 0)
            {
                if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (onBtnAdd != null)            
                BtnAdd(btn_Add);            
        }
        private void txt_Find_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btn_Ok.PerformClick();
        }
    }
}
