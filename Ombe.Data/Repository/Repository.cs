using Microsoft.EntityFrameworkCore;
using Ombe.Business.Interfaces;
using Ombe.Business.Models;
using Ombe.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Ombe.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly OmbeDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(OmbeDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

        public async Task<TEntity> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
    }
}
