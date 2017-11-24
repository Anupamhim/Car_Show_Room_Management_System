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
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void header1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           ml.editProfile(this.id, this.pass);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            this.Close();
            db.Show();
        }
    }
}
