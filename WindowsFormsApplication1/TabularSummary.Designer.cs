﻿namespace WindowsFormsApplication1
{
    partial class TabularSummary
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
            this.header1 = new WindowsFormsApplication1.Header();
            this.mainMenu1 = new WindowsFormsApplication1.MainMenu();
            this.label2 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(1363, 44);
            this.header1.TabIndex = 0;
            // 
            // mainMenu1
            // 
            this.mainMenu1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu1.Location = new System.Drawing.Point(0, 44);
            this.mainMenu1.Margin = new System.Windows.Forms.Padding(5);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(265, 774);
            this.mainMenu1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Provide Id";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(369, 211);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(100, 32);
            this.view.TabIndex = 24;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(449, 175);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "View Car Detail Info";
            // 
            // image
            // 
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.Location = new System.Drawing.Point(298, 271);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(251, 290);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 21;
            this.image.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(583, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 449);
            this.dataGridView1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 45);
            this.button1.TabIndex = 26;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TabularSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.view);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.header1);
            this.Name = "TabularSummary";
            this.Text = "TabularSummary";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Header header1;
        private MainMenu mainMenu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}