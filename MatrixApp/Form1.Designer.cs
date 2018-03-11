namespace MatrixApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox = new System.Windows.Forms.TextBox();
            this.MatrixGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRandomFill = new System.Windows.Forms.Button();
            this.buttonCustomInput = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSetN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonFillZeros = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(165, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(119, 20);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // MatrixGrid
            // 
            this.MatrixGrid.AllowUserToAddRows = false;
            this.MatrixGrid.AllowUserToDeleteRows = false;
            this.MatrixGrid.AllowUserToResizeColumns = false;
            this.MatrixGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MatrixGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MatrixGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MatrixGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MatrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MatrixGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MatrixGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixGrid.Location = new System.Drawing.Point(0, 180);
            this.MatrixGrid.MultiSelect = false;
            this.MatrixGrid.Name = "MatrixGrid";
            this.MatrixGrid.RowHeadersVisible = false;
            this.MatrixGrid.RowHeadersWidth = 22;
            this.MatrixGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MatrixGrid.Size = new System.Drawing.Size(753, 343);
            this.MatrixGrid.TabIndex = 2;
            this.MatrixGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatrixGrid_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ШАГ 1. Выберите способ ввода";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLoadFromFile);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 112);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Загрузить из файла";
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonLoadFromFile.Location = new System.Drawing.Point(113, 43);
            this.buttonLoadFromFile.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(99, 28);
            this.buttonLoadFromFile.TabIndex = 2;
            this.buttonLoadFromFile.Text = "Выбрать файл";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.buttonRandomFill);
            this.groupBox3.Controls.Add(this.buttonCustomInput);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(353, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 112);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вручную";
            // 
            // buttonRandomFill
            // 
            this.buttonRandomFill.Enabled = false;
            this.buttonRandomFill.Location = new System.Drawing.Point(232, 63);
            this.buttonRandomFill.Name = "buttonRandomFill";
            this.buttonRandomFill.Size = new System.Drawing.Size(159, 26);
            this.buttonRandomFill.TabIndex = 2;
            this.buttonRandomFill.Text = "Случайно сгенерировать ";
            this.buttonRandomFill.UseVisualStyleBackColor = true;
            this.buttonRandomFill.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonCustomInput
            // 
            this.buttonCustomInput.Enabled = false;
            this.buttonCustomInput.Location = new System.Drawing.Point(12, 63);
            this.buttonCustomInput.Name = "buttonCustomInput";
            this.buttonCustomInput.Size = new System.Drawing.Size(167, 26);
            this.buttonCustomInput.TabIndex = 2;
            this.buttonCustomInput.Text = "Ввести значения";
            this.buttonCustomInput.UseVisualStyleBackColor = true;
            this.buttonCustomInput.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.buttonSetN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 20);
            this.panel1.TabIndex = 4;
            // 
            // buttonSetN
            // 
            this.buttonSetN.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSetN.Location = new System.Drawing.Point(284, 0);
            this.buttonSetN.Name = "buttonSetN";
            this.buttonSetN.Size = new System.Drawing.Size(107, 20);
            this.buttonSetN.TabIndex = 2;
            this.buttonSetN.Text = "Применить";
            this.buttonSetN.UseVisualStyleBackColor = true;
            this.buttonSetN.Click += new System.EventHandler(this.buttonSetN_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите порядок матрицы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonFillZeros);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(753, 49);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ШАГ 2. Выполнить действие";
            // 
            // buttonFillZeros
            // 
            this.buttonFillZeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonFillZeros.Enabled = false;
            this.buttonFillZeros.Location = new System.Drawing.Point(235, 16);
            this.buttonFillZeros.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFillZeros.Name = "buttonFillZeros";
            this.buttonFillZeros.Size = new System.Drawing.Size(297, 30);
            this.buttonFillZeros.TabIndex = 2;
            this.buttonFillZeros.Text = "Выполнить обнуление";
            this.buttonFillZeros.UseVisualStyleBackColor = true;
            this.buttonFillZeros.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonSaveToFile);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 523);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(753, 53);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ШАГ 3. Вывести результат в файл (опционально)";
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSaveToFile.Enabled = false;
            this.buttonSaveToFile.Location = new System.Drawing.Point(235, 23);
            this.buttonSaveToFile.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(297, 27);
            this.buttonSaveToFile.TabIndex = 2;
            this.buttonSaveToFile.Text = "Сохранить в файл";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.button6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Файл INPUT|*.in";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Файл OUTPUT|*.out";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(753, 576);
            this.Controls.Add(this.MatrixGrid);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MatrixGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DataGridView MatrixGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Button buttonRandomFill;
        private System.Windows.Forms.Button buttonCustomInput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonFillZeros;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSetN;
    }
}

