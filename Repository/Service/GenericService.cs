using Application.DTOs.Common;
using Application.Repositories;
using Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _genericRepository;

        public GenericService(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<ResponseDto<IEnumerable<T>>> SqlRawAsync(string sql)
        {
            try
            {
                var result = await _genericRepository.SqlRawAsync(sql);

                if (result == null)
                {
                    return ResponseDto<IEnumerable<T>>.Fail("Herhangi bir veri bulunamadı.", 404, true);
                }

                return ResponseDto<IEnumerable<T>>.Success(result, 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<IEnumerable<T>>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }
        public async Task<ResponseDto<T>> AddAsync(T entity)
        {
            try
            {
                await _genericRepository.AddAsync(entity);

                return ResponseDto<T>.Success(entity, "Yeni kayıt başarıyla eklendi.", 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<T>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }

        public async Task<ResponseDto<IEnumerable<T>>> AddRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                await _genericRepository.AddRangeAsync(entities);

                return ResponseDto<IEnumerable<T>>.Success(entities, "Yeni kayıtlar başarıyla eklendi.", 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<IEnumerable<T>>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }

        public async Task<ResponseDto<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                var result = await _genericRepository.FindAsync(predicate);

                if (result == null)
                {
                    return ResponseDto<T>.Fail("Bu koşullara bağlı bir veri bulunamadı.", 404, true);
                }

                return ResponseDto<T>.Success(result, 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<T>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }

        public async Task<ResponseDto<IEnumerable<T>>> GetAllAsync()
        {
            try
            {
                var result = await _genericRepository.GetAllAsync();

                if (result == null)
                {
                    return ResponseDto<IEnumerable<T>>.Fail("Herhangi bir veri bulunamadı.", 404, true);
                }

                return ResponseDto<IEnumerable<T>>.Success(result, 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<IEnumerable<T>>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }

        public async Task<ResponseDto<T>> GetByIdAsync(int id)
        {
            try
            {
                var result = await _genericRepository.GetByIdAsync(id);

                if (result == null)
                {
                    return ResponseDto<T>.Fail("Bu ID'ye sahip bir veri bulunamadı.", 404, true);
                }

                return ResponseDto<T>.Success(result, 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<T>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }

        public ResponseDto<EmptyDto> Remove(int id)
        {
            try
            {
                _genericRepository.Remove(id);

                return ResponseDto<EmptyDto>.Success("Seçili kayıt başarıyla silindi.", 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<EmptyDto>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }

        public ResponseDto<EmptyDto> RemoveRange(IEnumerable<T> entities)
        {
            try
            {
                _genericRepository.RemoveRange(entities);

                return ResponseDto<EmptyDto>.Success("Seçili kayıtlar başarıyla silindi.", 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<EmptyDto>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }

        public ResponseDto<EmptyDto> SoftRemove(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseDto<EmptyDto> SoftRemoveRange(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }

      

        public ResponseDto<EmptyDto> Update(T entity)
        {
            try
            {
                _genericRepository.Update(entity);

                return ResponseDto<EmptyDto>.Success("Seçili kayıt başarıyla güncellendi.", 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<EmptyDto>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }

        public ResponseDto<EmptyDto> UpdateRange(IEnumerable<T> entities)
        {
            try
            {
                _genericRepository.UpdateRange(entities);

                return ResponseDto<EmptyDto>.Success("Seçili kayıt başarıyla güncellendi.", 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<EmptyDto>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }

        public ResponseDto<IQueryable<T>> Where(Expression<Func<T, bool>> predicate)
        {
            try
            {
                var result = _genericRepository.Where(predicate);

                if (result == null)
                {
                    return ResponseDto<IQueryable<T>>.Fail("Bu koşullara bağlı bir veri bulunamadı.", 404, true);
                }

                return ResponseDto<IQueryable<T>>.Success(result, 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<IQueryable<T>>.Fail(new ErrorDto(ex.Message, true), "İşlem gerçekleştirilirken sistemsel bir hata meydana geldi.", 500);
            }
        }
    }
}
