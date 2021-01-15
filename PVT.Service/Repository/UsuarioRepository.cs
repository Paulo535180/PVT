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
        UUSUARIO.LOGIN AS LOGIN,
		PVT_USUARIO_GESTOR.ID_SETOR as ID_SETOR

        from UUSUARIO

        INNER JOIN USISTEMA_USUARIO ON USISTEMA_USUARIO.USUARIO = UUSUARIO.ID and USISTEMA_USUARIO.ATIVO = 'T'

        INNER JOIN USISTEMA_PERFIL ON USISTEMA_PERFIL.ID = USISTEMA_USUARIO.SISTEMA_PERFIL and USISTEMA_PERFIL.ATIVO = 'T'

        INNER JOIN UPERFIL ON USISTEMA_PERFIL.PERFIL = UPERFIL.ID and UPERFIL.ATIVO = 'T'

        INNER JOIN USISTEMA on USISTEMA_PERFIL.SISTEMA = USISTEMA.ID and USISTEMA.ATIVO = 'T'

		left Join PVT_USUARIO_GESTOR on PVT_USUARIO_GESTOR.ID_USUARIO  = UUSUARIO.ID and PVT_USUARIO_GESTOR.STATUS = 1
        where USISTEMA.SIGLA = 'PVT' 
			and UUSUARIO.ATIVO = 'T' 
			and (PVT_USUARIO_GESTOR.ID_SETOR is not null or UPERFIL.PERFIL = 'ADMINISTRADOR')
		    and LOGIN = @Login AND SENHA = @Password", usuario);
        }
    }
}


