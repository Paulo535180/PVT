using PVT.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Domain.Interface
{
    public interface IDisciplinaRepository : IRepository<Disciplina>
    {
        Task<IEnumerable<dynamic>> Listagem(int idCurso);
    }

}
