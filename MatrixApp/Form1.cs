using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

        }

        public void CreateMatrixGrid()
        {
            MatrixGrid.Columns.Clear();

            N = Convert.ToInt32(textBox1.Text);

            for (int k = 0; k < N; k++)
            {
                MatrixGrid.Columns.Add(Convert.ToString(k), Convert.ToString(k));
                MatrixGrid.Rows.Add();
            }
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

        public void FillZeros()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    MatrixGrid.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                using (StreamReader StreamReader = File.OpenText(openFileDialog1.FileName))
                {
                    int i = 0;
                    N = 0;
                    MatrixGrid.Columns.Clear();

                    while (!StreamReader.EndOfStream)
                    {
                        var Line = StreamReader.ReadLine();
                        string[] Values = Line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if(Values.Length == 1 && N == 0)
                        {
                            N = Convert.ToInt32(Values[0]);

                            for (int k = 0; k < N; k++)
                            {
                                MatrixGrid.Columns.Add(Convert.ToString(k), Convert.ToString(k));
                                MatrixGrid.Rows.Add();
                            }
                        } else
                        {
                            for (int j = 0; j < Values.Length; j++)
                            {
                                MatrixGrid.Rows[i].Cells[j].Value = Values[j];
                            }

                            i++;
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateMatrixGrid();
            RandomFill();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateMatrixGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FillZeros();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            try
            { 
                using (StreamWriter StreamWriter = new StreamWriter(saveFileDialog1.FileName))
                {

                    for(int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            StreamWriter.Write(MatrixGrid.Rows[i].Cells[j].Value);

                            if(j != N - 1)
                            {
                                StreamWriter.Write(' ');
                            }
                        }
                        StreamWriter.WriteLine();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not write file to disk. Original error: " + ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
