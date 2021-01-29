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
    public class ModuloRepository : GenericRepository<Modulo>, IModuloRepository
    {

        
        public ModuloRepository(MyDbContext _context, IDbConnection _connection) : base(_context, _connection)
        {
        }

        public Task<object> ListagemGestoresPorSetor(int idSetor)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<dynamic>> ListagemModulos()
        {

            return await _connection.QueryAsync($@"
                select UUSUARIO.NOME as Responsavel,
                PVT_MODULO.*

                from PVT_MODULO


                INNER JOIN PVT_USUARIO_GESTOR on PVT_USUARIO_GESTOR.ID = PVT_MODULO.ID_USUARIO_GESTOR
                INNER JOIN UUSUARIO ON UUSUARIO.ID = PVT_USUARIO_GESTOR.ID_USUARIO");
        }
    }
}
