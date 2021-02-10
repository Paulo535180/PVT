using Dapper;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using PVT.Service.Data;
using System.Data;
using System.Threading.Tasks;

namespace PVT.Service.Repository
{
    public class SetorModuloRepository : GenericRepository<SetorModulo>, ISetorModuloRepository
    {
        public SetorModuloRepository(MyDbContext _context, IDbConnection _connection) : base(_context, _connection)
        {

        }

        public async Task<SetorModulo> BuscarSetorModulo(SetorModulo setorModulo)
        {
            var teste = await _connection.QueryFirstOrDefaultAsync<SetorModulo>($@"select * from PVT_SETOR_MODULO where ID_MODULO = @ID_MODULO AND ID_SETOR = @ID_SETOR", setorModulo);

            return teste;

        }
    }
}
