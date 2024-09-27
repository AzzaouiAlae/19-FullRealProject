using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Controls.License
{
    public partial class LicenseFilterControl : UserControl
    {
        public LicenseFilterControl()
        {
            InitializeComponent();
        }

        public event Action<TextBox> Find;
        protected virtual void FindEv(TextBox text)
        {
            Action<TextBox> Handler = Find;

            if (Handler != null)
                Handler(text);
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (Find != null)
                FindEv(txt_Find);
        }
        public Size border_size
        {
            get => gb.Size;
            set => gb.Size = value;
        }
    }
}
