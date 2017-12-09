using System;
using System.Numerics;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.Runtime.InteropServices;

namespace Kursach
{
    public partial class Form1 : Form
    {
        private static Series mySeriesOfPoint;
        private double[] l;
        private static double[] oldl;
        private double[] r;
        int size= 65536;

        public Form1()
        {
            InitializeComponent();

            myChart.ChartAreas.Add(new ChartArea("Math functions"));
            mySeriesOfPoint = new Series("Sinus");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "Math functions";

            btShowSpectr.Click += BtShowSpectr_Click;
            cmBoxWindowFunc.SelectedIndexChanged += CmBoxWindowFunc_SelectedIndexChanged;
            cmBoxNumberOfCounts.SelectedIndexChanged += CmBoxNumberOfCounts_SelectedIndexChanged;

            Class2.readWav("E:\\Git_Projects\\Kursach\\Kursach — Spectrogram — копия\\Kursach\\bin\\Debug\\noise.wav", out l, out r);
            oldl = new double[l.Length];
            for (int i = 0; i < oldl.Length; i++)
            {
                oldl[i] = l[i];
            }
        }

        private void CmBoxNumberOfCounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmBoxNumberOfCounts.SelectedIndex)
            {
                case -1:
                    break;
                case 0:
                    size = 1024;
                    break;
                case 1:
                    size = 2048;
                    break;
                case 2:
                    size = 4096;
                    break;
                case 3:
                    size = 8192;
                    break;
                case 4:
                    size = 16384;
                    break;
                case 5:
                    size = 32768;
                    break;
                case 6:
                    size = 65536;
                    break;
                case 7:
                    size = 131072;
                    break;
                case 8:
                    size = 262144;
                    break;
                case 9:
                    size = 524288;
                    break;
                case 10:
                    size = l.Length;
                    break;
            }

            myChart.Series[0].Points.Clear();
            myChart.Series.RemoveAt(0);
            ShowSpectr();
        }

            private void CmBoxWindowFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmBoxWindowFunc.SelectedIndex)
            {
                case -1:
                    break;
                case 0:
                    for (var i = 0; i < l.Length; i++)
                    {
                        l[i] *= Window.Rectangle(l[i], l.Length);
                    }
                    break;
                case 1:
                    for (var i = 0; i < l.Length; i++)
                    {
                        l[i] *= Window.Gausse(l[i], l.Length);
                    }
                    break;
                case 2:
                    for (var i = 0; i < l.Length; i++)
                    {
                        l[i] *= Window.Hamming(l[i], l.Length);
                    }
                    break;
                case 3:
                    for (var i = 0; i < l.Length; i++)
                    {
                        l[i] *= Window.Hann(l[i], l.Length);
                    }
                    break;
                case 4:
                    for (var i = 0; i < l.Length; i++)
                    {
                        l[i] *= Window.BlackmannHarris(l[i], l.Length);
                    }
                    break;
            }

            myChart.Series[0].Points.Clear();
            myChart.Series.RemoveAt(0);
            ShowSpectr();
            for (int i = 0; i < oldl.Length; i++)
            {
                l[i] = oldl[i];
            }
        }

        private void BtShowSpectr_Click(object sender, EventArgs e)
        {
            ShowSpectr();
        }

        private void ShowSpectr()
        {

            /*for (var i = 0; i < l.Length; i++)
            {
                l[i] *= Window.Hann(l[i], l.Length);
            }*/

            Complex[] complex = new Complex[size];

            for (int i = 0; i < size; i++)
            {
                complex[i] = new Complex(l[i], 0);
            }

            var spectrum = Butterfly.DecimationInTime(complex, true);
            /*for (var i = 0; i < spectrum.Length; i++)
            {
                spectrum[i] /= spectrum.Length;
            }*/

            double cur_freq = 0;
            double delta = (44100.0) / (spectrum.Length / 2);
            double[] magn = new double[size];

            for (var i = 0; i < spectrum.Length; i += 2)
            {
                magn[i] = cur_freq;
                magn[i + 1] = spectrum[i].Magnitude;
                cur_freq += delta;
            }


            /*for (var i = 0; i < magn.Length; i++)
            {
                mySeriesOfPoint.Points.AddXY(i, magn[i]);
            }
            //Добавляем созданный набор точек в Chart
            myChart.Series.Add(mySeriesOfPoint);*/
            for (int i = 1; i < 5000; i += 2)
            {
                if ((10 * Math.Log10(magn[i])) != Double.PositiveInfinity && (10 * Math.Log10(magn[i])) > Double.NegativeInfinity)
                    //mySeriesOfPoint.Points.AddXY(i, 10 * Math.Log10(magn[i]));
                    //else mySeriesOfPoint.Points.AddXY(i, 0);
                    mySeriesOfPoint.Points.AddXY(magn[i - 1], 10 * Math.Log10(magn[i]));
            }


            //Добавляем созданный набор точек в Chart
            myChart.Series.Add(mySeriesOfPoint);
        }
    }
}
