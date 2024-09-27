using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Controls
{
    public partial class DetainInfoControl : UserControl
    {
        public DetainInfoControl()
        {
            InitializeComponent();
        }

        public event Action<TextBox> onTextChange;
        protected virtual void TextChange(TextBox textBox)
        {
            Action<TextBox> Handler = onTextChange;
            if(Handler != null)
                Handler(textBox);
        }
        public void FillFormData(int LicenseID, string Username)
        {
            lbl_DetainDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            if(LicenseID != -1)
                lbl_LicenseID.Text = LicenseID.ToString();
            lbl_CreatedBy.Text = Username;
        }
        private void txt_FineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt_FineFees_TextChanged(object sender, EventArgs e)
        {
            if (onTextChange != null)
                TextChange(txt_FineFees);
        }
        public void UpdateDetainID(int DetainID)
        {
            lbl_DetainID.Text = DetainID.ToString();
        }

    }
}
