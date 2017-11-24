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
    public partial class ManageEmployees : Form
    {
        public ManageEmployees()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            Edit_employee em = new Edit_employee();
            this.Close();
            em.Show();
        }

        private void show_Click(object sender, EventArgs e)
        {
            ml.viewEmployee(dataGridView1);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ml.delEmployee(this.id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_employeeinfo v = new View_employeeinfo();
            this.Close();
            v.Show();
        }
    }
}
