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

        public StubShowReelsRepository()
        {
            showReels = new List<ShowReel>()
            {
                new ShowReel
                {
                    Id = Guid.NewGuid(),
                    Name = "Sample Reel",
                    VStandard = VideoStandard.NTSC,
                    VDefinition = VideoDefinition.HD
                },
                new ShowReel
                {
                    Id = Guid.NewGuid(),
                    Name = "Another Reel",
                    VStandard = VideoStandard.PAL,
                    VDefinition = VideoDefinition.SD
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
