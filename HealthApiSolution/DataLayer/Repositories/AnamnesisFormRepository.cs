using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IRepository;
using CoreLayer.Models.AnamnesisFormModels;
using DataLayer.DbContexts;
using DataLayer.Repositories.BaseRepositories;

namespace DataLayer.Repositories
{
    public class AnamnesisFormRepository : BaseRepository<AnamnesisForm, int>,IAnamnesisFormRepository
    {
        public AnamnesisFormRepository(HealthDbContext context) : base(context)
        {
        }
    }
}
