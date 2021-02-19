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

    public class AulaRepository : GenericRepository<Aula>, IAulaRepository
    {
        public AulaRepository(MyDbContext _context, IDbConnection _connection) : base(_context, _connection)
        {

        }

        public async Task<IEnumerable<dynamic>> Listagem (int idDisciplina)
        {
            return await _connection.QueryAsync($@"
                   select * from PVT_AULA where ID_DISCIPLINA = @idDisciplina", new { idDisciplina });
        }
    }
}
