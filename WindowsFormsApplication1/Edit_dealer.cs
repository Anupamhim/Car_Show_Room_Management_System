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
    public partial class Edit_dealer : Form
    {
        string sourcePath;
        string destinationPath;
        public Edit_dealer()
        {
            destinationPath = @"I:\varsity\C#\aaj+kerC#\Car-Showroom Management System15\Car-Showroom Management System3\Car-Showroom Management System\Images\DealerImage\";
            InitializeComponent();
        }
        MiddleLayer ml = new MiddleLayer();

        private void button2_Click(object sender, EventArgs e)
        {
            ml.editDealer(this.id, this.fname, this.lname, this.email, this.mobile, this.address, this.brand, this.company, this.dealerImage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageDealers dBoard = new ManageDealers();
            this.Close();
            dBoard.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

            this.dealerImage.Text = destinationPath;
        }
    }
}
