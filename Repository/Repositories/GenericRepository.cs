using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Application.Repositories;
using Application.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbContext _context;

        public GenericRepository(IUnitOfWork unitOfWork, DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<T>> SqlRawAsync(string sql)
        {
            return await _dbSet.FromSqlRaw(sql).AsNoTracking().ToListAsync();

        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = await _dbSet.FindAsync(predicate);

            _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            _context.Entry(entity).State = EntityState.Detached;

            return entity;
        }

        public void Remove(int id)
        {
            var entity = _dbSet.Find(id);

            _context.Entry(entity).State = EntityState.Deleted;

            _dbSet.Remove(entity);

            _unitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }

            _dbSet.RemoveRange(entities);

            _unitOfWork.Commit();
        }

        //public void SoftRemove(int id)
        //{
        //    var entity = _dbSet.Find(id);
        //    if (entity != null)
        //    {
        //        entity.IsDeleted = true;

        //        _unitOfWork.Commit();
        //    }
        //}

        //public void SoftRemoveRange(IEnumerable<int> ids)
        //{
        //    throw new NotImplementedException();
        //}

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            _dbSet.Update(entity);

            _unitOfWork.Commit();
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _context.ChangeTracker.Clear();

            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }

            _dbSet.UpdateRange(entities);

            _unitOfWork.Commit();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            _context.ChangeTracker.Clear();
            var entities = _dbSet.Where(predicate).AsNoTracking();

            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }

            return entities;
        }
    }
}
