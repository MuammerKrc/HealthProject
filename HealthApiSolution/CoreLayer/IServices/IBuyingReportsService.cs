using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Dtos.BuyingReportsDtos;
using CoreLayer.IServices.IBaseServices;
using CoreLayer.Models.BuyingReportsModel;

namespace CoreLayer.IServices
{
    public interface IBuyingReportsService:IBaseService<BuyingReport,BuyingReportsDto,int>
    {

    }
}
