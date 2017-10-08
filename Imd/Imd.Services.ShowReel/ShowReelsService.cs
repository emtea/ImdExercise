using Imd.Services.ShowReels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Imd.Domain.Models;
using Imd.Data.Interfaces;

namespace Imd.Services.ShowReels
{
    public class ShowReelsService : IShowReelsService
    {
        private IShowReelsRepository<ShowReel> showReelsRepository;

        public ShowReelsService(IShowReelsRepository<ShowReel> repo)
        {
            this.showReelsRepository = repo;
        }

        public IList<ShowReel> RetrieveReelsPerUser()
        {
            return showReelsRepository.GetAll();
        }

        public ShowReel ReelUpsert(ShowReel showReel)
        {
            ShowReel result;
            if(showReel.Id != null && showReel.Id != Guid.Empty)
            {
                result = showReelsRepository.Update(showReel);
            }
            else
            {
                result = showReelsRepository.Create(showReel);
            }
            return result;
        }

        public ShowReel RetrieveReel(Guid id)
        {
            return showReelsRepository.Get(id);
        }
    }
}
