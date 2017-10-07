using System;
using System.Collections.Generic;
using System.Text;

namespace Imd.Data.Interfaces
{
    public interface IRepository<T>
    {
        IList<T> GetAll();
        IList<T> GetAll(Guid userId);
        T Get(Guid id);
        T Update(T obj);
        T Delete(Guid id);
    }
}
