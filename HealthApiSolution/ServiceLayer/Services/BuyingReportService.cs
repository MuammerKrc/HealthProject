using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoreLayer.Dtos.BuyingReportsDtos;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IRepository;
using CoreLayer.IServices;
using CoreLayer.Models.BuyingReportsModel;
using ServiceLayer.Services.BaseServices;

namespace ServiceLayer.Services
{
    public class BuyingReportService:BaseService<BuyingReport,BuyingReportsDto,int>,IBuyingReportsService
    {
        public BuyingReportService(IBaseRepository<BuyingReport, int> repository, IMapper mapper) : base(repository, mapper)
        {
        }

    }
}
