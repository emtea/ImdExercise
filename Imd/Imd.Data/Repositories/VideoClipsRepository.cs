using Imd.Data.Interfaces;
using Imd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Imd.Domain.Enums;

namespace Imd.Data.Repositories
{
    public class VideoClipsRepository : IVideoClipsRepository<VideoClip>
    {
        public IList<VideoClip> Get(VideoStandard vStandard, VideoDefinition vDefinition)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public VideoClip Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<VideoClip> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<VideoClip> GetAll(Guid userId)
        {
            throw new NotImplementedException();
        }

        public VideoClip Update(VideoClip obj)
        {
            throw new NotImplementedException();
        }

        public VideoClip Create(VideoClip obj)
        {
            throw new NotImplementedException();
        }
    }
}
