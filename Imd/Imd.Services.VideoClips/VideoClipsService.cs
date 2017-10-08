using Imd.Services.VideoClips.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Imd.Domain.Models;
using Imd.Data.Interfaces;
using Imd.Domain;
using static Imd.Domain.Enums;

namespace Imd.Services.VideoClips
{
    public class VideoClipsService : IVideoClipsService
    {
        private IVideoClipsRepository<VideoClip> videoClipsRepository;

        public VideoClipsService(IVideoClipsRepository<VideoClip> repo)
        {
            this.videoClipsRepository = repo;
        }

        public IList<VideoClip> RetrieveVideClips(int vStandard, int vDefinition)
        {
            return videoClipsRepository.Get((VideoStandard)vStandard, (VideoDefinition)vDefinition);
        }
    }
}
