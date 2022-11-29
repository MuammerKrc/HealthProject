using Microsoft.AspNetCore.Mvc;

namespace WebLayer.Controllers
{
    public class PackageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
