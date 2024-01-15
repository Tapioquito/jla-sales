using JLASales.Business.Models;
using System.Linq.Expressions;

namespace JLASales.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        void Add(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        void Update(TEntity entity);
        void Remove(Guid id);
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> prdicate);
        Task<int> SaveChanges();
        //retorna o número de linhas afetadas no commit
        //O que interessa é ser MAIOR que zero
    }
}
