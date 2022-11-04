using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.Models.BodyInfoModels;
using CoreLayer.Models.PilatesModels;

namespace CoreLayer.IRepository
{
    public interface IBodyInfoRepository : IBaseRepository<BodyInfo, int>
    {

    }
}
