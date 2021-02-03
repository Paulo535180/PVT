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
    public class SetorRepository : GenericRepository<Setor>, ISetorRepository
    {
        public SetorRepository(MyDbContext _context, IDbConnection _connection) : base(_context, _connection)
        {
        }

        public async Task<Setor> ListagemSetorPorId(Setor setor)
        {
            var teste = await _connection.QueryFirstOrDefaultAsync<Setor>($@" select * from PVT_SETOR where ID = @ID", setor);
            return teste;
        }

    }
}
