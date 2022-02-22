using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int T = 100;
            progressBar1.Maximum = T;
            for (int i = 0; i < T; i++)
            {
                progressBar1.Value++;
            }
            if (progressBar1.Value == T)
            {
                PrintDialog p = new PrintDialog();
                p.ShowDialog();
                progressBar1.Value = 0;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
