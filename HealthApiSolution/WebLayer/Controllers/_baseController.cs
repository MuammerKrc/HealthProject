using CoreLayer.Dtos.IdentityDtos;
using CoreLayer.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;

namespace WebLayer.Controllers
{
    public class _baseController : Controller
    {
        public IUserService _userService;

        public _baseController(IUserService userService)
        {
            _userService = userService;
        }

        public AppUserDto _getCurrentUser => _userService.GetCurrentUser().Result;
    }
}
