using System;
using System.Collections.Generic;
using System.Text;

namespace Imd.Domain.Models
{
    public class TimeCode
    {
        public TimeSpan Value { get; set; }

        public int HH
        {
            get
            {
                return Value.Hours;
            }
        }
        public int MM
        {
            get
            {
                return Value.Minutes;
            }
        }
        public int ss
        {
            get
            {
                return Value.Seconds;
            }
        }

        public int ff
        {
            get
            {
                return Value.Milliseconds;
            }
        }

        public TimeCode(int HH, int MM, int ss, int ff)
        {
            Value = new TimeSpan(0, HH, MM, ss, ff);
        }

        public TimeCode(TimeSpan value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}:{2}:{3}", 
                HH.ToString("00"), 
                MM.ToString("00"), 
                ss.ToString("00"), 
                ff.ToString("00"));
        }
    }
}
