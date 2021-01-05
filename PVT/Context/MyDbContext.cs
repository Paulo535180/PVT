using Microsoft.EntityFrameworkCore;
using PVT.Models;

namespace PVT.Context
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<SetorModulo> SetorModulo { get; set; }
        public DbSet<TipoAula> TiposAulas { get; set; }
        public DbSet<UsuarioGestor> UsuariosGestores { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }




    }
}
