using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.Models;
using CoreLayer.Models.DietModels;

namespace CoreLayer.IRepositories
{
    public interface IDietRepository : IBaseRepository<Diet, int>
    {

    }
}
