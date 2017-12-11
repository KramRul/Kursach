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
            this.label5 = new System.Windows.Forms.Label();
            this.cmBoxHarmonic = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBFreqOne = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBFreqTwo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tBFreqThree = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBFreqFour = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tBFreqFive = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmBoxScale = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
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
            this.btOpenFile.Size = new System.Drawing.Size(184, 45);
            this.btOpenFile.TabIndex = 3;
            this.btOpenFile.Text = "Обзор...";
            this.btOpenFile.UseVisualStyleBackColor = true;
            // 
            // btShowSpectr
            // 
            this.btShowSpectr.Location = new System.Drawing.Point(1024, 107);
            this.btShowSpectr.Name = "btShowSpectr";
            this.btShowSpectr.Size = new System.Drawing.Size(184, 45);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1052, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Гармоника";
            // 
            // cmBoxHarmonic
            // 
            this.cmBoxHarmonic.FormattingEnabled = true;
            this.cmBoxHarmonic.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10",
            "15"});
            this.cmBoxHarmonic.Location = new System.Drawing.Point(1138, 158);
            this.cmBoxHarmonic.Name = "cmBoxHarmonic";
            this.cmBoxHarmonic.Size = new System.Drawing.Size(52, 24);
            this.cmBoxHarmonic.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1021, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Частота первого спектра";
            // 
            // tBFreqOne
            // 
            this.tBFreqOne.Location = new System.Drawing.Point(1065, 218);
            this.tBFreqOne.Name = "tBFreqOne";
            this.tBFreqOne.ReadOnly = true;
            this.tBFreqOne.Size = new System.Drawing.Size(100, 22);
            this.tBFreqOne.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1171, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Гц";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1172, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Гц";
            // 
            // tBFreqTwo
            // 
            this.tBFreqTwo.Location = new System.Drawing.Point(1066, 263);
            this.tBFreqTwo.Name = "tBFreqTwo";
            this.tBFreqTwo.ReadOnly = true;
            this.tBFreqTwo.Size = new System.Drawing.Size(100, 22);
            this.tBFreqTwo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1022, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Частота второго спектра";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1172, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Гц";
            // 
            // tBFreqThree
            // 
            this.tBFreqThree.Location = new System.Drawing.Point(1066, 308);
            this.tBFreqThree.Name = "tBFreqThree";
            this.tBFreqThree.ReadOnly = true;
            this.tBFreqThree.Size = new System.Drawing.Size(100, 22);
            this.tBFreqThree.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1022, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Частота третьего спектра";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1171, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Гц";
            // 
            // tBFreqFour
            // 
            this.tBFreqFour.Location = new System.Drawing.Point(1065, 353);
            this.tBFreqFour.Name = "tBFreqFour";
            this.tBFreqFour.ReadOnly = true;
            this.tBFreqFour.Size = new System.Drawing.Size(100, 22);
            this.tBFreqFour.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1021, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Частота четвертого спектра";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1172, 398);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Гц";
            // 
            // tBFreqFive
            // 
            this.tBFreqFive.Location = new System.Drawing.Point(1066, 398);
            this.tBFreqFive.Name = "tBFreqFive";
            this.tBFreqFive.ReadOnly = true;
            this.tBFreqFive.Size = new System.Drawing.Size(100, 22);
            this.tBFreqFive.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1022, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Частота пятого спектра";
            // 
            // cmBoxScale
            // 
            this.cmBoxScale.FormattingEnabled = true;
            this.cmBoxScale.Items.AddRange(new object[] {
            "1000",
            "2000",
            "5000",
            "10000",
            "15000",
            "20000"});
            this.cmBoxScale.Location = new System.Drawing.Point(332, 479);
            this.cmBoxScale.Name = "cmBoxScale";
            this.cmBoxScale.Size = new System.Drawing.Size(140, 24);
            this.cmBoxScale.TabIndex = 29;
            this.cmBoxScale.Text = "Не выбрано";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(329, 459);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Масштаб";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 525);
            this.Controls.Add(this.cmBoxScale);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tBFreqFive);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tBFreqFour);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tBFreqThree);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBFreqTwo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBFreqOne);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmBoxHarmonic);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmBoxHarmonic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBFreqOne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBFreqTwo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBFreqThree;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBFreqFour;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBFreqFive;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmBoxScale;
        private System.Windows.Forms.Label label16;
    }
}

