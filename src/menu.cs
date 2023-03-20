using lab_altha.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_altha
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("You can't select both algorithm at the same time");

            }
            else if (checkBox1.Checked && !checkBox2.Checked)
            {
                if (!checkBox3.Checked)
                {
                    //BFS without TSP
                    char[,] temp = InputFile.toMatrix(label4.Text);
                    bfs Answer = bfs.BFS(temp);
                    (List<Tuple<int, int>> solutions, List<char> solutionsInChar, int steps, int nodes, long seconds) = (Answer.bfsPath, Answer.bfsDirection, Answer.bfsSteps, Answer.bfsNodes, Answer.bfsSeconds);
                    string result = string.Join("-", solutionsInChar);
                    label9.Text = result;
                    label10.Text = nodes.ToString();
                    label11.Text = steps.ToString();
                    label12.Text = seconds.ToString() + " ms";

                    //Get Row
                    int row = temp.GetLength(0);
                    //Get col
                    int col = temp.GetLength(1);

                    dataGridView1.ColumnCount = col;
                    dataGridView1.RowCount = row;



                    dataGridView1.Rows[0].Selected = false;
                    dataGridView1.GridColor = Color.Beige;

                    //dataGridView1.Rows[0].Height = 500;


                    for (int i = 0; i < row; i++)
                    {
                        /*DataGridViewRow rowN = new DataGridViewRow();
                        rowN.CreateCells(this.dataGridView1);
                        rowN.Height = 1000;*/




                        for (int j = 0; j < col; j++)
                        {
                            //rowN.Cells[j].Value = temp[i, j];
                            DataGridViewImageColumn img = new DataGridViewImageColumn();
                            if (temp[i, j] == 'X')

                            {
                                Image image = Properties.Resources.bg;
                                img.Image = image;

                                //Bitmap img = new Bitmap(Properties.Resources.paper_baru);


                                //rowN.Cells[j].Value = img;
                                dataGridView1.Rows[i].Cells[j].Value = "X";




                            }
                            else if (temp[i, j] == 'R' || temp[i, j] == 'K')
                            {
                                //dataGridView1.Rows[i].Cells[j].Value = "J";

                            }
                            else if (temp[i, j] == 'T')
                            {
                                dataGridView1.Rows[i].Cells[j].Value = "T";

                            }
                        }
                        //this.dataGridView1.Rows.Add(rowN);
                        dataGridView1.Rows[i].Height = (400 / row);

                    }
                    for (int i = 0; i < 7; i++)
                    {
                        int a = solutions[i].Item1;
                        int b = solutions[i].Item2;
                        for (int j = 0; j < col; j++)
                        {

                            if (a == i && b == j)
                            {
                                dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.DarkOliveGreen;
                                //rowN.Cells[j].Style.BackColor = Color.SkyBlue;
                            }
                        }
                    }
                } else
                {
                    //BSF with TSP
                }



            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                if (!checkBox3.Checked)
                {
                    //DFS without TSP
                    char[,] temp = InputFile.toMatrix(label4.Text);
                    dfs Answer = dfs.DFS(temp);
                    (List<Tuple<int, int>> solutions, List<char> solutionsInChar, int steps, int nodes, long seconds) = (Answer.dfsPath, Answer.dfsDirection, Answer.dfsSteps, Answer.dfsNodes, Answer.dfsSeconds);
                    string result = string.Join("-", solutionsInChar);
                    label9.Text = result;
                    label10.Text = nodes.ToString();
                    label11.Text = steps.ToString();
                    label12.Text = seconds.ToString() + " ms";
                }

            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("You haven't choose the algorithm");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainmenu = new Form1();
            mainmenu.FormClosed += (s, args) => this.Close();
            mainmenu.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}