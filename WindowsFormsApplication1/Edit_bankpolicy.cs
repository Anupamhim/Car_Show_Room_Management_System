using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Edit_bankpolicy : Form
    {
        public Edit_bankpolicy()
        {
            InitializeComponent();
        }

        MiddleLayer ml = new MiddleLayer();


        private void button3_Click(object sender, EventArgs e)
        {
            ManageBankPolicy mb = new ManageBankPolicy();
            this.Close();
            mb.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ml.editBankPolicy(this.id,this.bname,this.branch,this.address,this.image);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
