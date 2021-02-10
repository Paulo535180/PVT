using PVT.Domain.Models;
using System.Threading.Tasks;

namespace PVT.Domain.Interface
{
    public interface ISetorModuloRepository : IRepository<SetorModulo>
    {
        Task<SetorModulo> BuscarSetorModulo(SetorModulo setorModulo);
    }
}
