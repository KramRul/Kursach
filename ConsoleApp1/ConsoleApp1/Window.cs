using System;
using System.Numerics;

namespace ConsoleApp1
{
    public class Window
    {
        private const double Q = 0.5;

        public static double Rectangle(double n, double frameSize)
        {
            return 1;
        }

        public static double Gausse(double n, double frameSize)
        {
            var a = (frameSize - 1)/2;
            var t = (n - a)/(Q*a);
            t = t*t;
            return Math.Exp(-t/2);
        }

        public static double Hamming(double n, double frameSize)
        {
            return 0.54 - 0.46*Math.Cos((2*Math.PI*n)/(frameSize - 1));
        }

        public static double Hann(double n, double frameSize)
        {
            return 0.5*(1 - Math.Cos((2*Math.PI*n)/(frameSize - 1)));
        }

        public static double BlackmannHarris(double n, double frameSize)
        {
            return 0.35875 - (0.48829*Math.Cos((2*Math.PI*n)/(frameSize - 1))) +
                   (0.14128*Math.Cos((4*Math.PI*n)/(frameSize - 1))) - (0.01168*Math.Cos((4*Math.PI*n)/(frameSize - 1)));
        }

        public static Complex WaveWavelet(Complex n, Complex frameSize)
        {
            var t = n/frameSize;
            return -t*Math.Exp((-t*t/2.0).Real);
        }

        public static double SombreroWavelet(double n, double frameSize)
        {
            var t = n / frameSize;
            return (t*t - 1)*Math.Exp(-t*t/2);
        }

        public static double DOGWavelet(double n, double frameSize)
        {
            var t = n / frameSize;
            return Math.Exp(-t*t/2) - Math.Exp(-t*t/8)/2;
        }
    }
}
