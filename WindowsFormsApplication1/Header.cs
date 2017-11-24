using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms) {
                var.Hide();
            }
            LoginForm log = new LoginForm();
            log.Show();

        }
    }
}
