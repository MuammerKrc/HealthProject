using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoreLayer.Dtos.PilatesDtos;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IServices;
using CoreLayer.Models.PilatesModels;
using ServiceLayer.Services.BaseServices;

namespace ServiceLayer.Services
{
    public class PilatesService:BaseService<Pilates,PilatesDto,int>,IPilatesService
    {
        public PilatesService(IBaseRepository<Pilates, int> baseRepository, IMapper mapper) :base(baseRepository,mapper)
        {

        }
    }
}
