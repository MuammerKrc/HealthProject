using Microsoft.AspNetCore.Mvc;

namespace WebLayer.Controllers
{
	public class CustomerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
