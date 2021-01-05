using PVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Interface
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> Listagem();
        Task<Usuario> validarLogin(Usuario usuario);

    }
}
