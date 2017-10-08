using System;
using System.Collections.Generic;
using System.Text;
using static Imd.Domain.Enums;

namespace Imd.Domain.Models
{
    public class TimeCode
    {
        public VideoStandard Standard { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public int Frames { get; set; }

        //public int HH
        //{
        //    get
        //    {
        //        return Value.Hours;
        //    }
        //}
        //public int MM
        //{
        //    get
        //    {
        //        return Value.Minutes;
        //    }
        //}
        //public int ss
        //{
        //    get
        //    {
        //        return Value.Seconds;
        //    }
        //}
        //public int ff
        //{
        //    get
        //    {
        //        return Value./*Milliseconds*/;
        //    }
        //}

        public TimeCode(int HH, int MM, int ss, int ff, VideoStandard videoStandard)
        {
            Standard = videoStandard;
            TimeSpan = new TimeSpan(0, HH, MM, ss, 0);
            Frames = ff;
        }

        public TimeCode(TimeSpan timeSpan, int ff, VideoStandard videoStandard)
        {
            Standard = videoStandard;
            Frames = ff;
            TimeSpan = timeSpan;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}:{2}:{3}", 
                TimeSpan.Hours.ToString("00"),
                TimeSpan.Minutes.ToString("00"), 
                TimeSpan.Seconds.ToString("00"), 
                Frames.ToString("00"));
        }
    }
}
