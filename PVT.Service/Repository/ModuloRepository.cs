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
    }
}
