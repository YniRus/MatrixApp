using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixApp
{
    public partial class Form1 : Form
    {
        int N;

        public Form1()
        {
            InitializeComponent();
        }

        public void RandomFill()
        {
            Random Random = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    MatrixGrid.Rows[i].Cells[j].Value = Random.Next(1, 9);
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            N =  Convert.ToInt32(textBox1.Text);

            MatrixGrid.Columns.Clear();

            for (int i = 0; i < N; i++)
            {
                MatrixGrid.Columns.Add(Convert.ToString(i), Convert.ToString(i));
                MatrixGrid.Rows.Add();
            }

            RandomFill();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    MatrixGrid.Rows[i].Cells[j].Value = 0;
                }
            }
        }
    }
}
