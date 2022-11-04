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
        Task<Response<NoResponse>> CreateAsync(TDto dto);
        Task<Response<TDto>> GetByIdAsync(TKey id);
        Task<Response<NoResponse>> DeleteAsync(TKey id);
        Task<Response<List<TDto>>> GetAllAsync();
    }
}
