using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.Models.BuyingReportsModel;

namespace CoreLayer.IRepository
{
    public interface IBuyingReportRepository : IBaseRepository<BuyingReport, int>
    {
    }
}
