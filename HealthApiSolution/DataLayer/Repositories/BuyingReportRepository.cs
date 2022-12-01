using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IRepository;
using CoreLayer.Models.BuyingReportsModel;
using DataLayer.DbContexts;
using DataLayer.Repositories.BaseRepositories;

namespace DataLayer.Repositories
{
    public class BuyingReportRepository : BaseRepository<BuyingReport, int>,IBuyingReportRepository
    {
        public BuyingReportRepository(HealthDbContext context) : base(context)
        {
        }
    }
}
