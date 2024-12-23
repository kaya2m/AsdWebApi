using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Common;
using Domain;

namespace Application.Services
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task<ResponseDto<IEnumerable<T>>> SqlRawAsync(string sql);
        Task<ResponseDto<IEnumerable<T>>> GetAllAsync();
        Task<ResponseDto<T>> GetByIdAsync(int id);
        ResponseDto<IQueryable<T>> Where(Expression<Func<T, bool>> predicate);
        Task<ResponseDto<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<ResponseDto<T>> AddAsync(T entity);
        Task<ResponseDto<IEnumerable<T>>> AddRangeAsync(IEnumerable<T> entities);
        ResponseDto<EmptyDto> Update(T entity);
        ResponseDto<EmptyDto> UpdateRange(IEnumerable<T> entities);
        ResponseDto<EmptyDto> Remove(int id);
        ResponseDto<EmptyDto> RemoveRange(IEnumerable<T> entities);
        ResponseDto<EmptyDto> SoftRemove(int id);
        ResponseDto<EmptyDto> SoftRemoveRange(IEnumerable<int> ids);
    }
}
