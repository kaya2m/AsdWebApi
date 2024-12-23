using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> SqlRawAsync(string sql);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Remove(int id);
        void RemoveRange(IEnumerable<T> entities);
        void SoftRemove(int id);
        void SoftRemoveRange(IEnumerable<T> entities);
    }
}
