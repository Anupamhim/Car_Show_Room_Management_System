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
    public partial class Edit_customer : Form
    {
        public Edit_customer()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ml.editCustomer(this.id,this.fname,this.lname,this.email,this.mobile,this.address,this.cid,this.byingDate);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageCustomers dBoard = new ManageCustomers();
            this.Close();
            dBoard.Show();

        }
    }
}
