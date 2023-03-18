using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_altha
{
    public partial class Form1 : Form
    {
        public bool fileAuthenticated { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            string proj = "bin";
            string dirFix = dir.Substring(0, dir.IndexOf(proj) - 1);


            string fileName = textBox1.Text;
            string textFile = dirFix + @"\tc\" + fileName;
            //label2.Text = textFile;
            

            if (File.Exists(textFile))
            {
                label1.Text = "File Found";
                fileAuthenticated = true;
                InputFile.fileName = textBox1.Text;
                

                
            }
            else
            {
                label1.Text = "File Not Found";
                fileAuthenticated = false;
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonVisualize_Click(object sender, EventArgs e)
        {
            if (fileAuthenticated)
            {
                this.Hide();
                var menuform = new menu();
                menuform.FormClosed += (s, args) => this.Close();
                menuform.Show();
                
            }
            else
            {
                MessageBox.Show("File is still not found. Cannot proceed");
            }

        }
    }
}