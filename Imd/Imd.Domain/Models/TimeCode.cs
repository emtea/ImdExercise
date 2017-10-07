using System;
using System.Collections.Generic;
using System.Text;

namespace Imd.Domain.Models
{
    public class TimeCode
    {
        public short HH { get; set; }
        public short MM { get; set; }
        public short ss { get; set; }
        public short ff { get; set; }

        public TimeCode(short HH, short MM, short ss, short ff)
        {
            this.HH = HH;
            this.MM = MM;
            this.ss = ss;
            this.ff = ff;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}:{2}:{3}", HH, MM, ss, ff);
        }
    }
}
