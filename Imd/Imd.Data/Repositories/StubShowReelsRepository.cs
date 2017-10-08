using Imd.Data.Interfaces;
using Imd.Domain.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static Imd.Domain.Enums;

namespace Imd.Data.Repositories
{
    public class StubShowReelsRepository : IShowReelsRepository<ShowReel>
    {
        private IList<ShowReel> showReels;
        private IVideoClipsRepository<VideoClip> videoClipsRepository;

        public StubShowReelsRepository(IVideoClipsRepository<VideoClip> videoClipsRepository)
        {
            this.videoClipsRepository = videoClipsRepository;

            var all_PAL_SD_Clips = videoClipsRepository.GetAll().Where(vc =>
                                        vc.VStandard == VideoStandard.PAL
                                        && vc.VDefinition == VideoDefinition.SD)
                                        .ToList();

            var all_NTSC_SD_Clips = videoClipsRepository.GetAll().Where(vc =>
                                        vc.VStandard == VideoStandard.NTSC
                                        && vc.VDefinition == VideoDefinition.SD)
                                        .ToList();

            showReels = new List<ShowReel>()
            {
                new ShowReel
                {
                    Id = Guid.NewGuid(),
                    Name = "Sample Reel - all PAL/SD",
                    VStandard = VideoStandard.PAL,
                    VDefinition = VideoDefinition.SD,
                    VideoClips = all_PAL_SD_Clips
                },
                new ShowReel
                {
                    Id = Guid.NewGuid(),
                    Name = "Another Reel - all NTSC/SD",
                    VStandard = VideoStandard.NTSC,
                    VDefinition = VideoDefinition.SD,
                    VideoClips = all_NTSC_SD_Clips
                }
            };
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ShowReel Get(Guid id)
        {
            return showReels.Where(reel => reel.Id == id).FirstOrDefault();
        }

        public IList<ShowReel> GetAll()
        {
            return showReels;
        }

        public IList<ShowReel> GetAll(Guid userId)
        {
            return showReels;
        }

        public ShowReel Update(ShowReel obj)
        {
            throw new NotImplementedException();
        }
    }
}
