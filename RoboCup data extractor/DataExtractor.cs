using System;
using System.Collections.Generic;
using System.Text;

namespace RoboCup_data_extractor
{
    class DataExtractor
    {
        public FrameDataSet FrameDataStorage { get; private set; }

        public DataExtractor()
        {
            FrameDataStorage = new FrameDataSet();
        }

        public void Extract(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (!line.StartsWith("Frame"))
                {
                    float[] data = new float[24];
                    int comma2 = line.IndexOf(',');
                    int comma1;
                    data[0] = float.Parse(line.Substring(0, comma2 + 1));

                    for (int i = 1; i < 23; i++)
                    {
                        comma1 = comma2;
                        comma2 = line.Substring(comma1 + 1).IndexOf(',') + line.Substring(0, comma1 + 1).Length;
                        data[i] = float.Parse(line.Substring(comma1 + 1, comma2 - comma1));
                    }

                    FrameDataStorage.AddData(new FrameData(data[0], data[1], data[2], data[3], data[4], data[5],
                        data[6], data[7], data[8], data[9], data[10], data[11], data[12], data[13], data[14], data[15],
                        data[16], data[17], data[18], data[19], data[20], data[21], data[22], data[23]));
                }
            }
        }
    }
}
