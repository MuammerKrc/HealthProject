using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoreLayer.Dtos;
using CoreLayer.Dtos.IdentityDtos;
using CoreLayer.Exceptions;
using CoreLayer.IRepositories;
using CoreLayer.IServices;
using CoreLayer.Models.IdentityModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ServiceLayer.Mapping;

namespace ServiceLayer.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _contextAccessor;
        IMapper _mapper;
        public UserService(UserManager<AppUser> userManager, IHttpContextAccessor contextAccessor, IMapper mapper)
        {
            _userManager = userManager;
            _contextAccessor = contextAccessor;
            _mapper = mapper;
        }

        public async Task<AppUserDto> GetCurrentUser()
        {
            if (_contextAccessor.HttpContext?.User?.Identity?.IsAuthenticated ?? false)
            {
                var userName = _contextAccessor.HttpContext.User.Identity.Name;
                var user = await _userManager.FindByNameAsync(userName);
                return _mapper.Map<AppUserDto>(user);
            }

            throw new UserCreateException("User not authenticated");
        }

        public async Task<IdentityResult> CreateAsyncCustomer(CreateUserDto model)
        {
            try
            {
                IdentityResult result = await _userManager.CreateAsync(new AppUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = model.Name,
                    Surname = model.Surname,
                    FullName = (model.Name ?? "") + " " + (model.Surname ?? ""),
                    Email = model.Email,
                    UserName = Guid.NewGuid().ToString(),
                    IsCustomer = true
                }, model.Password);

                return result;
            }
            catch (Exception e)
            {
                throw new UserCreateException();
            }
        }
        public async Task<IdentityResult> CreateAsync(CreateUserDto model)
        {
            try
            {
                IdentityResult result = await _userManager.CreateAsync(new AppUser()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = model.Name,
                    Surname = model.Surname,
                    FullName = (model.Name ?? "") + " " + (model.Surname ?? ""),
                    Email = model.Email,
                    UserName = Guid.NewGuid().ToString(),
                    IsCustomer = false
                }, model.Password);

                //if (!result.Succeeded)
                //    return Response<NoResponse>.ErrorResponse(result.Errors.Select(i => i.Description).ToList());
                //return Response<NoResponse>.SuccessResponse(message: "Kullanıcı başarı ile oluşturuldu");
                return result;
            }
            catch (Exception e)
            {
                throw new UserCreateException();
            }
        }

        public async Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime refreshExpirationDate)
        {
            user.RefreshToken = refreshToken;
            user.RefreshTokenEndDate = refreshExpirationDate;
            await _userManager.UpdateAsync(user);
        }



        public Task UpdatePasswordAsync(string userId, string resetToken, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}
