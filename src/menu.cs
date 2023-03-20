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
                //BFS
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

                //DataGridViewImageColumn img = new DataGridViewImageColumn();


                //dataGridView1.Rows[0].Selected = false;

                for (int i = 0; i < row; i++)
                {
                    DataGridViewRow rowN = new DataGridViewRow();
                    rowN.CreateCells(this.dataGridView1);
                    rowN.Height = 1000;

                    for (int j = 0; j < col; j++)
                    {
                        //rowN.Cells[j].Value = temp[i, j];
                        if (temp[i, j] == 'X')

                        {
                            Bitmap img = new Bitmap(Properties.Resources.paper_baru);
                           

                            //rowN.Cells[j].Value = img;
                            //Image image = Properties.Resources.bg;
                            //img.Image = image;
                            rowN.Cells[j].Value =img;




                        }
                        else if (temp[i, j] == 'R' || temp[i, j] == 'K')
                        {
                            rowN.Cells[j].Value = "Jalan";

                        }
                        else if (temp[i, j] == 'T')
                        {
                            rowN.Cells[j].Value = "Treasure";

                        }
                    }
                    this.dataGridView1.Rows.Add(rowN);
                }
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        DataGridViewRow rowN = new DataGridViewRow();
                        rowN.CreateCells(this.dataGridView1);
                        if (solutions[i].Item1 == i && solutions[j].Item2 == j)
                        {
                            //dataGridView1.Rows[i].Columns[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                            rowN.Cells[j].Style.BackColor = Color.SkyBlue;
                        }
                    }
                }



            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                //DFS
                char[,] temp = InputFile.toMatrix(label4.Text);
                dfs Answer = dfs.DFS(temp);
                (List<Tuple<int, int>> solutions, List<char> solutionsInChar, int steps, int nodes, long seconds) = (Answer.dfsPath, Answer.dfsDirection, Answer.dfsSteps, Answer.dfsNodes, Answer.dfsSeconds);
                string result = string.Join("-", solutionsInChar);
                label9.Text = result;
                label10.Text = nodes.ToString();
                label11.Text = steps.ToString();
                label12.Text = seconds.ToString() + " ms";

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


    }
}