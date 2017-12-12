using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spectrograf
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btRecordSound.Click += BtRecordSound_Click;
            btOpenSpectrogram.Click += BtOpenSpectrogram_Click;
        }

        private void BtOpenSpectrogram_Click(object sender, EventArgs e)
        {
            try
            {
                Kursach.Spectrogram FormSpectr = new Kursach.Spectrogram();
                if (FormSpectr.ShowDialog() == DialogResult.OK)
                {

                }
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\r\n" + "Метод: " + ex.TargetSite);
            }
        }

        private void BtRecordSound_Click(object sender, EventArgs e)
        {
            try
            {
                AudioRecoding.Form1 recordSound = new AudioRecoding.Form1();
                if (recordSound.ShowDialog() == DialogResult.OK)
                {

                }
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\r\n" + "Метод: " + ex.TargetSite);
            }
        }
    }
}
