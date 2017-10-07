using System;
using System.Collections.Generic;
using System.Text;
using static Imd.Domain.Enums;

namespace Imd.Domain.Models
{
    public class ShowReel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public VideoStandard VStandard { get; set; }
        public VideoDefinition VDefinition { get; set; }
        public TimeCode Duration { get; set; }

        public ShowReel()
        {
        }

        public ShowReel(string name, VideoStandard vStandard, VideoDefinition vDefinition, TimeCode duration)
        {
            Name = name;
            VStandard = vStandard;
            VDefinition = vDefinition;
            Duration = duration;
        }
    }
}
