using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Dtos.PackageDtos;
using CoreLayer.IServices.IBaseServices;
using CoreLayer.Models.PackageModel;

namespace CoreLayer.IServices
{
    public interface IPackageService:IBaseService<Package,PackageDto,int>
    {
    }
}
