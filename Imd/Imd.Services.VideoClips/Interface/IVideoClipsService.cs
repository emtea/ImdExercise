using Imd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Imd.Domain.Enums;

namespace Imd.Services.VideoClips.Interfaces
{
    public interface IVideoClipsService
    {
        IList<VideoClip> RetrieveVideClips(int vStandard, int vDefinition);

    }
}
