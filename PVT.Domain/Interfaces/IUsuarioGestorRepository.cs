using PVT.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Domain.Interface
{
    public interface IUsuarioGestorRepository : IRepository<UsuarioGestor>
    {
        Task<IEnumerable<UsuarioGestor>> ListagemGestores();
        Task<IEnumerable<dynamic>> ListagemGestoresPorSetor(int idSetor);
        Task<UsuarioGestor> Select(UsuarioGestor usuarioGestor);
    }
}
