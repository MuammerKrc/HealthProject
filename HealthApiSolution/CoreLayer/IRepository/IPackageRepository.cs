using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.Models.PackageModel;

namespace CoreLayer.IRepository
{
    public interface IPackageRepository : IBaseRepository<Package, int>
    {
    }
}
