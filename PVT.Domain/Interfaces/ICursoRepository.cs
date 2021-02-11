using PVT.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Domain.Interface
{
    public interface ICursoRepository : IRepository<Curso>
    {
        Task<IEnumerable<dynamic>> Listagem(int idGestor);
    }

}
