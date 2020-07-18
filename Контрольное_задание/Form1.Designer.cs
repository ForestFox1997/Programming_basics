namespace Многомерные_массивы
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
            this.КнопкаРандома = new System.Windows.Forms.Button();
            this.СеткаДанных = new System.Windows.Forms.DataGridView();
            this.РазмерМатрицы = new System.Windows.Forms.NumericUpDown();
            this.Название2 = new System.Windows.Forms.Label();
            this.Название4 = new System.Windows.Forms.Label();
            this.Название1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Тестирование = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.СеткаДанных)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.РазмерМатрицы)).BeginInit();
            this.SuspendLayout();
            // 
            // КнопкаРандома
            // 
            this.КнопкаРандома.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.КнопкаРандома.Location = new System.Drawing.Point(195, 367);
            this.КнопкаРандома.Name = "КнопкаРандома";
            this.КнопкаРандома.Size = new System.Drawing.Size(102, 49);
            this.КнопкаРандома.TabIndex = 5;
            this.КнопкаРандома.Text = "&Найти элемент";
            this.КнопкаРандома.UseVisualStyleBackColor = true;
            this.КнопкаРандома.Click += new System.EventHandler(this.button1_Click);
            // 
            // СеткаДанных
            // 
            this.СеткаДанных.AllowUserToAddRows = false;
            this.СеткаДанных.AllowUserToDeleteRows = false;
            this.СеткаДанных.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.СеткаДанных.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.СеткаДанных.ColumnHeadersVisible = false;
            this.СеткаДанных.Location = new System.Drawing.Point(12, 29);
            this.СеткаДанных.Name = "СеткаДанных";
            this.СеткаДанных.RowHeadersVisible = false;
            this.СеткаДанных.RowTemplate.Height = 24;
            this.СеткаДанных.Size = new System.Drawing.Size(1353, 320);
            this.СеткаДанных.TabIndex = 2;
            // 
            // РазмерМатрицы
            // 
            this.РазмерМатрицы.Location = new System.Drawing.Point(41, 385);
            this.РазмерМатрицы.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.РазмерМатрицы.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.РазмерМатрицы.Name = "РазмерМатрицы";
            this.РазмерМатрицы.Size = new System.Drawing.Size(120, 22);
            this.РазмерМатрицы.TabIndex = 4;
            this.РазмерМатрицы.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.РазмерМатрицы.ValueChanged += new System.EventHandler(this.Rows_NUD_ValueChanged);
            // 
            // Название2
            // 
            this.Название2.AutoSize = true;
            this.Название2.Location = new System.Drawing.Point(38, 365);
            this.Название2.Name = "Название2";
            this.Название2.Size = new System.Drawing.Size(119, 17);
            this.Название2.TabIndex = 3;
            this.Название2.Text = "&Размер матрицы";
            // 
            // Название4
            // 
            this.Название4.AutoSize = true;
            this.Название4.Location = new System.Drawing.Point(570, 374);
            this.Название4.Name = "Название4";
            this.Название4.Size = new System.Drawing.Size(351, 34);
            this.Название4.TabIndex = 7;
            this.Название4.Text = "&Отсортированная по убыванию строка, в которой \r\nнаходится наименьший элемент гла" +
    "вной диагонали\r\n";
            // 
            // Название1
            // 
            this.Название1.AutoSize = true;
            this.Название1.Location = new System.Drawing.Point(12, 9);
            this.Название1.Name = "Название1";
            this.Название1.Size = new System.Drawing.Size(66, 17);
            this.Название1.TabIndex = 1;
            this.Название1.Text = "&Матрица";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(337, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = " &Заполнить случайными числами";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Тестирование
            // 
            this.Тестирование.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Тестирование.Location = new System.Drawing.Point(936, 384);
            this.Тестирование.Name = "Тестирование";
            this.Тестирование.Size = new System.Drawing.Size(411, 22);
            this.Тестирование.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 431);
            this.Controls.Add(this.Тестирование);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Название1);
            this.Controls.Add(this.Название4);
            this.Controls.Add(this.Название2);
            this.Controls.Add(this.РазмерМатрицы);
            this.Controls.Add(this.СеткаДанных);
            this.Controls.Add(this.КнопкаРандома);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Вычислятель матрицы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.СеткаДанных)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.РазмерМатрицы)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button КнопкаРандома;
        private System.Windows.Forms.DataGridView СеткаДанных;
        private System.Windows.Forms.NumericUpDown РазмерМатрицы;
        private System.Windows.Forms.Label Название2;
        private System.Windows.Forms.Label Название4;
        private System.Windows.Forms.Label Название1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Тестирование;
    }
}

