using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoreLayer.Dtos;
using CoreLayer.Dtos.IdentityDtos;
using CoreLayer.IServices;
using CoreLayer.Models.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.BaseServices;

namespace ServiceLayer.Services
{
    public class CustomerService:ICustomerService
    {
        private UserManager<AppUser> _userManager;
        private IMapper _mapper;
        public CustomerService(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<List<AppUserDto>> GetAllCustomer()
        {
            var result= _mapper.Map<List<AppUserDto>>(await _userManager.Users.Where(i => i.IsCustomer).ToListAsync());
            return result;
        }
    }
}
