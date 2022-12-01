using CoreLayer.Dtos;
using CoreLayer.Dtos.PackageDtos;
using CoreLayer.IServices;
using CoreLayer.Models.PackageModel;
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

        [HttpGet]
        public async Task<IActionResult> GetAllPackages()
        {
            var result = await packageService.GetallPackageWithPackageItem();

            return Ok(QResponse<List<PackageDto>>.SuccessResponse(data: result));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await packageService.GetByIdAsync(id);
            return Ok(QResponse<PackageDto>.SuccessResponse(data: result));
        }

        [HttpPut]
        public async Task<IActionResult> Update(PackageDto dto)
        {
            //var result=await packageService.
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(PackageDto dto)
        {
            var result = await packageService.CreateAsync(dto);
            return Ok(QResponse<NoResponse>.SuccessResponse(result));
        }
        [HttpPost("custom-create")]
        public async Task<IActionResult> CreateCustomAsync(PackageItemDto dto)
        {
            var result = await packageService.CreateCustomPackage(dto);
            return Ok(QResponse<NoResponse>.SuccessResponse(new NoResponse()));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await packageService.DeleteAsync(id);
            return Ok(QResponse<NoResponse>.SuccessResponse(result));
        }
    }
}
