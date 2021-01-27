using PVT.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Domain.Interface
{
    public interface IUsuarioRepository
    {
        Task<IList<Usuario>> Listagem();
        Task<Usuario> ValidarLogin(Usuario usuario);

    }
}
