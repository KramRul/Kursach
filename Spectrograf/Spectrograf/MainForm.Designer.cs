namespace Spectrograf
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRecordSound = new System.Windows.Forms.Button();
            this.btOpenSpectrogram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "Нажмите на одну из кнопок с тем, что Вы хотите сделать: записать звук с микрофона" +
    " или увидеть спектры сигналов.";
            // 
            // btRecordSound
            // 
            this.btRecordSound.Location = new System.Drawing.Point(177, 143);
            this.btRecordSound.Name = "btRecordSound";
            this.btRecordSound.Size = new System.Drawing.Size(142, 55);
            this.btRecordSound.TabIndex = 2;
            this.btRecordSound.Text = "ЗАПИСАТЬ ЗВУК";
            this.btRecordSound.UseVisualStyleBackColor = true;
            // 
            // btOpenSpectrogram
            // 
            this.btOpenSpectrogram.Location = new System.Drawing.Point(177, 213);
            this.btOpenSpectrogram.Name = "btOpenSpectrogram";
            this.btOpenSpectrogram.Size = new System.Drawing.Size(142, 55);
            this.btOpenSpectrogram.TabIndex = 3;
            this.btOpenSpectrogram.Text = "УВИДЕТЬ СПЕКТР";
            this.btOpenSpectrogram.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 309);
            this.Controls.Add(this.btOpenSpectrogram);
            this.Controls.Add(this.btRecordSound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRecordSound;
        private System.Windows.Forms.Button btOpenSpectrogram;
    }
}

