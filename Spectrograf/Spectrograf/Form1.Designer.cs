namespace AudioRecoding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxRecordingApi = new System.Windows.Forms.GroupBox();
            this.comboWasapiLoopbackDevices = new System.Windows.Forms.ComboBox();
            this.checkBoxEventCallback = new System.Windows.Forms.CheckBox();
            this.comboBoxChannels = new System.Windows.Forms.ComboBox();
            this.comboBoxSampleRate = new System.Windows.Forms.ComboBox();
            this.comboWaveInDevice = new System.Windows.Forms.ComboBox();
            this.comboWasapiDevices = new System.Windows.Forms.ComboBox();
            this.radioButtonWasapiLoopback = new System.Windows.Forms.RadioButton();
            this.radioButtonWasapi = new System.Windows.Forms.RadioButton();
            this.radioButtonWaveIn = new System.Windows.Forms.RadioButton();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.listBoxRecordings = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStopRecording = new System.Windows.Forms.Button();
            this.buttonStartRecording = new System.Windows.Forms.Button();
            this.groupBoxRecordingApi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRecordingApi
            // 
            this.groupBoxRecordingApi.Controls.Add(this.comboWasapiLoopbackDevices);
            this.groupBoxRecordingApi.Controls.Add(this.checkBoxEventCallback);
            this.groupBoxRecordingApi.Controls.Add(this.comboBoxChannels);
            this.groupBoxRecordingApi.Controls.Add(this.comboBoxSampleRate);
            this.groupBoxRecordingApi.Controls.Add(this.comboWaveInDevice);
            this.groupBoxRecordingApi.Controls.Add(this.comboWasapiDevices);
            this.groupBoxRecordingApi.Controls.Add(this.radioButtonWasapiLoopback);
            this.groupBoxRecordingApi.Controls.Add(this.radioButtonWasapi);
            this.groupBoxRecordingApi.Controls.Add(this.radioButtonWaveIn);
            this.groupBoxRecordingApi.Location = new System.Drawing.Point(11, 59);
            this.groupBoxRecordingApi.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRecordingApi.Name = "groupBoxRecordingApi";
            this.groupBoxRecordingApi.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRecordingApi.Size = new System.Drawing.Size(359, 213);
            this.groupBoxRecordingApi.TabIndex = 21;
            this.groupBoxRecordingApi.TabStop = false;
            this.groupBoxRecordingApi.Text = "Recording API";
            // 
            // comboWasapiLoopbackDevices
            // 
            this.comboWasapiLoopbackDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWasapiLoopbackDevices.FormattingEnabled = true;
            this.comboWasapiLoopbackDevices.Location = new System.Drawing.Point(188, 178);
            this.comboWasapiLoopbackDevices.Margin = new System.Windows.Forms.Padding(4);
            this.comboWasapiLoopbackDevices.Name = "comboWasapiLoopbackDevices";
            this.comboWasapiLoopbackDevices.Size = new System.Drawing.Size(160, 24);
            this.comboWasapiLoopbackDevices.TabIndex = 14;
            // 
            // checkBoxEventCallback
            // 
            this.checkBoxEventCallback.AutoSize = true;
            this.checkBoxEventCallback.Location = new System.Drawing.Point(188, 50);
            this.checkBoxEventCallback.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEventCallback.Name = "checkBoxEventCallback";
            this.checkBoxEventCallback.Size = new System.Drawing.Size(130, 21);
            this.checkBoxEventCallback.TabIndex = 13;
            this.checkBoxEventCallback.Text = "Event Callbacks";
            this.checkBoxEventCallback.UseVisualStyleBackColor = true;
            // 
            // comboBoxChannels
            // 
            this.comboBoxChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChannels.FormattingEnabled = true;
            this.comboBoxChannels.Location = new System.Drawing.Point(188, 82);
            this.comboBoxChannels.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxChannels.Name = "comboBoxChannels";
            this.comboBoxChannels.Size = new System.Drawing.Size(160, 24);
            this.comboBoxChannels.TabIndex = 12;
            // 
            // comboBoxSampleRate
            // 
            this.comboBoxSampleRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSampleRate.FormattingEnabled = true;
            this.comboBoxSampleRate.Location = new System.Drawing.Point(20, 82);
            this.comboBoxSampleRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSampleRate.Name = "comboBoxSampleRate";
            this.comboBoxSampleRate.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSampleRate.TabIndex = 12;
            // 
            // comboWaveInDevice
            // 
            this.comboWaveInDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWaveInDevice.FormattingEnabled = true;
            this.comboWaveInDevice.Location = new System.Drawing.Point(188, 16);
            this.comboWaveInDevice.Margin = new System.Windows.Forms.Padding(4);
            this.comboWaveInDevice.Name = "comboWaveInDevice";
            this.comboWaveInDevice.Size = new System.Drawing.Size(160, 24);
            this.comboWaveInDevice.TabIndex = 12;
            // 
            // comboWasapiDevices
            // 
            this.comboWasapiDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWasapiDevices.FormattingEnabled = true;
            this.comboWasapiDevices.Location = new System.Drawing.Point(188, 143);
            this.comboWasapiDevices.Margin = new System.Windows.Forms.Padding(4);
            this.comboWasapiDevices.Name = "comboWasapiDevices";
            this.comboWasapiDevices.Size = new System.Drawing.Size(160, 24);
            this.comboWasapiDevices.TabIndex = 12;
            // 
            // radioButtonWasapiLoopback
            // 
            this.radioButtonWasapiLoopback.AutoSize = true;
            this.radioButtonWasapiLoopback.Location = new System.Drawing.Point(8, 176);
            this.radioButtonWasapiLoopback.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonWasapiLoopback.Name = "radioButtonWasapiLoopback";
            this.radioButtonWasapiLoopback.Size = new System.Drawing.Size(147, 21);
            this.radioButtonWasapiLoopback.TabIndex = 8;
            this.radioButtonWasapiLoopback.Text = "WASAPI Loopback";
            this.radioButtonWasapiLoopback.UseVisualStyleBackColor = true;
            // 
            // radioButtonWasapi
            // 
            this.radioButtonWasapi.AutoSize = true;
            this.radioButtonWasapi.Location = new System.Drawing.Point(8, 148);
            this.radioButtonWasapi.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonWasapi.Name = "radioButtonWasapi";
            this.radioButtonWasapi.Size = new System.Drawing.Size(81, 21);
            this.radioButtonWasapi.TabIndex = 9;
            this.radioButtonWasapi.Text = "WASAPI";
            this.radioButtonWasapi.UseVisualStyleBackColor = true;
            // 
            // radioButtonWaveIn
            // 
            this.radioButtonWaveIn.AutoSize = true;
            this.radioButtonWaveIn.Checked = true;
            this.radioButtonWaveIn.Location = new System.Drawing.Point(8, 21);
            this.radioButtonWaveIn.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonWaveIn.Name = "radioButtonWaveIn";
            this.radioButtonWaveIn.Size = new System.Drawing.Size(72, 21);
            this.radioButtonWaveIn.TabIndex = 11;
            this.radioButtonWaveIn.TabStop = true;
            this.radioButtonWaveIn.Text = "waveIn";
            this.radioButtonWaveIn.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFolder.Location = new System.Drawing.Point(694, 351);
            this.buttonOpenFolder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenFolder.TabIndex = 19;
            this.buttonOpenFolder.Text = "Open Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(694, 315);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.Location = new System.Drawing.Point(694, 280);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 28);
            this.buttonPlay.TabIndex = 18;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // listBoxRecordings
            // 
            this.listBoxRecordings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRecordings.FormattingEnabled = true;
            this.listBoxRecordings.ItemHeight = 16;
            this.listBoxRecordings.Location = new System.Drawing.Point(11, 280);
            this.listBoxRecordings.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRecordings.Name = "listBoxRecordings";
            this.listBoxRecordings.Size = new System.Drawing.Size(673, 132);
            this.listBoxRecordings.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Recording Progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(410, 169);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(343, 28);
            this.progressBar1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 57);
            this.label1.TabIndex = 14;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonStopRecording
            // 
            this.buttonStopRecording.Location = new System.Drawing.Point(606, 96);
            this.buttonStopRecording.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStopRecording.Name = "buttonStopRecording";
            this.buttonStopRecording.Size = new System.Drawing.Size(147, 28);
            this.buttonStopRecording.TabIndex = 12;
            this.buttonStopRecording.Text = "Остановить запись";
            this.buttonStopRecording.UseVisualStyleBackColor = true;
            // 
            // buttonStartRecording
            // 
            this.buttonStartRecording.Location = new System.Drawing.Point(410, 96);
            this.buttonStartRecording.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartRecording.Name = "buttonStartRecording";
            this.buttonStartRecording.Size = new System.Drawing.Size(140, 28);
            this.buttonStartRecording.TabIndex = 13;
            this.buttonStartRecording.Text = "Начать запись";
            this.buttonStartRecording.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 410);
            this.Controls.Add(this.groupBoxRecordingApi);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.listBoxRecordings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStopRecording);
            this.Controls.Add(this.buttonStartRecording);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxRecordingApi.ResumeLayout(false);
            this.groupBoxRecordingApi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRecordingApi;
        private System.Windows.Forms.ComboBox comboWasapiLoopbackDevices;
        private System.Windows.Forms.CheckBox checkBoxEventCallback;
        private System.Windows.Forms.ComboBox comboBoxChannels;
        private System.Windows.Forms.ComboBox comboBoxSampleRate;
        private System.Windows.Forms.ComboBox comboWaveInDevice;
        private System.Windows.Forms.ComboBox comboWasapiDevices;
        private System.Windows.Forms.RadioButton radioButtonWasapiLoopback;
        private System.Windows.Forms.RadioButton radioButtonWasapi;
        private System.Windows.Forms.RadioButton radioButtonWaveIn;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.ListBox listBoxRecordings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStopRecording;
        private System.Windows.Forms.Button buttonStartRecording;
    }
}

