using Dapper;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using System.Data;
using System.Threading.Tasks;

namespace PVT.Service.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        protected readonly IDbConnection _connection;
        public UsuarioRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<Usuario> ValidarLogin(Usuario usuario)
        {
            return await _connection.QueryFirstOrDefaultAsync<Usuario>($@"
                select UUSUARIO.ID as ID,
                Nome AS NOME,
                email AS EMAIL,
                UUSUARIO.SENHA AS Password,
                UPERFIL.PERFIL AS PERFIL,
                UUSUARIO.LOGIN AS LOGIN

                from UUSUARIO

                INNER JOIN USISTEMA_USUARIO ON USISTEMA_USUARIO.USUARIO = UUSUARIO.ID

                INNER JOIN USISTEMA_PERFIL ON USISTEMA_PERFIL.ID = USISTEMA_USUARIO.SISTEMA_PERFIL

                INNER JOIN UPERFIL ON USISTEMA_PERFIL.PERFIL = UPERFIL.ID

                INNER JOIN USISTEMA on USISTEMA_PERFIL.SISTEMA = USISTEMA.ID

                where UUSUARIO.ID IN (728,18) AND USISTEMA.SIGLA = 'PVT' ", usuario);
        }
    }
}


