using PVT.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Domain.Interface
{
    public interface ITipoAulaRepository : IRepository<TipoAula>
    {
       Task<IEnumerable<dynamic>> ListagemTipoAula();
    }

}
