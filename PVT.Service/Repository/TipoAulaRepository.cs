using PVT.Domain.Interface;
using PVT.Domain.Models;
using PVT.Service.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PVT.Service.Repository
{
    public class TipoAulaRepository : GenericRepository<TipoAula>, ITipoAulaRepository
    {
        public TipoAulaRepository(MyDbContext _context, IDbConnection _connection) : base(_context, _connection)
        {

        }
    }
}
