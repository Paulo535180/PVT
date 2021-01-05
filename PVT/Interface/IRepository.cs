using PVT.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Interface
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        //Métodos Basicos
        Task<IList<T>> SelectAll();
        Task<T> SelectId(int id);
        Task Update(T objeto);
        Task Insert(T objeto);
        Task Delete(int id);

    }
}
