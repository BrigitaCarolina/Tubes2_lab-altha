﻿namespace lab_altha
{
    partial class menu
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.paper_baru1;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(35, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 287);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Sienna;
            label1.Image = Properties.Resources.paper;
            label1.Location = new Point(72, 129);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 1;
            label1.Text = "File Name: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Sienna;
            label2.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Sienna;
            label2.Image = Properties.Resources.paper;
            label2.Location = new Point(72, 205);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 2;
            label2.Text = "Algorithm";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.BackgroundImage = Properties.Resources.bg;
            radioButton1.BackgroundImageLayout = ImageLayout.None;
            radioButton1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.Sienna;
            radioButton1.Location = new Point(81, 249);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 23);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "BFS";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.BackgroundImage = Properties.Resources.bg;
            radioButton2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.Sienna;
            radioButton2.Location = new Point(163, 249);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(58, 23);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "DFS";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Bisque;
            button1.Location = new Point(72, 305);
            button1.Name = "button1";
            button1.Size = new Size(140, 30);
            button1.TabIndex = 5;
            button1.Text = "Visualize";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Sienna;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Bisque;
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.Location = new Point(35, 35);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.TabIndex = 10;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.paper_baru1;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(27, 381);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(234, 288);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.bg_maze1;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Location = new Point(300, 88);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(869, 581);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.logo_lbaltha;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Location = new Point(1021, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(148, 50);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.MENU;
            ClientSize = new Size(1200, 700);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "menu";
            Text = "Treasure Hunting";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}