using Microsoft.EntityFrameworkCore;
using PVT.Context;
using PVT.Interface;
using PVT.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PVT.Repository
{
    //Esta classe tem sua funcionalidade valida somente se for uma herança de Entity.
    public abstract class GenericRepository<T> : IRepository<T> where T : Entity, new()
    {
        //Criando parametro do Contexto do banco
        protected readonly MyDbContext _context;

        //protected readonly DbSet<T> DbSet;
        public GenericRepository(MyDbContext myDbContext)
        {
            _context = myDbContext;
        }

        public virtual async Task<IList<T>> SelectAll()
        {
            var tabela = _context.Set<T>();
            return await tabela.AsNoTracking().ToListAsync();
        }

        public virtual async Task<T> SelectId(int id)
        {
            var tabela = _context.Set<T>();
            return await tabela.FindAsync(id);
        }

        public virtual async Task Insert(T objeto)
        {
            _context.Set<T>().Add(objeto);
            await SaveChanges();

        }

        public virtual async Task Update(T objeto)
        {
            _context.Update(objeto);
            await SaveChanges();
        }

        public virtual async Task Delete(int id)
        {
            _context.Remove(new T { ID = id });
            await SaveChanges();
        }

        public virtual async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

    }
}
