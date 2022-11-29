using CoreLayer.Dtos.IdentityDtos;
using CoreLayer.Dtos;
using CoreLayer.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            var result=await customerService.GetAllCustomer();

            return Ok(QResponse<List<AppUserDto>>.SuccessResponse(data: result));
        }
    }
}
