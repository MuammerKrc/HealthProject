using CoreLayer.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private IPackageService packageService;

        public PackageController(IPackageService packageService)
        {
            this.packageService = packageService;
        }

    }
}
