using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CoolantPostureController
{
    public class TId2AngleConfigure
    {
#if WinCE
        private const string FileName = "\HardDisk\TId2AngleConfigure.txt";
#else
        private const string FileName = "TId2AngleConfigure.txt";
#endif

        private const int bufferLength = 64;
        private double[] buffer = new double[bufferLength];

        private  TId2AngleConfigure()
        { }

        static TId2AngleConfigure _obj = null;
        public static TId2AngleConfigure GetInstance()
        {
            if (_obj == null)
                _obj = new TId2AngleConfigure();

            return _obj;
        }



        public double GetAngle(int idx)
        {
            if (idx >= 0 && idx < bufferLength)
                return buffer[idx];
            else
                return 0;
        }

        public void SetAngle(int idx, double val)
        {
            if (idx >= 0 && idx < bufferLength)
            {
                buffer[idx] = val;
            }
        }


        public void Load()
        {
            if (File.Exists(FileName))
            {
                FileStream fs = new FileStream(FileName, FileMode.Open);

                BinaryReader br = new BinaryReader(fs);

                try
                {
                    try
                    {
                        for (int i = 0; i < bufferLength; i++)
                        {
                            buffer[i] = br.ReadDouble();
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                finally
                {
                    br.Close();
                    fs.Close();
                }
            }

        }

        public void Save()
        {
            if (File.Exists(FileName))
                File.Delete(FileName);

            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);

            try
            {
                try
                {
                    for (int i = 0; i < bufferLength; i++)
                    {
                        bw.Write(buffer[i]);
                    }
                }
                catch (Exception)
                {

                }
            }
            finally
            {
                bw.Flush();
                bw.Close();
                fs.Close();
            }
        }
    }
}
