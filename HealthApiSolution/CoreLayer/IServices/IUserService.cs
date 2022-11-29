using CoreLayer.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Dtos;
using CoreLayer.Dtos.IdentityDtos;
using Microsoft.AspNetCore.Identity;

namespace CoreLayer.IServices
{
    public interface IUserService
    {
        Task<IdentityResult> CreateAsyncCustomer(CreateUserDto model);
        Task<IdentityResult> CreateAsync(CreateUserDto model);
        Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime refreshTokenExpiration);
        Task UpdatePasswordAsync(string userId, string resetToken, string newPassword);
        Task<AppUserDto> GetCurrentUser();
    }
}
