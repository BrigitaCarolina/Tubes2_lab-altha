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
        public bool proceed { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            //label2.Text = dir;
            try
            {
                string proj = "bin";
                string dirFix = dir.Substring(0, dir.IndexOf(proj) - 1);
                Console.WriteLine(dirFix);

                string fileName = textBox1.Text;
                //string textFile = dirFix + @"\tc\" + fileName;
                string textFile = dirFix + @"\test\" + fileName;
                //label2.Text = textFile;


                if (File.Exists(textFile))
                {

                    label1.Text = "File Found";


                    InputFile.fileName = textBox1.Text;
                    string[] lines = File.ReadAllLines(textFile);
                    int row = lines.Length;
                    int count = 0;
                    List<int> countEach = new List<int>();
                    int countEachLine = 0;
                    List<String> readMat = new List<String>();
                    if (row == 0)
                    {
                        MessageBox.Show("File is Empty :(", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {

                        string firstText = lines[0];

                        string[] text = firstText.Split(" ");
                        int col = text.Length;


                        foreach (string line in lines)
                        {
                            string[] words = line.Split(" ");
                            countEachLine = words.Length;
                            countEach.Add(countEachLine);
                            readMat.AddRange(words);
                            count++;
                        }


                        int foundK = 0;
                        int foundT = 0;
                        int found = 0;
                        foreach (string line in readMat)
                        {
                            if (line == "R" || line == "X")
                            {
                                found++;
                            }
                            else if (line == "K")
                            {
                                foundK++;
                            }
                            else if (line == "T")
                            {
                                foundT++;
                            }
                        }


                        var countAll = countEach.Distinct();
                        if (countAll.Count() > 1)
                        {
                            MessageBox.Show("There's a wrong format line ", "Warning", MessageBoxButtons.OK);
                            proceed = false;

                        }
                        else if (found + foundK + foundT != row * col)
                        {
                            proceed = false;
                            MessageBox.Show("Please correct your formating to only K, R, X, T", "Warning", MessageBoxButtons.OK);
                        }
                        else if (foundK == 0)
                        {
                            proceed = false;
                            MessageBox.Show("There is no starting point in your file format", "Warning", MessageBoxButtons.OK);
                        }
                        else if (foundK > 1)
                        {
                            proceed = false;
                            MessageBox.Show("There is more than one starting point in your file format", "Warning", MessageBoxButtons.OK);
                        }
                        else if (foundT == 0)
                        {
                            proceed = false;
                            MessageBox.Show("There is no treasure in your file format", "Warning");
                        }
                        else
                        {
                            proceed = true;
                        }


                    }
                }
                else
                {
                    label1.Text = "File Not Found";
                    fileAuthenticated = false;

                }
                if (proceed)
                {
                    fileAuthenticated = true;
                }
            }
            catch (Exception t)
            {
                MessageBox.Show(t.ToString());
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
                if (proceed)
                {
                    this.Hide();
                    var menuform = new menu();
                    menuform.FormClosed += (s, args) => this.Close();
                    menuform.Show();
                }
                else
                {
                    MessageBox.Show("File format is still wrong. Cannot proceed");
                }
            }
            else if (!fileAuthenticated)
            {
                MessageBox.Show("File is still not found. Cannot proceed");
            }


        }
    }
}