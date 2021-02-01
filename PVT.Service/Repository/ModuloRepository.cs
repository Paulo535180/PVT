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
                PVT_MODULO.ID as ID,
                PVT_MODULO.NOME as NOME,
                PVT_MODULO.DESCRICAO AS DESCRICAO,
                PVT_MODULO.USUARIO_CRIACAO AS AUTOR_MODULO,
                PVT_MODULO.DATA_CRIACAO as CRIACAO

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
    }
}
