﻿using Dapper;
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
    public class UsuarioGestorRepository : GenericRepository<UsuarioGestor>, IUsuarioGestorRepository
    {
        public UsuarioGestorRepository(MyDbContext _context, IDbConnection _connection) : base(_context, _connection)
        {
        }

        public async Task<IEnumerable<UsuarioGestor>> ListagemGestores()
        {

            return await _connection.QueryAsync<UsuarioGestor>($@"
                SELECT 
                UUSUARIO.NOME AS NOME_GESTOR,
                PVT_USUARIO_GESTOR. *

                FROM PVT_USUARIO_GESTOR

                INNER JOIN UUSUARIO ON UUSUARIO.ID = PVT_USUARIO_GESTOR.ID_USUARIO");
        }

        public async Task<IEnumerable<dynamic>> ListagemGestoresPorSetor(int idSetor)
        {

            return await _connection.QueryAsync($@"
                SELECT 
                UUSUARIO.NOME AS NOME_GESTOR,
                PVT_USUARIO_GESTOR. *

                FROM PVT_USUARIO_GESTOR

                INNER JOIN UUSUARIO ON UUSUARIO.ID = PVT_USUARIO_GESTOR.ID_USUARIO 
                where ID_SETOR = @idSetor", new { idSetor });
        }

        public Task<UsuarioGestor> Select(UsuarioGestor usuarioGestor)
        {
            return null;
        }
    }
}
