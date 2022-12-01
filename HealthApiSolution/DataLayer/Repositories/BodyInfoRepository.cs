using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IRepository;
using CoreLayer.Models.BodyInfoModels;
using CoreLayer.Models.PilatesModels;
using DataLayer.DbContexts;
using DataLayer.Repositories.BaseRepositories;

namespace DataLayer.Repositories
{
    public class BodyInfoRepository : BaseRepository<BodyInfo, int>,IBodyInfoRepository
    {
        public BodyInfoRepository(HealthDbContext context) : base(context)
        {
        }
    }
}
