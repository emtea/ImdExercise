using System;
using System.Linq;
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
        public string VStandardString
        {
            get
            {
                return VStandard.ToString();
            }
        }

        public VideoDefinition VDefinition { get; set; }
        public string VDefinitionString
        {
            get
            {
                return VDefinition.ToString();
            }
        }

        public TimeCode Duration
        {
            get
            {
                if (VideoClips != null && VideoClips.Count > 0)
                {
                    return new TimeCode(new TimeSpan(VideoClips.Sum(vc => vc.Duration.Value.Ticks)));
                }
                else
                {
                    return new TimeCode(00, 00, 00, 00);
                }
            }
        }

        public string DurationString
        {
            get
            {
                return Duration.ToString();
            }
        }

        public IList<VideoClip> VideoClips { get; set; }

        public ShowReel()
        {
            VideoClips = new List<VideoClip>();
        }

        public ShowReel(string name, VideoStandard vStandard, VideoDefinition vDefinition)
        {
            Name = name;
            VStandard = vStandard;
            VDefinition = vDefinition;
            VideoClips = new List<VideoClip>();
        }
    }
}
