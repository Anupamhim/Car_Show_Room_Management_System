using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();

        private void button1_Click(object sender, EventArgs e)
        {

            bool i = ml.fd(this.userid, this.password);
            
            if (i == true)
            {
                DashBoard d = new DashBoard();
                
                d.Show();
                //MessageBox.Show(Convert.ToString(i));
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID Or Password");
            }

           /* LogIn login = new LogIn();
           
                DashBoard ds = new DashBoard();
                ds.Show();
                this.Hide();*/
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
