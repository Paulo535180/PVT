using PVT.Domain.Models;

namespace PVT.Domain.Interface
{
    public interface IModuloRepository : IRepository<Modulo>
    {
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<dynamic>> ListagemModulos();
    }

}
