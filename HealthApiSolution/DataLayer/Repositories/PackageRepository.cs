using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IRepository;
using CoreLayer.Models.PackageModel;
using DataLayer.DbContexts;
using DataLayer.Repositories.BaseRepositories;

namespace DataLayer.Repositories
{
    public class PackageRepository : BaseRepository<Package, int>,IPackageRepository
    {
        public PackageRepository(MovieDbContext context) : base(context)
        {
        }
    }
}
