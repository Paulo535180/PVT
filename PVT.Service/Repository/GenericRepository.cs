using Dapper;
using PVT.Domain.Interface;
using PVT.Domain.Models;
using PVT.Service.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PVT.Service.Repository
{
    public abstract class GenericRepository<T> : IRepository<T> where T : Entity, new()
    {
        protected readonly MyDbContext _context;
        protected readonly IDbConnection _connection;

        protected GenericRepository(MyDbContext context, IDbConnection connection)
        {
            _context = context;
            _connection = connection;
        }

        public async Task<IList<T>> SelectAll()
        {
            var lista = await _connection.GetListAsync<T>();
            return lista.ToList();
        }

        public virtual async Task<T> SelectId(int id)
        {
            return await _context.FindAsync<T>(id);
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
