using PVT.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Domain.Interface
{
    
    public interface ISetorRepository : IRepository<Setor>
    {
        Task<Setor>ListagemSetorPorId(Setor setor);
    }
    

}
