using PVT.Domain.Interface;
using PVT.Domain.Models;
using PVT.Service.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PVT.Service.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        protected readonly IDbConnection _connection;
        public UsuarioRepository(IDbConnection connection)
        {
            _connection = connection;
        }


        public Task<Usuario> ValidarLogin(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}


