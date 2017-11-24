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
    public partial class View_dealerinfo : Form
    {
        public View_dealerinfo()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();

        private void box_Click(object sender, EventArgs e)
        {
            ManageDealers m = new ManageDealers();
            this.Close();
            m.Show();
        }

        private void view_Click(object sender, EventArgs e)
        {
            ml.retDealer(this.image, this.id, this.dataGridView1);
        }
    }
}
