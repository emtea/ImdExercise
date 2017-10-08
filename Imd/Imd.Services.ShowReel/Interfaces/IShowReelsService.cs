using Imd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imd.Services.ShowReels.Interfaces
{
    public interface IShowReelsService
    {
        IList<ShowReel> RetrieveReelsPerUser();
        ShowReel ReelUpsert(ShowReel showReel);
        ShowReel RetrieveReel(Guid id);
    }
}
