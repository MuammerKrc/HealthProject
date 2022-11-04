using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.Models;
using CoreLayer.Models.DietModels;
using DataLayer.DbContexts;
using DataLayer.Repositories.BaseRepositories;

namespace DataLayer.Repositories
{
    public class DietRepository : BaseRepository<Diet, int>,IDietRepository
    {
        public DietRepository(MovieDbContext context) : base(context)
        {
        }
    }
}
