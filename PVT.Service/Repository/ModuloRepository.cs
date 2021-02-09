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
    public class ModuloRepository : GenericRepository<Modulo>, IModuloRepository
    {


        public ModuloRepository(MyDbContext _context, IDbConnection _connection) : base(_context, _connection)
        {
        }

        public async Task<IEnumerable<dynamic>> ListagemModulosPorUser(int idUser)
        {
            return await _connection.QueryAsync($@"
                Select 
                PVT_MODULO.*
                from PVT_MODULO

                INNER JOIN PVT_USUARIO_GESTOR ON PVT_USUARIO_GESTOR.ID = PVT_MODULO.ID_USUARIO_GESTOR
                INNER JOIN UUSUARIO ON PVT_USUARIO_GESTOR.ID_USUARIO = UUSUARIO.ID
                INNER JOIN PVT_SETOR_MODULO ON PVT_MODULO.ID = PVT_SETOR_MODULO.ID_MODULO
                WHERE PVT_MODULO.ID_USUARIO_GESTOR = @idUser", new { idUser });
        }

        public async Task<IEnumerable<dynamic>> ListagemModulos()
        {

            return await _connection.QueryAsync($@"
                select UUSUARIO.NOME as Responsavel,
                PVT_MODULO.*

                from PVT_MODULO


                INNER JOIN PVT_USUARIO_GESTOR on PVT_USUARIO_GESTOR.ID = PVT_MODULO.ID_USUARIO_GESTOR
                INNER JOIN UUSUARIO ON UUSUARIO.ID = PVT_USUARIO_GESTOR.ID_USUARIO");
        }

        public async Task<IEnumerable<dynamic>> ListagemModulosPorSetor(int idSetor)
        {
            return await _connection.QueryAsync($@"
            SELECT
            PVT_MODULO.*,
            UUSUARIO.NOME as RESPONSAVEL,
            PVT_SETOR_MODULO.ID as ID_SETOR_MODULO,
            PVT_SETOR_MODULO.ID_SETOR,
            PVT_SETOR.NOME AS NOME_SETOR
            from PVT_MODULO
            inner join PVT_SETOR_MODULO on PVT_SETOR_MODULO.ID_MODULO = PVT_MODULO.ID
            inner join PVT_SETOR on PVT_SETOR_MODULO.ID_SETOR = PVT_SETOR.ID 
            inner join PVT_USUARIO_GESTOR on PVT_USUARIO_GESTOR.ID_SETOR = PVT_SETOR.ID 
            inner join UUSUARIO on UUSUARIO.ID = PVT_USUARIO_GESTOR.ID_USUARIO 

            where PVT_SETOR.ID = @idSetor", new { idSetor });
        }
    }
}
