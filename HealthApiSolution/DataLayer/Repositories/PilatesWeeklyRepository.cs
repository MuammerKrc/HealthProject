using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IRepository;
using CoreLayer.Models.PilatesModels;
using DataLayer.DbContexts;
using DataLayer.Repositories.BaseRepositories;

namespace DataLayer.Repositories
{
    public class PilatesWeeklyRepository : BaseRepository<PilatesWeekly, int>, IPilatesWeeklyRepository
    {
        public PilatesWeeklyRepository(HealthDbContext context) : base(context)
        {
        }
    }
}
