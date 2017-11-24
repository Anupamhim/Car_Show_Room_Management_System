using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class AddCar : Form
    {
        string sourcePath;
        string destinationPath;
        public AddCar()
        {
            destinationPath = @"I:\varsity\C#\aaj+kerC#\Car-Showroom Management System15\Car-Showroom Management System3\Car-Showroom Management System\Images\EmployeeImage\";
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();

        private void button2_Click(object sender, EventArgs e)
        {
            ml.addCar(this.id, this.dealerId, this.brand, this.model, this.color, this.engineNo, this.price,this.image);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashBoard dBoard = new DashBoard();
            this.Close();
            dBoard.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void browser_Click(object sender, EventArgs e)
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
            empImage.Image = image;
            empImage.Height = image.Height;
            empImage.Width = image.Width;
            this.image.Text = destinationPath;
        }
    }
}
