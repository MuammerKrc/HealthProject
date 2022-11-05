using CoreLayer.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietController : ControllerBase
    {
        private IDietService dietService;

        public DietController(IDietService dietService)
        {
            this.dietService = dietService;
        }

    }
}
