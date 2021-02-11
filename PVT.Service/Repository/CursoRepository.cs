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
    public class CursoRepository : GenericRepository<Curso>, ICursoRepository
    {
        public CursoRepository(MyDbContext _context, IDbConnection _connection) : base(_context, _connection)
        {

        }

        public async Task<IEnumerable<dynamic>> Listagem(int idGestor)
        {
            return await _connection.QueryAsync($@"
                    select
	                PVT_MODULO.NOME as NOME_MODULO,
	                PVT_CURSO.* 
                    from PVT_CURSO
	                join PVT_MODULO on PVT_MODULO.ID = PVT_CURSO.ID_MODULO
                    where PVT_MODULO.ID_USUARIO_GESTOR = @idGestor
                    ", new { idGestor} );
        }
    }
}
