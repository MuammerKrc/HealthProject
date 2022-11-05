using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoreLayer.Dtos.DietDtos;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IServices;
using CoreLayer.IServices.IBaseServices;
using CoreLayer.Models.DietModels;
using ServiceLayer.Services.BaseServices;

namespace ServiceLayer.Services
{
    public class DietService:BaseService<Diet,DietDto,int>,IDietService
    {
        public DietService(IBaseRepository<Diet, int> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {

        }
    }
}

