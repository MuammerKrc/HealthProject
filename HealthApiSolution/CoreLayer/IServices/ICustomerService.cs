using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Dtos.IdentityDtos;
using CoreLayer.IServices.IBaseServices;
using CoreLayer.Models.IdentityModels;

namespace CoreLayer.IServices
{
    public interface ICustomerService
    {
        Task<List<AppUserDto>> GetAllCustomer();
    }
}
