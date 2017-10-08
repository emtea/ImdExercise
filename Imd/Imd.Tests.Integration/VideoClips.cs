using Imd.Data.Interfaces;
using Imd.Domain.Models;
using Imd.Services.ShowReels.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using static Imd.Domain.Enums;

namespace Imd.Tests.Integration
{
    [TestClass]
    public class VideoClips
    {
        private IShowReelsService showReelsService;
        private IShowReelsRepository<ShowReel> showReelsRepository;
        private IVideoClipsRepository<VideoClip> videoClipsRepository;

        public VideoClips(IShowReelsService showReelsService, 
            IShowReelsRepository<ShowReel> showReelsRepository,
            IVideoClipsRepository<VideoClip> videoClipsRepository) 
        {
            this.showReelsService = showReelsService;
            this.showReelsRepository = showReelsRepository;
            this.videoClipsRepository = videoClipsRepository;
        }

        [TestMethod]
        public void CalculateClipsDuration_WithPALAndSD_DurationCorrect()
        {
            //Arrange


            //Act
            var all_PAL_SD_Clips = videoClipsRepository.GetAll().Where(vc =>
                                        vc.VStandard == VideoStandard.PAL
                                        && vc.VDefinition == VideoDefinition.SD)
                                        .ToList();

            //Assert
        }
    }
}
