using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public static class Class1
    {

        public static Double[] prepare(string outputFolder, string fileName)

        {
            Double[] data;
            byte[] wave;
            System.IO.FileStream WaveFile = System.IO.File.OpenRead(Path.Combine(outputFolder, fileName));
            wave = new byte[WaveFile.Length];
            data = new Double[(wave.Length - 44) / 4];//shifting the headers out of the PCM data;
            WaveFile.Read(wave, 0, Convert.ToInt32(WaveFile.Length));//read the wave file into the wave variable
                                                                     /***********Converting and PCM accounting***************/
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (BitConverter.ToInt32(wave, 44 + i * 4)) / 4294967296.0;
            }

            return data;
        }

    }
}
