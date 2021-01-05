using PVT.Context;
using PVT.Interface;
using PVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Repository
{
    public class SetorModuloRepository : GenericRepository<SetorModulo>, ISetorModuloRepository
    {
        public SetorModuloRepository(MyDbContext _context):base(_context)
        {

        }
    }
}
