using System;
using System.IO;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public static class AudioReader
    {
        public static bool readWav(string filename, out double[] L, out double[] R/*out float[] L, out float[] R*/)
        {
            L = R = null;
            //float [] left = new float[1];

            //float [] right;

            BinaryReader reader = new BinaryReader(new FileStream(@filename, FileMode.Open));

            // chunk 0
            int chunkID = reader.ReadInt32();
            int fileSize = reader.ReadInt32();
            int riffType = reader.ReadInt32();
            // chunk 1
            int fmtID = reader.ReadInt32();


            int fmtSize = reader.ReadInt32(); // bytes for this chunk
            int fmtCode = reader.ReadInt16();
            int channels = reader.ReadInt16();
            int sampleRate = reader.ReadInt32();
            int byteRate = reader.ReadInt32();


            int fmtBlockAlign = reader.ReadInt16();
            int bitDepth = reader.ReadInt16();

            if (fmtSize == 18)
            {
                // Read any extra values
                int fmtExtraSize = reader.ReadInt16();
                reader.ReadBytes(fmtExtraSize);
            }

            // chunk 2
            int dataID = reader.ReadInt32();
            int bytes = reader.ReadInt32();

            // DATA!
            byte[] byteArray = reader.ReadBytes(bytes);

            int bytesForSamp = bitDepth / 8;
            int samps = bytes / bytesForSamp;

            /*int p2 = (int)(Math.Log(samps,2));
            int size_array = 1 << (int)(Math.Log(samps,2));

            var temp_arr = new byte[size_array];

            int j = 0;
            for (int i = 0; i < size_array; i+=2)
            {
                temp_arr[i] = byteArray[j];
                ++j;
            }
            
            double[] asDob = null;
            switch (bitDepth)
            {
                case 64:
                    double[]
                    asDouble = new double[size_array];
                    Buffer.BlockCopy(temp_arr, 0, asDouble, 0, size_array);
                    //asFloat = Array.ConvertAll(asDouble, e => (float)e);
                    asDob = asDouble;
                    break;
                case 32:
                    //asFloat = new float[samps];
                    //Buffer.BlockCopy(byteArray, 0, asFloat, 0, bytes);
                    break;
                case 16:
                    Int16[]
                    asInt16 = new Int16[size_array];
                    Buffer.BlockCopy(temp_arr, 0, asInt16, 0, size_array);
                    asDob = new double[asInt16.Length];
                    //asFloat = Array.ConvertAll(asInt16, e => e / (float)Int16.MaxValue);
                    //asDob = Array.ConvertAll(asInt16, e => e / (double)Int16.MaxValue);

                    for (int i = 0; i < asDob.Length; i++)
                    {
                        asDob[i] = Convert.ToDouble(asInt16[i]);
                    }

                    break;
                default:
                    return false;
            }

            switch (channels)
            {
                case 1:
                    //L = asFloat;
                    L = asDob;
                    R = null;
                    return true;
                case 2:
                    //L = new float[samps];
                    //R = new float[samps];
                    for (int i = 0, s = 0; i < samps; i++)
                    {
                        // L[i] = asFloat[s++];
                        // R[i] = asFloat[s++];
                    }
                    return true;
                default:
                    return false;
            }
            return false;
        }*/

        //float[] asFloat = null;
        double[] asDob = null;
        switch (bitDepth)
        {
            case 64:
                double[]
                asDouble = new double[samps];
                Buffer.BlockCopy(byteArray, 0, asDouble, 0, bytes);
                //asFloat = Array.ConvertAll(asDouble, e => (float)e);
                asDob = asDouble;
                break;
            case 32:
                //asFloat = new float[samps];
                //Buffer.BlockCopy(byteArray, 0, asFloat, 0, bytes);
                break;
            case 16:
                Int16[]
                asInt16 = new Int16[samps];
                Buffer.BlockCopy(byteArray, 0, asInt16, 0, bytes);
                asDob = new double[asInt16.Length];
                //asFloat = Array.ConvertAll(asInt16, e => e / (float)Int16.MaxValue);
                //asDob = Array.ConvertAll(asInt16, e => e / (double)Int16.MaxValue);

                for (int i = 0; i < asDob.Length; i++)
                {
                    asDob[i] = Convert.ToDouble(asInt16[i]);
                }

                break;
            default:
                return false;
        }
            reader.Close();
            switch (channels)
        {
            case 1:
                //L = asFloat;
                L = asDob;
                R = null;
                return true;
            case 2:
                    L = new double[samps/2];
                    R = new double[samps/2];
                    for (int i = 0, s=0; i < samps/2; i++)
                    {
                        L[i] = asDob[s++];
                        R[i] = asDob[s++];                        
                    }
                    return true;
            default:
                return false;
        }
        return false;
    }

    }
}
