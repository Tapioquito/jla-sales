using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using JLASales.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Data.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : Entity, new()
    {
        protected readonly JLASalesDBContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected BaseRepository(JLASalesDBContext db, DbSet<TEntity> dbSet)
        {
            Db = db;
            DbSet = dbSet;
        }

        public async virtual Task<TEntity> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }
        public Task<List<TEntity>> GetAll()
        {
            return DbSet.ToListAsync();
        }
        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> prdicate)
        {
            return await DbSet
                .AsNoTracking()
                .Where(prdicate)
                .ToListAsync();

        }
        public virtual void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }
        public virtual void Remove(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
        }

        public async Task<int> SaveChanges()
        {
           return await Db.SaveChangesAsync();
        }
        public void Dispose()
        {
            Db.Dispose();
        }


    }
}
