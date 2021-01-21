using PVT.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Domain.Interface
{
    public interface IModuloRepository : IRepository<Modulo>
    {
        Task<IEnumerable<dynamic>> ListagemModulos();
    }

}
