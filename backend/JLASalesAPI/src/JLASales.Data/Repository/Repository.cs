using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using JLASales.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace JLASales.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {

        protected readonly JLASalesDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(JLASalesDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async virtual Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async virtual Task<TEntity> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }
        public async Task Add(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Update(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }


        public virtual async Task DeleteById(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }



        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public void Dispose()
        {
            Db?.Dispose();
        }



    }
}
