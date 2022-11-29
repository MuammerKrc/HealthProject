using CoreLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.IServices.IBaseServices
{
    public interface IBaseService<TModel, TDto, TKey>
    {
        Task<NoResponse> CreateAsync(TDto dto);
        Task<TDto> GetByIdAsync(TKey id);
        Task<NoResponse> DeleteAsync(TKey id);
        Task<List<TDto>> GetAllAsync();
    }
}
