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
        int N = 0;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

        }

        public void CreateMatrixGrid()
        {
            //--Создание исходной матрицы

            //Очищаем старую
            MatrixGrid.Columns.Clear();

            //Создаем новую
            for (int i = 0; i < N; i++)
            {
                MatrixGrid.Columns.Add(Convert.ToString(i), Convert.ToString(i));
                MatrixGrid.Rows.Add();
            }

            //Заполняем нулями
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    MatrixGrid.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        public void CreateMatrixResultGrid()
        {
            //--Создание результирующей матрицы

            MatrixResultGrid.Columns.Clear();

            for (int i = 0; i < N; i++)
            {
                MatrixResultGrid.Columns.Add(Convert.ToString(i), Convert.ToString(i));
                MatrixResultGrid.Rows.Add();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    MatrixResultGrid.Rows[i].Cells[j].Value = MatrixGrid.Rows[i].Cells[j].Value;
                }
            }
        }

        public void RandomFill()
        {
            //--Заполнение матрицы случайными значениями

            Random Random = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    MatrixGrid.Rows[i].Cells[j].Value = Random.Next(Int32.MinValue, Int32.MaxValue);
                }
            }
        }

        public void FillZeros()
        {
            //-- Заполение ниже главной диагонали нулями

            //Перед этим создаем результирующую матрицу
            CreateMatrixResultGrid();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    MatrixResultGrid.Rows[i].Cells[j].Value = 0;
                }
            }
        }

        public void TryN(string Value, bool ShowMessage)
        {
            try
            {
                //Проверка на соответствие формату числа Int32
                N = Convert.ToInt32(Value);

                //Проверка на соответствие границам ОДЗ
                if (N > 50 || N < 2)
                {
                    if(ShowMessage)
                        MessageBox.Show("Недопустимый порядок матрицы. Допустимый порядок [2,50]", "Ошибка!");

                    N = 0;
                    textBox.Text = "";
                }
                else
                {
                    buttonCustomInput.Enabled = true;
                    buttonRandomFill.Enabled = true;

                    textBox.Text = Convert.ToString(N);
                }
            }
            catch (Exception ex)
            {
                if (ShowMessage)
                {
                    if (Value == "")
                        MessageBox.Show("Пустое поле порядка матрицы", "Ошибка!");
                    else
                        MessageBox.Show(ex.Message, "Ошибка!");
                }

                textBox.Text = "";
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                using (StreamReader StreamReader = File.OpenText(openFileDialog1.FileName))
                {
                    int LineIndex = 0;  //Номер линии в файле
                    int i = 0;

                    bool Break = false;

                    MatrixGrid.Columns.Clear();

                    while (!StreamReader.EndOfStream)
                    {
                        var Line = StreamReader.ReadLine(); 
                        string[] Values = Line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (LineIndex == 0) //Первая строка - порядок матрицы
                        {
                            if(Values.Length != 1)
                            {
                                MessageBox.Show("Входной файл имеет неверную структуру данных");
                                MatrixGrid.Columns.Clear();
                                Break = true;
                                break;
                            } 
                            else
                            {
                                //Проверка значения N на корректность
                                TryN(Values[0],false);

                                //Если проверка прошла то N != 0
                                if (N != 0)
                                    for (int k = 0; k < N; k++)
                                    {
                                        MatrixGrid.Columns.Add(Convert.ToString(k), Convert.ToString(k));
                                        MatrixGrid.Rows.Add();
                                    }
                                else
                                {
                                    MessageBox.Show("Входная строка имела недопустимые значения");
                                    Break = true;
                                    break;
                                }
                                    

                            }
                        }
                        else
                        {
                            if (Values.Length != N) //В строке должно быть N чисел
                            {
                                MessageBox.Show("Входной файл имеет неверную структуру данных");
                                MatrixGrid.Columns.Clear();
                                Break = true;
                                break;
                            }
                            else
                            {
                                try
                                {
                                    for (int j = 0; j < Values.Length; j++)
                                    {
                                        //Проверка на соответствие формату числа Int32 и на соответствие границам ОДЗ
                                        Convert.ToInt32(Values[j]);

                                        MatrixGrid.Rows[i].Cells[j].Value = Values[j];
                                    }

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Входная строка имела недопустимые значения");
                                    MatrixGrid.Columns.Clear();
                                    Break = true;
                                    break;
                                }

                                i++;
                            }
                        }

                        LineIndex++;
                    }

                    if(LineIndex - 1 != MatrixGrid.RowCount && !Break)
                    {
                        MessageBox.Show("Входной файл имеет неверную структуру данных");
                        MatrixGrid.Columns.Clear();
                    }
                }

                buttonFillZeros.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TryN(textBox.Text,true);

            if (N != 0)
            {
                CreateMatrixGrid();
                RandomFill();
                buttonFillZeros.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TryN(textBox.Text, true);

            if (N != 0)
            {
                CreateMatrixGrid();
                buttonFillZeros.Enabled = true;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            FillZeros();

            buttonSaveToFile.Enabled = true;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            try
            {
                using (StreamWriter StreamWriter = new StreamWriter(saveFileDialog1.FileName))
                {

                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            StreamWriter.Write(MatrixResultGrid.Rows[i].Cells[j].Value);

                            if (j != N - 1)
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

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            buttonFillZeros.Enabled = false;
            buttonSaveToFile.Enabled = false;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Проверка на вводимые символы
             * Только цифры от 0 до 9
             * Клавиша Backspase
             */
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //калькулятор
            {
                e.Handled = true;
            }
        }

        private void buttonSetN_Click(object sender, EventArgs e)
        {
            TryN(textBox.Text,true);
        }

        private void MatrixGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //Проверка на соответствие формату числа Int32 и на соответствие границам ОДЗ
                MatrixGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToInt32(MatrixGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Входная строка имела недопустимые значения");

                MatrixGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;

            }
        }
    }
}
