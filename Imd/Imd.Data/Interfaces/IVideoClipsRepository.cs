using Imd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Imd.Domain.Enums;

namespace Imd.Data.Interfaces
{
    public interface IVideoClipsRepository<VideoClip> : IRepository<VideoClip>
    {
        IList<VideoClip> Get(VideoStandard vStandard, VideoDefinition vDefinition);
    }
}
