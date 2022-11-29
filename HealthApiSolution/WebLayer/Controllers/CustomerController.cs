using CoreLayer.IServices;
using Microsoft.AspNetCore.Mvc;

namespace WebLayer.Controllers
{
    public class CustomerController : _baseController
    {
        public CustomerController(IUserService userService) : base(userService)
        {

        }


        public IActionResult Index()
        {

            return View(_getCurrentUser);
        }
    }
}
