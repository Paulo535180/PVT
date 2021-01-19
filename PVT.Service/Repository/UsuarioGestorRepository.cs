using Dapper;
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
    public class UsuarioGestorRepository : GenericRepository<UsuarioGestor>, IUsuarioGestorRepository
    {
        public UsuarioGestorRepository(MyDbContext _context, IDbConnection _connection) : base(_context, _connection)
        {
        }

        public async Task<IEnumerable<UsuarioGestor>> ListagemGestores()
        {

            return await _connection.QueryAsync<UsuarioGestor>($@"
                select UUSUARIO.NOME as Nome,
                PVT_MODULO.*

                from PVT_MODULO


                INNER JOIN PVT_USUARIO_GESTOR on PVT_USUARIO_GESTOR.ID = PVT_MODULO.ID_USUARIO_GESTOR
                INNER JOIN UUSUARIO ON UUSUARIO.ID = PVT_USUARIO_GESTOR.ID_USUARIO");
        }

    }
}
