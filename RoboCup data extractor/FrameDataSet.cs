using System;
using System.Collections.Generic;
using System.Text;

namespace RoboCup_data_extractor
{
    class FrameDataSet
    {
        public List<FrameData> FrameDatas { get; private set; }

        public FrameDataSet()
        {
            FrameDatas = new List<FrameData>();
        }

        public void AddData(FrameData frameData)
        {
            FrameDatas.Add(frameData);
        }
    }
}
