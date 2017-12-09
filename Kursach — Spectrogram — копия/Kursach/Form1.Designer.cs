namespace Kursach
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
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cmBoxWindowFunc = new System.Windows.Forms.ComboBox();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.btShowSpectr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmBoxNumberOfCounts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBFileName = new System.Windows.Forms.TextBox();
            this.tBFilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            this.SuspendLayout();
            // 
            // myChart
            // 
            this.myChart.Location = new System.Drawing.Point(12, 47);
            this.myChart.Name = "myChart";
            this.myChart.Size = new System.Drawing.Size(994, 396);
            this.myChart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оконная функция";
            // 
            // cmBoxWindowFunc
            // 
            this.cmBoxWindowFunc.FormattingEnabled = true;
            this.cmBoxWindowFunc.Items.AddRange(new object[] {
            "Прямоугольное окно",
            "Гаусса",
            "Хемминга ",
            "Ханна",
            "Блэкмана — Харриса"});
            this.cmBoxWindowFunc.Location = new System.Drawing.Point(18, 479);
            this.cmBoxWindowFunc.Name = "cmBoxWindowFunc";
            this.cmBoxWindowFunc.Size = new System.Drawing.Size(121, 24);
            this.cmBoxWindowFunc.TabIndex = 2;
            this.cmBoxWindowFunc.Text = "Не выбрано";
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(1024, 47);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(107, 45);
            this.btOpenFile.TabIndex = 3;
            this.btOpenFile.Text = "Обзор...";
            this.btOpenFile.UseVisualStyleBackColor = true;
            // 
            // btShowSpectr
            // 
            this.btShowSpectr.Location = new System.Drawing.Point(1024, 107);
            this.btShowSpectr.Name = "btShowSpectr";
            this.btShowSpectr.Size = new System.Drawing.Size(107, 45);
            this.btShowSpectr.TabIndex = 4;
            this.btShowSpectr.Text = "Показать спектр";
            this.btShowSpectr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество отcчётов";
            // 
            // cmBoxNumberOfCounts
            // 
            this.cmBoxNumberOfCounts.FormattingEnabled = true;
            this.cmBoxNumberOfCounts.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192",
            "16384",
            "32768",
            "65536",
            "131072",
            "262144",
            "524288",
            "Длинна записи"});
            this.cmBoxNumberOfCounts.Location = new System.Drawing.Point(165, 479);
            this.cmBoxNumberOfCounts.Name = "cmBoxNumberOfCounts";
            this.cmBoxNumberOfCounts.Size = new System.Drawing.Size(140, 24);
            this.cmBoxNumberOfCounts.TabIndex = 6;
            this.cmBoxNumberOfCounts.Text = "Не выбрано";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Файл:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Путь к файлу:";
            // 
            // tBFileName
            // 
            this.tBFileName.Location = new System.Drawing.Point(67, 6);
            this.tBFileName.Name = "tBFileName";
            this.tBFileName.ReadOnly = true;
            this.tBFileName.Size = new System.Drawing.Size(238, 22);
            this.tBFileName.TabIndex = 9;
            // 
            // tBFilePath
            // 
            this.tBFilePath.Location = new System.Drawing.Point(450, 6);
            this.tBFilePath.Name = "tBFilePath";
            this.tBFilePath.ReadOnly = true;
            this.tBFilePath.Size = new System.Drawing.Size(556, 22);
            this.tBFilePath.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 525);
            this.Controls.Add(this.tBFilePath);
            this.Controls.Add(this.tBFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmBoxNumberOfCounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btShowSpectr);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.cmBoxWindowFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBoxWindowFunc;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Button btShowSpectr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmBoxNumberOfCounts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBFileName;
        private System.Windows.Forms.TextBox tBFilePath;
    }
}

