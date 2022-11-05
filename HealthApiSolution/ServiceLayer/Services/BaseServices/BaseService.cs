using AutoMapper;
using CoreLayer.ConfigurationModels;
using CoreLayer.Dtos;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IServices.IBaseServices;
using CoreLayer.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.BaseServices
{
    public class BaseService<TModel, TDto, TKey> : IBaseService<TModel, TDto, TKey> where TModel : BaseModel<TKey>
    {
        IBaseRepository<TModel, TKey> _repository;
        IMapper _mapper;


        public BaseService(IBaseRepository<TModel, TKey> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public   async Task<Response<NoResponse>> CreateAsync(TDto dto)
        {
            var model = _mapper.Map<TModel>(dto);
            _repository.Add(model);
            await _repository.SaveAsync();
            return Response<NoResponse>.SuccessResponse();
        }

        public  async Task<Response<NoResponse>> DeleteAsync(TKey id)
        {
            await _repository.Delete(id);
            await _repository.SaveAsync();
            return Response<NoResponse>.SuccessResponse();
        }

        public  async Task<Response<List<TDto>>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();
            return Response<List<TDto>>.SuccessResponse(_mapper.Map<List<TDto>>(result));
        }

        public  async Task<Response<TDto>> GetByIdAsync(TKey id)
        {
            var result = await _repository.GetByIdAsync(id);
            return Response<TDto>.SuccessResponse(_mapper.Map<TDto>(result));
        }
    }
}
