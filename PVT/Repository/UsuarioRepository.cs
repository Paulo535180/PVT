using Dapper;
using Microsoft.AspNetCore.Mvc;
using PVT.Context;
using PVT.Interface;
using PVT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioRepository(IDbConnection connection)
        {
            db = connection;
        }

        private readonly IDbConnection db;
        public async Task<Usuario> validarLogin(Usuario usuario)
        {
            return await db.QueryFirstOrDefaultAsync<Usuario>($@"
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

                where LOGIN = @Login and USISTEMA_PERFIL.SISTEMA = 49 AND SENHA = @Password ", usuario);
        }

        public async Task<List<Usuario>> Listagem ()
        {
            var lista = await db.QueryAsync<Usuario>($@"
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

                where USISTEMA.SIGLA = 'PVT' ");
            return lista.ToList();
        }
    }
}
