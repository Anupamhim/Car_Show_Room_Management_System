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
    public partial class View_employeeinfo : Form
    {
        public View_employeeinfo()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();
        private void View_employeeinfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageEmployees mp = new ManageEmployees();
            this.Close();
            mp.Show();
        }

        private void view_Click(object sender, EventArgs e)
        {
            ml.retEmp(this.image, this.id, this.dataGridView1);
        }
    }
}
