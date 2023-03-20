namespace lab_altha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            readFile = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonVisualize = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Olive;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.SeaShell;
            button1.Image = Properties.Resources.Rectangle_2;
            button1.Location = new Point(762, 465);
            button1.Name = "button1";
            button1.Size = new Size(150, 41);
            button1.TabIndex = 0;
            button1.Text = "Search File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(403, 515);
            label1.Name = "label1";
            label1.Size = new Size(256, 30);
            label1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Bisque;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.DarkOliveGreen;
            textBox1.Location = new Point(403, 469);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 40);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 461);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // readFile
            // 
            readFile.AutoSize = true;
            readFile.Location = new Point(500, 500);
            readFile.Name = "readFile";
            readFile.Size = new Size(0, 15);
            readFile.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Treasure_Hunting;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(327, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(585, 253);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.logo_lbaltha;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(531, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 43);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // buttonVisualize
            // 
            buttonVisualize.BackColor = Color.Transparent;
            buttonVisualize.BackgroundImageLayout = ImageLayout.None;
            buttonVisualize.FlatAppearance.BorderSize = 0;
            buttonVisualize.FlatAppearance.MouseDownBackColor = Color.Olive;
            buttonVisualize.FlatStyle = FlatStyle.Flat;
            buttonVisualize.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVisualize.ForeColor = Color.SeaShell;
            buttonVisualize.Image = Properties.Resources.Rectangle_2;
            buttonVisualize.Location = new Point(601, 581);
            buttonVisualize.Name = "buttonVisualize";
            buttonVisualize.Size = new Size(150, 41);
            buttonVisualize.TabIndex = 8;
            buttonVisualize.Text = "NEXT";
            buttonVisualize.UseVisualStyleBackColor = false;
            buttonVisualize.Click += buttonVisualize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.MENU;
            ClientSize = new Size(1200, 700);
            Controls.Add(buttonVisualize);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(readFile);
            Name = "Form1";
            Text = "Treasure Hunting";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label readFile;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonVisualize;
    }
}