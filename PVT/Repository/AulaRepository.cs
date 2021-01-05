using PVT.Context;
using PVT.Interface;
using PVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Repository
{
    public class AulaRepository : GenericRepository<Aula>, IAulaRepository
    {
        public AulaRepository(MyDbContext _context):base(_context)
        {

        }
    }
}
