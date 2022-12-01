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
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class PackageRepository : BaseRepository<Package, int>,IPackageRepository
    {
        public DbSet<PackageItem> _packageItemsRepository;

        public PackageRepository(HealthDbContext context) : base(context)
        {
            _packageItemsRepository = _context.Set<PackageItem>();
        }
        

    }
}
