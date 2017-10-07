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
    }
}
