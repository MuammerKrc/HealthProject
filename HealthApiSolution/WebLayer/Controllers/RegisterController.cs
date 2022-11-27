using Microsoft.AspNetCore.Mvc;

namespace WebLayer.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
