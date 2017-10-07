using System;
using System.Collections.Generic;
using System.Text;
using static Imd.Domain.Enums;

namespace Imd.Domain.Models
{
    public class VideoClip
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public VideoStandard VStandard { get; set; }
        public VideoDefinition VDefinition { get; set; }
        public TimeCode Start { get; set; }
        public TimeCode End { get; set; }

        public VideoClip()
        {
        }

        public VideoClip(string name, string description, VideoStandard vStandard, VideoDefinition vDefinition, TimeCode start, TimeCode end)
        {
            Name = name;
            Description = description;
            VStandard = vStandard;
            VDefinition = vDefinition;
            Start = start;
            End = end;
        }
    }
}
