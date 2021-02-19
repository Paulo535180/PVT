using PVT.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Domain.Interface
{
    public interface IAulaRepository : IRepository<Aula>
    {
        Task<IEnumerable<dynamic>> Listagem(int idDisciplina);
    }

}
