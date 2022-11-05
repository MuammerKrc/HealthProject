using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoreLayer.Dtos.PackageDtos;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IServices;
using CoreLayer.Models.PackageModel;
using ServiceLayer.Services.BaseServices;

namespace ServiceLayer.Services
{
    public class PackageService:BaseService<Package,PackageDto,int>,IPackageService
    {
        public PackageService(IBaseRepository<Package, int> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {

        }
    }
}
