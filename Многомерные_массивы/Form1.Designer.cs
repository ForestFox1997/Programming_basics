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
            this.ЧислоСтрок = new System.Windows.Forms.NumericUpDown();
            this.ЧислоСтолбцов = new System.Windows.Forms.NumericUpDown();
            this.Название2 = new System.Windows.Forms.Label();
            this.Название3 = new System.Windows.Forms.Label();
            this.Результат1 = new System.Windows.Forms.TextBox();
            this.Название4 = new System.Windows.Forms.Label();
            this.Название1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.СеткаДанных)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЧислоСтрок)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЧислоСтолбцов)).BeginInit();
            this.SuspendLayout();
            // 
            // КнопкаРандома
            // 
            this.КнопкаРандома.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.КнопкаРандома.Location = new System.Drawing.Point(388, 299);
            this.КнопкаРандома.Name = "КнопкаРандома";
            this.КнопкаРандома.Size = new System.Drawing.Size(102, 49);
            this.КнопкаРандома.TabIndex = 7;
            this.КнопкаРандома.Text = "&Найти элемент";
            this.КнопкаРандома.UseVisualStyleBackColor = true;
            this.КнопкаРандома.Click += new System.EventHandler(this.button1_Click);
            // 
            // СеткаДанных
            // 
            this.СеткаДанных.AllowUserToAddRows = false;
            this.СеткаДанных.AllowUserToDeleteRows = false;
            this.СеткаДанных.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.СеткаДанных.ColumnHeadersVisible = false;
            this.СеткаДанных.Location = new System.Drawing.Point(12, 29);
            this.СеткаДанных.Name = "СеткаДанных";
            this.СеткаДанных.RowHeadersVisible = false;
            this.СеткаДанных.RowTemplate.Height = 24;
            this.СеткаДанных.Size = new System.Drawing.Size(1021, 250);
            this.СеткаДанных.TabIndex = 2;
            // 
            // ЧислоСтрок
            // 
            this.ЧислоСтрок.Location = new System.Drawing.Point(41, 319);
            this.ЧислоСтрок.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ЧислоСтрок.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ЧислоСтрок.Name = "ЧислоСтрок";
            this.ЧислоСтрок.Size = new System.Drawing.Size(120, 22);
            this.ЧислоСтрок.TabIndex = 4;
            this.ЧислоСтрок.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ЧислоСтрок.ValueChanged += new System.EventHandler(this.Rows_NUD_ValueChanged);
            // 
            // ЧислоСтолбцов
            // 
            this.ЧислоСтолбцов.Location = new System.Drawing.Point(209, 319);
            this.ЧислоСтолбцов.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ЧислоСтолбцов.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ЧислоСтолбцов.Name = "ЧислоСтолбцов";
            this.ЧислоСтолбцов.Size = new System.Drawing.Size(120, 22);
            this.ЧислоСтолбцов.TabIndex = 6;
            this.ЧислоСтолбцов.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ЧислоСтолбцов.ValueChanged += new System.EventHandler(this.Cols_NUD_ValueChanged);
            // 
            // Название2
            // 
            this.Название2.AutoSize = true;
            this.Название2.Location = new System.Drawing.Point(38, 299);
            this.Название2.Name = "Название2";
            this.Название2.Size = new System.Drawing.Size(127, 17);
            this.Название2.TabIndex = 3;
            this.Название2.Text = "Количество ст&рок";
            // 
            // Название3
            // 
            this.Название3.AutoSize = true;
            this.Название3.Location = new System.Drawing.Point(196, 299);
            this.Название3.Name = "Название3";
            this.Название3.Size = new System.Drawing.Size(151, 17);
            this.Название3.TabIndex = 5;
            this.Название3.Text = "Количество ст&олбцов";
            // 
            // Результат1
            // 
            this.Результат1.Location = new System.Drawing.Point(899, 312);
            this.Результат1.Name = "Результат1";
            this.Результат1.ReadOnly = true;
            this.Результат1.Size = new System.Drawing.Size(100, 22);
            this.Результат1.TabIndex = 10;
            // 
            // Название4
            // 
            this.Название4.AutoSize = true;
            this.Название4.Location = new System.Drawing.Point(669, 303);
            this.Название4.Name = "Название4";
            this.Название4.Size = new System.Drawing.Size(224, 34);
            this.Название4.TabIndex = 9;
            this.Название4.Text = "Наибольшее, среди наименьших\r\n   значений &чисел в строках";
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
            this.button1.Location = new System.Drawing.Point(527, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = " &Заполнить случайными числами";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Название1);
            this.Controls.Add(this.Название4);
            this.Controls.Add(this.Результат1);
            this.Controls.Add(this.Название3);
            this.Controls.Add(this.Название2);
            this.Controls.Add(this.ЧислоСтолбцов);
            this.Controls.Add(this.ЧислоСтрок);
            this.Controls.Add(this.СеткаДанных);
            this.Controls.Add(this.КнопкаРандома);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Вычислятель матрицы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.СеткаДанных)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЧислоСтрок)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЧислоСтолбцов)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button КнопкаРандома;
        private System.Windows.Forms.DataGridView СеткаДанных;
        private System.Windows.Forms.NumericUpDown ЧислоСтрок;
        private System.Windows.Forms.NumericUpDown ЧислоСтолбцов;
        private System.Windows.Forms.Label Название2;
        private System.Windows.Forms.Label Название3;
        private System.Windows.Forms.TextBox Результат1;
        private System.Windows.Forms.Label Название4;
        private System.Windows.Forms.Label Название1;
        private System.Windows.Forms.Button button1;
    }
}

