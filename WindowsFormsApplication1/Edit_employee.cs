using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Edit_employee : Form
    {
        string sourcePath;
        string destinationPath;
        public Edit_employee()
        {
            destinationPath = @"I:\varsity\C#\aaj+kerC#\Car-Showroom Management System15\Car-Showroom Management System3\Car-Showroom Management System\Images\EmployeeImage\";
            InitializeComponent();
        }
        MiddleLayer mL = new MiddleLayer();

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    sourcePath = dlg.FileName;
                }

            }

            if (!string.IsNullOrWhiteSpace(sourcePath) && File.Exists(sourcePath))
            {
                DirectoryInfo l_dDirInfo = new DirectoryInfo(destinationPath);
                if (l_dDirInfo.Exists == false)
                    Directory.CreateDirectory(destinationPath);
                destinationPath += Path.GetFileName(sourcePath);

                File.Move(sourcePath, destinationPath);
            }
            Image image = Image.FromFile(destinationPath);
            // Set the PictureBox image property to this image.
            // ... Then, adjust its height and width properties.
            //bankPolicyPicture.Image = image;
            //bankPolicyPicture.Height = image.Height;
            //bankPolicyPicture.Width = image.Width;
            this.image.Text = destinationPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mL.editEmp(this.id, this.fname, this.lname, this.email, this.joinDate, this.mobile, this.dateofBirth, this.address, this.salary, this.jobType, this.image);
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            ManageEmployees emp = new ManageEmployees();
            this.Close();
            emp.Show();
        }
    }
}
