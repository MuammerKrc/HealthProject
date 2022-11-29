using CoreLayer.Dtos.IdentityDtos;
using CoreLayer.IServices;
using CoreLayer.Models.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ServiceLayer.Services;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace WebLayer.Controllers
{
    public class AccountController : _baseController
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IUserService userService) : base(userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
        }

        public IActionResult SignIn(string ReturnUrl)
        {
            TempData["ReturnUrl"] = ReturnUrl;
            return View(new LoginDto());
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginDto model)
        {
            string failedExceptionDesc = "Kullanıcı adı veya şifre hatalı";
            bool lockoutUserWhenFailed = false;
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", failedExceptionDesc);
                return View(model);
            }

            SignInResult loginResult =
                await _signInManager.PasswordSignInAsync(user, model.Password, true, lockoutUserWhenFailed);

            if (!loginResult.Succeeded)
            {
                ModelState.AddModelError("", failedExceptionDesc);
                return View(model);
            }

            if (TempData["ReturnUrl"] != null && !string.IsNullOrEmpty(TempData["ReturnUrl"].ToString()))
            {
                return Redirect(TempData["ReturnUrl"].ToString());
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult SignUp()
        {

            return View(new CreateUserDto());
        }


        [HttpPost]
        public async Task<IActionResult> SignUp(CreateUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = model.GetNewUser();
            IdentityResult result = await _userService.CreateAsyncCustomer(user); 
            if (!result.Succeeded)
            {
                result.Errors.ToList().ForEach(i => { ModelState.AddModelError("", i.Description); });
                return View(model);
            }

            return RedirectToAction("SignIn");
        }
    }
}
