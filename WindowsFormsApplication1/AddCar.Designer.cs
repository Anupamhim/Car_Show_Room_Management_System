namespace WindowsFormsApplication1
{
    partial class AddCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.empImage = new System.Windows.Forms.PictureBox();
            this.browser = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.engineNo = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.TextBox();
            this.dealerId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu1 = new WindowsFormsApplication1.MainMenu();
            this.header1 = new WindowsFormsApplication1.Header();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.empImage);
            this.panel2.Controls.Add(this.browser);
            this.panel2.Controls.Add(this.image);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.id);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.engineNo);
            this.panel2.Controls.Add(this.color);
            this.panel2.Controls.Add(this.model);
            this.panel2.Controls.Add(this.brand);
            this.panel2.Controls.Add(this.dealerId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(260, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 697);
            this.panel2.TabIndex = 5;
            // 
            // empImage
            // 
            this.empImage.Location = new System.Drawing.Point(540, 75);
            this.empImage.Name = "empImage";
            this.empImage.Size = new System.Drawing.Size(262, 267);
            this.empImage.TabIndex = 29;
            this.empImage.TabStop = false;
            // 
            // browser
            // 
            this.browser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.browser.ForeColor = System.Drawing.Color.White;
            this.browser.Location = new System.Drawing.Point(384, 323);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(75, 32);
            this.browser.TabIndex = 28;
            this.browser.Text = "Browser";
            this.browser.UseVisualStyleBackColor = false;
            this.browser.Click += new System.EventHandler(this.browser_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(171, 321);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(187, 25);
            this.image.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(46, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Image";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(171, 74);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(288, 25);
            this.id.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(39, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Car ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(384, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 23;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(171, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 22;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(170, 290);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(288, 25);
            this.price.TabIndex = 13;
            // 
            // engineNo
            // 
            this.engineNo.Location = new System.Drawing.Point(171, 253);
            this.engineNo.Name = "engineNo";
            this.engineNo.Size = new System.Drawing.Size(287, 25);
            this.engineNo.TabIndex = 12;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(171, 217);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(287, 25);
            this.color.TabIndex = 11;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(171, 182);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(288, 25);
            this.model.TabIndex = 10;
            // 
            // brand
            // 
            this.brand.Location = new System.Drawing.Point(171, 142);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(288, 25);
            this.brand.TabIndex = 9;
            // 
            // dealerId
            // 
            this.dealerId.Location = new System.Drawing.Point(171, 111);
            this.dealerId.Name = "dealerId";
            this.dealerId.Size = new System.Drawing.Size(288, 25);
            this.dealerId.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(42, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(39, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Engine no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(39, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(39, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dealer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Car details";
            // 
            // mainMenu1
            // 
            this.mainMenu1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu1.Location = new System.Drawing.Point(-1, 44);
            this.mainMenu1.Margin = new System.Windows.Forms.Padding(5);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(265, 774);
            this.mainMenu1.TabIndex = 1;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1363, 44);
            this.header1.TabIndex = 0;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.header1);
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Header header1;
        private MainMenu mainMenu1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox engineNo;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.TextBox dealerId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button browser;
        private System.Windows.Forms.TextBox image;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox empImage;
    }
}