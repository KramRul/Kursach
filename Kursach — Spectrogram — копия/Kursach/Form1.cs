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
        private double[][] l;
        private static double[][] oldl;
        private double[][] r;
        private string []fileName;
        private string []filePath;
        private int countReadFile=0;

        int size = 65536;

        public Form1()
        {
            InitializeComponent();

            btShowSpectr.Click += BtShowSpectr_Click;
            cmBoxWindowFunc.SelectedIndexChanged += CmBoxWindowFunc_SelectedIndexChanged;
            cmBoxNumberOfCounts.SelectedIndexChanged += CmBoxNumberOfCounts_SelectedIndexChanged;
            cmBoxHarmonic.SelectedIndexChanged += CmBoxHarmonic_SelectedIndexChanged;
            btOpenFile.Click += BtOpenFile_Click;

            fileName = new string[5];
            filePath = new string[5];
            
            l = new double[5][];
            oldl = new double[5][];
            r = new double[5][];
         }

        private void CmBoxHarmonic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFreq();
        }

        private void BtOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (countReadFile > 5) throw new Exception("Количество выбраных файлов превысило порог.");

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "WAV files(*.wav)|*.wav|All files(*.*)|*.*";
                openFileDialog1.DefaultExt = "wav";
                openFileDialog1.AddExtension = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName[countReadFile] = openFileDialog1.SafeFileName;
                    filePath[countReadFile] = openFileDialog1.FileName;
                    tBFileName.Text = fileName[countReadFile];
                    tBFilePath.Text = filePath[countReadFile];

                    if (myChart.ChartAreas.Count == 0) myChart.ChartAreas.Add(new ChartArea("Math functions"));
                    /*mySeriesOfPoint = new Series("Sinus");
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = "Math functions";*/

                    for (int j = 0; j < countReadFile + 1; j++)
                    {
                        Class2.readWav(filePath[j], out l[j], out r[j]);
                        oldl[j] = new double[l[j].Length];
                        for (int i = 0; i < oldl[j].Length; i++)
                        {
                            oldl[j][i] = l[j][i];
                        }
                    }
                    ++countReadFile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\r\n" + "Метод: " + ex.TargetSite);
            }
        }

        private void CmBoxNumberOfCounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (countReadFile == 0) throw new Exception("Файл не открыт.");

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
                        size = l[0].Length;
                        break;
                }
                for (int i = 0; i < myChart.Series.Count; i++)
                {
                    myChart.Series[i].Points.Clear();
                    myChart.Series.RemoveAt(i);
                }
                ShowSpectr();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\r\n" + "Метод: " + ex.TargetSite);
            }
        }

        private void CmBoxWindowFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (countReadFile == 0) throw new Exception("Файл не открыт.");

                switch (cmBoxWindowFunc.SelectedIndex)
                {
                    case -1:
                        break;
                    case 0:
                        for (int j = 0; j < countReadFile; j++)
                            for (var i = 0; i < l[j].Length; i++)
                            {
                                l[j][i] *= Window.Rectangle(l[j][i], l[j].Length);
                            }
                        break;
                    case 1:
                        for (int j = 0; j < countReadFile; j++)
                            for (var i = 0; i < l[j].Length; i++)
                            {
                                l[j][i] *= Window.Gausse(l[j][i], l[j].Length);
                            }
                        break;
                    case 2:
                        for (int j = 0; j < countReadFile; j++)
                            for (var i = 0; i < l[j].Length; i++)
                            {
                                l[j][i] *= Window.Hamming(l[j][i], l[j].Length);
                            }
                        break;
                    case 3:
                        for (int j = 0; j < countReadFile; j++)
                            for (var i = 0; i < l[j].Length; i++)
                            {
                                l[j][i] *= Window.Hann(l[j][i], l[j].Length);
                            }
                        break;
                    case 4:
                        for (int j = 0; j < countReadFile; j++)
                            for (var i = 0; i < l[j].Length; i++)
                            {
                                l[j][i] *= Window.BlackmannHarris(l[j][i], l[j].Length);
                            }
                        break;
                }

                for (int i = 0; i < myChart.Series.Count; i++)
                {
                    myChart.Series[i].Points.Clear();
                    myChart.Series.RemoveAt(i);
                }
                ShowSpectr();
                for (int j = 0; j < countReadFile; j++)
                    for (int i = 0; i < oldl[j].Length; i++)
                    {
                        l[j][i] = oldl[j][i];
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\r\n" + "Метод: " + ex.TargetSite);
            }
        }

        private void BtShowSpectr_Click(object sender, EventArgs e)
        {
            try
            {
                if (countReadFile == 0) throw new Exception("Ни один файл не открыт.");
                if((myChart.Series.Count+1)>countReadFile) throw new Exception("Спектр уже отображён.");

                ShowSpectr();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\r\n" + "Метод: " + ex.TargetSite);
            }
        }

        private void ShowSpectr()
        {
            try
            {
                //myChart.Series.Remove(mySeriesOfPoint);*/


                /*for (var i = 0; i < l.Length; i++)
                {
                    l[i] *= Window.Hann(l[i], l.Length);
                }*/
                if (myChart.Series.Count > 0) for (int i = myChart.Series.Count - 1; i >= 0; i--)
                    {
                        myChart.Series[i].Points.Clear();
                        myChart.Series.RemoveAt(i);
                    }

                for (int j = 0; j < countReadFile; j++)
                {
                    mySeriesOfPoint = new Series(String.Format("Series {0}", j/*myChart.Series.Count*/));
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = "Math functions";

                    Complex[] complex = new Complex[size];

                    for (int i = 0; i < size; i++)
                    {
                        complex[i] = new Complex(l[j][i], 0);
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

                ShowFreq();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\r\n" + "Метод: " + ex.TargetSite);
            }
        }

        private void ShowFreq()
        {
            try
            {
                if (countReadFile == 0) throw new Exception("Файл не открыт.");

                var Peaks = FindPeaks();
                switch (cmBoxHarmonic.SelectedIndex)
                {
                    case -1:
                        break;
                    case 0:
                        if (Peaks[0] != null) tBFreqOne.Text = Convert.ToString(Peaks[0][0].X);
                        if (Peaks[1] != null) tBFreqTwo.Text = Convert.ToString(Peaks[1][0].X);
                        if (Peaks[2] != null) tBFreqThree.Text = Convert.ToString(Peaks[2][0].X);
                        if (Peaks[3] != null) tBFreqFour.Text = Convert.ToString(Peaks[3][0].X);
                        if (Peaks[4] != null) tBFreqFive.Text = Convert.ToString(Peaks[4][0].X);
                        break;
                    case 1:
                        if (Peaks[0] != null) tBFreqOne.Text = Convert.ToString(Peaks[0][1].X);
                        if (Peaks[1] != null) tBFreqTwo.Text = Convert.ToString(Peaks[1][1].X);
                        if (Peaks[2] != null) tBFreqThree.Text = Convert.ToString(Peaks[2][1].X);
                        if (Peaks[3] != null) tBFreqFour.Text = Convert.ToString(Peaks[3][1].X);
                        if (Peaks[4] != null) tBFreqFive.Text = Convert.ToString(Peaks[4][1].X);
                        break;
                    case 2:
                        if (Peaks[0] != null) tBFreqOne.Text = Convert.ToString(Peaks[0][2].X);
                        if (Peaks[1] != null) tBFreqTwo.Text = Convert.ToString(Peaks[1][2].X);
                        if (Peaks[2] != null) tBFreqThree.Text = Convert.ToString(Peaks[2][2].X);
                        if (Peaks[3] != null) tBFreqFour.Text = Convert.ToString(Peaks[3][2].X);
                        if (Peaks[4] != null) tBFreqFive.Text = Convert.ToString(Peaks[4][2].X);
                        break;
                    case 3:
                        if (Peaks[0] != null) tBFreqOne.Text = Convert.ToString(Peaks[0][4].X);
                        if (Peaks[1] != null) tBFreqTwo.Text = Convert.ToString(Peaks[1][4].X);
                        if (Peaks[2] != null) tBFreqThree.Text = Convert.ToString(Peaks[2][4].X);
                        if (Peaks[3] != null) tBFreqFour.Text = Convert.ToString(Peaks[3][4].X);
                        if (Peaks[4] != null) tBFreqFive.Text = Convert.ToString(Peaks[4][4].X);
                        break;
                    case 4:
                        if (Peaks[0] != null) tBFreqOne.Text = Convert.ToString(Peaks[0][9].X);
                        if (Peaks[1] != null) tBFreqTwo.Text = Convert.ToString(Peaks[1][9].X);
                        if (Peaks[2] != null) tBFreqThree.Text = Convert.ToString(Peaks[2][9].X);
                        if (Peaks[3] != null) tBFreqFour.Text = Convert.ToString(Peaks[3][9].X);
                        if (Peaks[4] != null) tBFreqFive.Text = Convert.ToString(Peaks[4][9].X);
                        break;
                    case 5:
                        if (Peaks[0] != null) tBFreqOne.Text = Convert.ToString(Peaks[0][14].X);
                        if (Peaks[1] != null) tBFreqTwo.Text = Convert.ToString(Peaks[1][14].X);
                        if (Peaks[2] != null) tBFreqThree.Text = Convert.ToString(Peaks[2][14].X);
                        if (Peaks[3] != null) tBFreqFour.Text = Convert.ToString(Peaks[3][14].X);
                        if (Peaks[4] != null) tBFreqFive.Text = Convert.ToString(Peaks[4][14].X);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\r\n" + "Метод: " + ex.TargetSite);
            }
        }

        private Point2D[][] FindPeaks()
        {
            //var x = myChart.Series[0].Points[1].XValue;
            //var it = myChart.Series[0].Points[1].YValues[0];
            var PeaksOfSpectrs = new Point2D[5][];

            try
            {
                for (int j = 0; j < countReadFile; j++)
                {
                    Point2D[] Peaks = new Point2D[15];
                    for (int i = 0; i < Peaks.Length; i++)
                    {
                        Peaks[i] = new Point2D();
                    }
                    int k = 0;

                    for (int i = 0; i < myChart.Series[j].Points.Count; i++)
                    {
                        if (myChart.Series[j].Points[i].YValues[0] >= Peaks[k].Y)
                        {
                            Peaks[k].Y = myChart.Series[j].Points[i].YValues[0];
                            Peaks[k].X = myChart.Series[j].Points[i].XValue;

                        }
                        else
                        {
                            if (Math.Abs(myChart.Series[j].Points[i - 1].YValues[0] - myChart.Series[j].Points[i].YValues[0]) > 4.0)
                                ++k;
                        }
                        if (k == Peaks.Length)
                            break;
                    }

                    PeaksOfSpectrs[j] = Peaks;
                }
                return PeaksOfSpectrs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message + "\r\n" + "Метод: " + ex.TargetSite);
                return PeaksOfSpectrs;
            }
        }
    }
}
