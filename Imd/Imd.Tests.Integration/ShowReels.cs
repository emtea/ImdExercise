using Imd.Data.Interfaces;
using Imd.Domain.Models;
using Imd.Services.ShowReels.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Imd.Domain.Enums;

namespace Imd.Tests.Integration
{
    [TestClass]
    public class ShowReels
    {
        private IShowReelsService showReelsService;
        private IShowReelsRepository<ShowReel> showReelsRepository;

        public ShowReels(IShowReelsService showReelsService, IShowReelsRepository<ShowReel> showReelsRepository) 
        {
            this.showReelsService = showReelsService;
            this.showReelsRepository = showReelsRepository;
        }

        [TestMethod]
        public void RetrieveReels_ById_ReturnsItem()
        {
            //Arrange
            var newId = Guid.NewGuid();
            var showReel = showReelsRepository.Create(new ShowReel
            {
                Name = DateTime.Now.ToString(),
                VDefinition = VideoDefinition.HD,
                VStandard = VideoStandard.PAL
            });

            //Act
            var result = showReelsService.RetrieveReel(newId);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id == showReel.Id);
        }
    }
}
