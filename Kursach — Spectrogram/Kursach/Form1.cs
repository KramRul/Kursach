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
        

        public Form1()
        {
            InitializeComponent();
            //Chart myChart = new Chart();
            //кладем его на форму и растягиваем на все окно.
            //myChart.Parent = this;
            //myChart.Dock = DockStyle.Fill;
            //добавляем в Chart область для рисования графиков, их может быть
            //много, поэтому даем ей имя.
            myChart.ChartAreas.Add(new ChartArea("Math functions"));
            //Создаем и настраиваем набор точек для рисования графика, в том
            //не забыв указать имя области на которой хотим отобразить этот
            //набор точек.
            Series mySeriesOfPoint = new Series("Sinus");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "Math functions";


            double[] l;
            double[] r;
            Class2.readWav("C:\\Users\\KramRul\\source\\repos\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\test.wav", out l, out r);



            //for (var i = 0; i < l.Length; i++)
            //{
            //    l[i] *= Window.Gausse(l[i], l.Length);
            //}

            Complex[] complex = new Complex[l.Length];

            for (int i = 0; i < l.Length; i++)
            {
                complex[i] = new Complex(l[i], 0);
            }

            var spectrum = Butterfly.DecimationInTime(complex, true);
            for (var i = 0; i < spectrum.Length; i++)
            {
                spectrum[i] /= spectrum.Length;
            }

            double cur_freq = 0;
            double delta = (44100.0) / (spectrum.Length/2);
           double[] magn = new double[l.Length];

            for (var i = 0; i < spectrum.Length; i+=2)
            {
                magn[i] = cur_freq;
                magn[i+1] = spectrum[i].Magnitude;
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
