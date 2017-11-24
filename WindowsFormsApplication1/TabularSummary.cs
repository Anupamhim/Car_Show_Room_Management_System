using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TabularSummary : Form
    {
        public TabularSummary()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();


        private void view_Click(object sender, EventArgs e)
        {
            ml.retCar(this.image, this.id, this.dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCars m = new ManageCars();
            this.Close();
            m.Show();
        }
    }
}
