using System;
using System.Collections.Generic;
using System.Text;

namespace RoboCup_data_extractor
{
    class FrameData
    {
        public float Frame { get; private set; }
        public float Ball_x { get; private set; }
        public float Ball_y { get; private set; }
        public float Lplayer1_x { get; private set; }
        public float Lplayer1_y { get; private set; }
        public float Lplayer2_x { get; private set; }
        public float Lplayer2_y { get; private set; }
        public float Lplayer3_x { get; private set; }
        public float Lplayer3_y { get; private set; }
        public float Lplayer4_x { get; private set; }
        public float Lplayer4_y { get; private set; }
        public float Lplayer5_x { get; private set; }
        public float Lplayer5_y { get; private set; }
        public float Rplayer1_x { get; private set; }
        public float Rplayer1_y { get; private set; }
        public float Rplayer2_x { get; private set; }
        public float Rplayer2_y { get; private set; }
        public float Rplayer3_x { get; private set; }
        public float Rplayer3_y { get; private set; }
        public float Rplayer4_x { get; private set; }
        public float Rplayer4_y { get; private set; }
        public float Rplayer5_x { get; private set; }
        public float Rplayer5_y { get; private set; }
        public float Posession { get; private set; }

        public FrameData(float frame, float ball_x, float ball_y, float lplayer1_x, float lplayer1_y, float lplayer2_x, float lplayer2_y, float lplayer3_x, float lplayer3_y, float lplayer4_x, float lplayer4_y, float lplayer5_x, float lplayer5_y, float rplayer1_x, float rplayer1_y, float rplayer2_x, float rplayer2_y, float rplayer3_x, float rplayer3_y, float rplayer4_x, float rplayer4_y, float rplayer5_x, float rplayer5_y, float posession)
        {
            Frame = frame;
            Ball_x = ball_x;
            Ball_y = ball_y;
            Lplayer1_x = lplayer1_x;
            Lplayer1_y = lplayer1_y;
            Lplayer2_x = lplayer2_x;
            Lplayer2_y = lplayer2_y;
            Lplayer3_x = lplayer3_x;
            Lplayer3_y = lplayer3_y;
            Lplayer4_x = lplayer4_x;
            Lplayer4_y = lplayer4_y;
            Lplayer5_x = lplayer5_x;
            Lplayer5_y = lplayer5_y;
            Rplayer1_x = rplayer1_x;
            Rplayer1_y = rplayer1_y;
            Rplayer2_x = rplayer2_x;
            Rplayer2_y = rplayer2_y;
            Rplayer3_x = rplayer3_x;
            Rplayer3_y = rplayer3_y;
            Rplayer4_x = rplayer4_x;
            Rplayer4_y = rplayer4_y;
            Rplayer5_x = rplayer5_x;
            Rplayer5_y = rplayer5_y;
            Posession = posession;
        }
    }
}
