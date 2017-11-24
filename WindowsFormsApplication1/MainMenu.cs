using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            EditProfile frm = new EditProfile();
            frm.Show();
        }

        private void qToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            PassWord frm = new PassWord();
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            AddEmployee frm = new AddEmployee();
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            ManageEmployees frm = new ManageEmployees();
            frm.Show();

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            AddDealer frm = new AddDealer();
            frm.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            ManageDealers frm = new ManageDealers();
            frm.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            AddCar frm = new AddCar();
            frm.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            ManageCars frm = new ManageCars();
            frm.Show();
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            AddCustomer frm = new AddCustomer();
            frm.Show();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            ManageCustomers frm = new ManageCustomers();
            frm.Show();
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            //AddUser frm = new AddUser();
            //frm.Show();
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            //ManageUsers frm = new ManageUsers();
            //frm.Show();
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            TabularSummary frm = new TabularSummary();
            frm.Show();
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            IncomeStatement frm = new IncomeStatement();
            frm.Show();
        }

        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            AddBranch frm = new AddBranch();
            frm.Show();
        }

        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            ManageBranch frm = new ManageBranch();
            frm.Show();
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            AddBankPolicy frm = new AddBankPolicy();
            frm.Show();
        }

        private void toolStripMenuItem45_Click(object sender, EventArgs e)
        {
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            ManageBankPolicy frm = new ManageBankPolicy();
            frm.Show();
        }
    }
}
