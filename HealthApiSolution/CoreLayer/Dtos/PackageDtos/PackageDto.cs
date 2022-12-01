using CoreLayer.Models.PackageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dtos.PackageDtos
{
    public class PackageDto : BaseDto<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TotalSalary { get; set; }
        public List<PackageItemDto> PackageItemRelations { get; set; } = new();
    }
}
