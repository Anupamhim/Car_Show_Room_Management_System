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
    public partial class Edir_branch : Form
    {
        public Edir_branch()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();


        private void button1_Click(object sender, EventArgs e)
        {
            ml.editBranch(this.id, this.bname, this.address, this.mobile, this.city);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageBranch mb = new ManageBranch();
            this.Close();
            mb.Show();
        }
    }
}
