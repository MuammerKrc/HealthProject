using CoreLayer.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilatesController : ControllerBase
    {
        private IPilatesService pilatesService;

        public PilatesController(IPilatesService pilatesService)
        {
            this.pilatesService = pilatesService;
        }
    }
}
