using PVT.Context;
using PVT.Interface;
using PVT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Repository
{
    public class UsuarioGestorRepository : GenericRepository<UsuarioGestor>, IUsuarioGestorRepository
    {
        public UsuarioGestorRepository(MyDbContext _context) : base(_context)
        {

        }
    }
}
