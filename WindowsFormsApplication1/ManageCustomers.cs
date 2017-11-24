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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();

        private void button1_Click(object sender, EventArgs e)
        {
            Edit_customer ec = new Edit_customer();
            this.Close();
            ec.Show();
        }

        private void show_Click(object sender, EventArgs e)
        {
           
            ml.viewCustomer(dataGridView1);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ml.delCustomer(this.id);
        }
    }
}
