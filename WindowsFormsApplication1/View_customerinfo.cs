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
    public partial class View_customerinfo : Form
    {
        public View_customerinfo()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();
        private void view_Click(object sender, EventArgs e)
        {
            ml.retBankPolicy(this.image,this.id,this.dataGridView1);

        }

        private void box_Click(object sender, EventArgs e)
        {
            ManageBankPolicy m = new ManageBankPolicy();
            this.Close();
            m.Show();
        }
    }
}
