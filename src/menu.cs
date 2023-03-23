using lab_altha.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace lab_altha
{

    public partial class menu : Form
    {
        public int getRow { get; private set; }
        public int getCol { get; private set; }
        //public char[,] temp { get; private set; }
        public menu()
        {
            InitializeComponent();
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            char[,] temp = InputFile.toMatrix(label4.Text);
            //Get Row
            getRow = temp.GetLength(0);
            //Get col
            getCol = temp.GetLength(1);
            dataGridView1.ColumnCount = getCol;
            dataGridView1.RowCount = getRow;
            dataGridView1.Rows[0].Selected = false;
            dataGridView1.GridColor = Color.Beige;


            for (int i = 0; i < getRow; i++)
            {

                for (int j = 0; j < getCol; j++)
                {

                    if (temp[i, j] == 'X')

                    {


                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Wheat;
                    }
                    else if (temp[i, j] == 'R')
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.White;
                        dataGridView1.Rows[i].Cells[j].Value = "J";

                    }
                    else if (temp[i, j] == 'K')
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Beige;
                        dataGridView1.Rows[i].Cells[j].Value = "K";
                    }
                    else if (temp[i, j] == 'T')
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Gold;
                        dataGridView1.Rows[i].Cells[j].Value = "T";

                    }
                }
                //this.dataGridView1.Rows.Add(rowN);
                dataGridView1.Rows[i].Height = (400 / getRow);

            }
            button3.Enabled = true;
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {

            char[,] temp = InputFile.toMatrix(label4.Text);

            bfs AnswerBFS = bfs.BFS(temp);
            (List<Tuple<int, int>> solutionsBFS, List<char> solutionsInCharBFS, int stepsBFS, int nodesBFS, long secondsBFS) = (AnswerBFS.bfsPath, AnswerBFS.bfsDirection, AnswerBFS.bfsSteps, AnswerBFS.bfsNodes, AnswerBFS.bfsSeconds);

            bfs AnswerBFS2 = bfs.TSPWithBFS(temp, solutionsBFS[solutionsBFS.Count - 1]);
            (List<Tuple<int, int>> solutions2, List<char> solutionsInChar2, int steps2, int nodes2, long seconds2) = (AnswerBFS2.bfsPath, AnswerBFS2.bfsDirection, AnswerBFS2.bfsSteps, AnswerBFS2.bfsNodes, AnswerBFS2.bfsSeconds);

            dfs AnswerDFS = dfs.DFS(temp);
            (List<Tuple<int, int>> solutionsDFS, List<char> solutionsInCharDFS, int stepsDFS, int nodesDFS, long secondsDFS) = (AnswerDFS.dfsPath, AnswerDFS.dfsDirection, AnswerDFS.dfsSteps, AnswerDFS.dfsNodes, AnswerDFS.dfsSeconds);

            dfs AnswerDFS2 = dfs.TSPwithDFS(temp, solutionsDFS[solutionsDFS.Count - 1]);
            (List<Tuple<int, int>> solutionsDFS2, List<char> solutionsInCharDFS2, int stepsDFS2, int nodesDFS2, long secondsDFS2) = (AnswerDFS2.dfsPath, AnswerDFS2.dfsDirection, AnswerDFS2.dfsSteps, AnswerDFS2.dfsNodes, AnswerDFS2.dfsSeconds);

            if (checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("You can't select both algorithm at the same time");

            }
            else if (checkBox1.Checked && !checkBox2.Checked)
            {
                if (!checkBox3.Checked)
                {
                    //BFS without TSP
                    resetdisplay();
                    await Task.Delay(300);
                    displayResult(solutionsBFS, solutionsInCharBFS, stepsBFS, nodesBFS, secondsBFS);
                }
                else
                {
                    //BSF with TSP
                    resetdisplay();
                    await Task.Delay(300);
                    long secondsTSP = secondsBFS + seconds2;
                    displayResult(solutions2, solutionsInChar2, steps2, nodes2, secondsTSP);

                }

            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                if (!checkBox3.Checked)
                {
                    //DFS without TSP
                    resetdisplay();
                    await Task.Delay(300);
                    displayResult(solutionsDFS, solutionsInCharDFS, stepsDFS, nodesDFS, secondsDFS);

                }
                else
                {
                    //DFS with TSP
                    resetdisplay();
                    await Task.Delay(300);
                    displayResult(solutionsDFS2, solutionsInCharDFS2, stepsDFS2, nodesDFS2, secondsDFS2);
                }

            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("You haven't choose the algorithm");
            }

        }

        private void changeColor(int i, int j, int k)
        {
            Color[] listColor = new Color[6] { Color.DarkSeaGreen, Color.MediumSeaGreen, Color.ForestGreen, Color.OliveDrab, Color.DarkOliveGreen, Color.DarkGreen };



            dataGridView1.Rows[i].Cells[j].Style.ForeColor = listColor[k];
            //Color DarkOliveGreen = Color.FromArgb(100, Color.DarkOliveGreen);
            dataGridView1.Rows[i].Cells[j].Style.BackColor = listColor[k];

        }


        private async void displayResult(List<Tuple<int, int>> solutions, List<char> solutionsInChar, int steps, int nodes, long seconds)
        {
            button3.Enabled = false;
            button1.Enabled = false;
            string result = string.Join("", solutionsInChar);
            //label9.Text = result;
            textBox1.Text = result;
            //int len = result.Length;

            /*if (result.Length > 50 && result.Length < 70)
            {
                string a = result.Substring(0, 30);
                string b = result.Substring(31);
                label9.Text = a;
                label13.Text = b;
            }
            else if (result.Length > 70 && result.Length < 100)
            {
                string a = result.Substring(0, 30);
                string b = result.Substring(31, 60);
                string c = result.Substring(61);
                label9.Text = a;
                label13.Text = b;
                label14.Text = c;
            }
            else
            {
                label9.Text = result;
            }
            label9.Text = result;*/
            label10.Text = nodes.ToString();
            label11.Text = steps.ToString();
            label12.Text = seconds.ToString() + " ms";

            int[,] visited = new int[getRow, getCol];

            for (int i = 0; i < getRow; i++)
            {
                for (int j = 0; j < getCol; j++)
                {
                    visited[i, j] = 0;
                }
            }

            char[,] getTreasure = new char[getRow, getCol];
            for (int i = 0; i < getRow; i++)
            {
                for (int j = 0; j < getCol; j++)
                {
                    getTreasure[i, j] = '0';
                }
            }

            int carry = 1;


            for (int k = 0; k < solutions.Count(); k++)
            {
                int a = solutions[k].Item1;
                int b = solutions[k].Item2;
                //Stopwatch timer = new Stopwatch();
                for (int i = 0; i < getRow; i++)
                {
                    for (int j = 0; j < getCol; j++)
                    {
                        if (i == a && j == b)
                        {


                            if (visited[i, j] >= 0 && visited[i, j] < 7)
                            {
                                changeColor(i, j, visited[i, j]);
                                await Task.Delay(400);
                                visited[i, j] += carry;
                                if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "T" && getTreasure[i, j] == '0')
                                {
                                    MessageBox.Show("Treasure Found!", "Important Message");
                                    getTreasure[i, j] = '1';
                                    //dataGridView1.Rows[i].Cells[j].Value = "R";
                                }
                            }
                            else
                            {
                                changeColor(i, j, visited[i, j]);
                                await Task.Delay(400);
                                visited[i, j] = 0;
                            }

                        }

                    }
                }

            }
            MessageBox.Show("Finished!", "Important Message");
            await Task.Delay(200);
            button3.Enabled = true;
            button1.Enabled = true;

        }

        private async void resetdisplay()
        {
            for (int i = 0; i < getRow; i++)
            {
                for (int j = 0; j < getCol; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)

                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Wheat;
                    }
                    else if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "J")
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.White;
                        dataGridView1.Rows[i].Cells[j].Value = "J";

                    }
                    else if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "K")
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Beige;
                        dataGridView1.Rows[i].Cells[j].Value = "K";
                    }
                    else if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "T")
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Gold;
                        dataGridView1.Rows[i].Cells[j].Value = "T";

                    }

                }

            }
            await Task.Delay(100);
        }


    }


}

