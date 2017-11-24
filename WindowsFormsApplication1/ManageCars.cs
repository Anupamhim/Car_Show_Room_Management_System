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
    public partial class ManageCars : Form
    {
        public ManageCars()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();


        private void button1_Click(object sender, EventArgs e)
        {
            Edit_car ec = new Edit_car();
            this.Close();
            ec.Show();
        }

        private void show_Click(object sender, EventArgs e)
        {
            ml.viewCar(dataGridView1);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ml.delCar(this.id);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TabularSummary t = new TabularSummary();
            this.Close();
            t.Show();
        }
    }
}
