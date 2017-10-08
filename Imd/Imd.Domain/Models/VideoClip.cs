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
        public TimeCode Duration
        {
            get
            {
                if (End != null && Start != null)
                {
                    TimeSpan timeVal;
                    int framesValue;

                    if (End.Frames - (Start.Frames - 1) < 0)
                    {
                        timeVal = End.TimeSpan.Subtract(Start.TimeSpan).Subtract(new TimeSpan(0, 0, 1));
                        framesValue = End.Frames - Start.Frames + (int)VStandard;
                    }
                    else
                    {
                        timeVal = End.TimeSpan.Subtract(Start.TimeSpan);
                        framesValue = End.Frames - Start.Frames;
                    }

                    return new TimeCode(timeVal, framesValue, VStandard);
                }
                else
                    return new TimeCode(0, 0, 0, 0, VStandard);
            }
        }

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
