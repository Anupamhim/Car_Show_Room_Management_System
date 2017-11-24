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
    public partial class ManageBankPolicy : Form
    {
        public ManageBankPolicy()
        {
            InitializeComponent();
        }

        MiddleLayer ml = new MiddleLayer();
        private void button3_Click(object sender, EventArgs e)
        {
            ml.viewBankPolicy(this.dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit_bankpolicy eb = new Edit_bankpolicy();
            this.Close();
            eb.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ml.delBankPolicy(this.id);
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            View_customerinfo v = new View_customerinfo();
            this.Close();
            v.Show();
            
        }
    }
}
