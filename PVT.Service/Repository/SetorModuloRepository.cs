using PVT.Domain.Interface;
using PVT.Domain.Models;
using PVT.Service.Data;
using System.Data;

namespace PVT.Service.Repository
{
    public class SetorModuloRepository : GenericRepository<SetorModulo>, ISetorModuloRepository
    {
        public SetorModuloRepository(MyDbContext _context, IDbConnection _connection) : base(_context, _connection)
        {

        }
    }
}
