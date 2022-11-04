using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.Models.DietModels;

namespace CoreLayer.IRepository
{
    public interface IDietWeeklyRepository : IBaseRepository<DietWeekly, int>
    {
    }
}
