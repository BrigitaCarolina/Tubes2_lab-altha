using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                //DFS
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