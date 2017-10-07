using Imd.Data.Interfaces;
using Imd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imd.Data.Repositories
{
    public class VideoClipsRepository : IVideoClipsRepository<VideoClip>
    {
        public VideoClip Delete(Guid id)
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
    }
}
