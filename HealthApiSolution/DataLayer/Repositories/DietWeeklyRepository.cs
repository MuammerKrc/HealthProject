using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IRepository;
using CoreLayer.Models.DietModels;
using DataLayer.DbContexts;
using DataLayer.Repositories.BaseRepositories;

namespace DataLayer.Repositories
{
    public class DietWeeklyRepository : BaseRepository<DietWeekly, int>,IDietWeeklyRepository
    {
        public DietWeeklyRepository(HealthDbContext context) : base(context)
        {
        }
    }
}
