﻿using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab_altha
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            checkBox3 = new CheckBox();
            button3 = new Button();
            label13 = new Label();
            label14 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1.Font = new Font("Perpetua Titling MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Sienna;
            label1.Image = Properties.Resources.paper;
            label1.Location = new Point(72, 122);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 1;
            label1.Text = "File Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Sienna;
            label2.Font = new Font("Perpetua Titling MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Sienna;
            label2.Image = Properties.Resources.paper;
            label2.Location = new Point(67, 238);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 2;
            label2.Text = "Algorithm";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.bg;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Bisque;
            button1.Image = Properties.Resources.buttonBrown4;
            button1.Location = new Point(92, 190);
            button1.Name = "button1";
            button1.Size = new Size(95, 35);
            button1.TabIndex = 5;
            button1.Text = "VISUALIZE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Bisque;
            button2.Image = Properties.Resources.buttonBrown4;
            button2.Location = new Point(35, 31);
            button2.Name = "button2";
            button2.Size = new Size(90, 37);
            button2.TabIndex = 10;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SaddleBrown;
            label3.Image = Properties.Resources.bg;
            label3.Location = new Point(80, 160);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 14;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.OrangeRed;
            checkBox1.BackgroundImage = Properties.Resources.bg;
            checkBox1.FlatAppearance.CheckedBackColor = Color.Sienna;
            checkBox1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Sienna;
            checkBox1.Location = new Point(72, 264);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(53, 23);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "BFS";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackgroundImage = Properties.Resources.bg;
            checkBox2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.Sienna;
            checkBox2.Location = new Point(162, 264);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(56, 23);
            checkBox2.TabIndex = 16;
            checkBox2.Text = "DFS";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Sienna;
            label4.Image = Properties.Resources.bg;
            label4.Location = new Point(72, 160);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 17;
            label4.Text = InputFile.fileName;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Sienna;
            label5.Image = Properties.Resources.bg;
            label5.Location = new Point(485, 536);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 18;
            label5.Text = "Route";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Sienna;
            label6.Image = Properties.Resources.bg;
            label6.Location = new Point(55, 415);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 19;
            label6.Text = "Nodes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Sienna;
            label7.Image = Properties.Resources.bg;
            label7.Location = new Point(59, 483);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 20;
            label7.Text = "Steps";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Sienna;
            label8.Image = Properties.Resources.bg;
            label8.Location = new Point(52, 555);
            label8.Name = "label8";
            label8.Size = new Size(157, 20);
            label8.TabIndex = 21;
            label8.Text = "Execution Time";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Sienna;
            label9.Image = Properties.Resources.bgpanjang;
            label9.Location = new Point(513, 557);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Perpetua Titling MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Sienna;
            label10.Image = Properties.Resources.bg;
            label10.Location = new Point(67, 447);
            label10.Name = "label10";
            label10.Size = new Size(0, 17);
            label10.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Perpetua Titling MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Sienna;
            label11.Image = Properties.Resources.bg;
            label11.Location = new Point(67, 516);
            label11.Name = "label11";
            label11.Size = new Size(0, 17);
            label11.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Perpetua Titling MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Sienna;
            label12.Image = Properties.Resources.bg;
            label12.Location = new Point(67, 585);
            label12.Name = "label12";
            label12.Size = new Size(0, 17);
            label12.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 4;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(485, 130);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 250;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(450, 400);
            dataGridView1.TabIndex = 26;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.BackgroundImage = Properties.Resources.bg;
            checkBox3.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.ForeColor = Color.Sienna;
            checkBox3.Location = new Point(92, 293);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(88, 19);
            checkBox3.TabIndex = 27;
            checkBox3.Text = "With TSP";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.bg;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Bisque;
            button3.Image = Properties.Resources.buttonBrown4;
            button3.Location = new Point(90, 319);
            button3.Name = "button3";
            button3.Size = new Size(95, 36);
            button3.TabIndex = 28;
            button3.Text = "START";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Sienna;
            label13.Image = Properties.Resources.bgpanjang;
            label13.Location = new Point(514, 580);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Sienna;
            label14.Image = Properties.Resources.bgpanjang;
            label14.Location = new Point(526, 602);
            label14.Name = "label14";
            label14.Size = new Size(0, 15);
            label14.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SeaShell;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Sienna;
            textBox1.Location = new Point(526, 560);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(382, 42);
            textBox1.TabIndex = 32;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.UseWaitCursor = true;
            textBox1.WordWrap = false;
            // 
            // menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.MENU;
            ClientSize = new Size(1200, 700);
            Controls.Add(textBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(button3);
            Controls.Add(checkBox3);
            Controls.Add(dataGridView1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Treasure Hunting";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dataGridView1;
        private CheckBox checkBox3;
        private Button button3;
        private Label label13;
        private Label label14;
        private TextBox textBox1;
    }
}