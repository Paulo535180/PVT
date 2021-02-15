using PVT.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Domain.Interface
{
    public interface IModuloRepository : IRepository<Modulo>
    {
        Task<IEnumerable<dynamic>> ListagemModulos();
        Task<IEnumerable<dynamic>> ListagemModulosPorUser(int idUser);
        Task<IEnumerable<dynamic>> ListagemModulosPorSetor(int idSetor);
        Task<IEnumerable<dynamic>> ListagemModulosSemVinculo(int idSetor);
    }

}
