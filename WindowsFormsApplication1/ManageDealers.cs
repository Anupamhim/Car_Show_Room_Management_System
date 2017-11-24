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
    public partial class ManageDealers : Form
    {
        public ManageDealers()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();

        private void edit_Click(object sender, EventArgs e)
        {
            Edit_dealer ed = new Edit_dealer();
            this.Close();
            ed.Show();

        }

        private void show_Click(object sender, EventArgs e)
        {
            
            ml.viewDealer(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_dealerinfo bi = new View_dealerinfo();
            this.Close();
            bi.Show();
        }

        
    }
}
