using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoreLayer.Dtos;
using CoreLayer.Dtos.PackageDtos;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.IRepository;
using CoreLayer.IServices;
using CoreLayer.Models.PackageModel;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.BaseServices;

namespace ServiceLayer.Services
{
    public class PackageService : BaseService<Package, PackageDto, int>, IPackageService
    {
        private readonly IPackageItemRepository _packageItemRepository;
        public PackageService(IBaseRepository<Package, int> baseRepository, IMapper mapper, IPackageItemRepository packageItemRepository) : base(baseRepository, mapper)
        {
            _packageItemRepository = packageItemRepository;
        }

        public async Task<List<PackageDto>> GetallPackageWithPackageItem()
        {
            var results = await _repository._entities.Where(i => true).Include(i => i.PackageItemRelations).ToListAsync();
            var result = await _repository.GetWhereAsync(i => true).Include(i => i.PackageItemRelations).ToListAsync();
            return _mapper.Map<List<PackageDto>>(result);
        }

        public async Task<PackageDto> CreateCustomPackage(PackageItemDto dto)
        {

            var packages = _mapper.Map<PackageItem>(dto);
            _packageItemRepository.Add(packages);
            await _packageItemRepository.SaveAsync();

            return new PackageDto();
        }

    }
}
