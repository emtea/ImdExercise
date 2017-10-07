using Imd.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imd.Data.Interfaces
{
    public interface IShowReelsRepository<T> : IRepository<T> where T: ShowReel
    {
        
    }
}
