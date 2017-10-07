using System;
using System.Collections.Generic;
using System.Text;
using static Imd.Domain.Enums;

namespace Imd.Domain.Models
{
    public class ShowReel
    {
        public string Name { get; set; }
        public VideoStandard VStandard { get; set; }
        public VideoDefinition VDefinition { get; set; }
        public TimeCode Duration { get; set; }
    }
}
