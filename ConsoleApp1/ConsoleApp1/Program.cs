using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Class2.met();
            double [] l;
            double [] r;
            Class2.readWav("C:\\Users\\KramRul\\source\\repos\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\test.wav", out l, out r);

            Complex [] complex = new Complex[l.Length];

            for (int  i=0; i<l.Length;i++)
            {
                complex[i] = new Complex(l[i],0);
            }

            var spectrum = Butterfly.DecimationInTime(complex, true);
            for (var i = 0; i < spectrum.Length; i++)
            {
                spectrum[i] /= spectrum.Length;
            }

            Complex[] magn = new Complex[l.Length];
            for (var i = 0; i < spectrum.Length; i++)
            {
                magn[i] = Math.Sqrt(spectrum[i].Real * spectrum[i].Real + spectrum[i].Imaginary * spectrum[i].Imaginary);
            }


        }
    }
}
