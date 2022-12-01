using CoreLayer.Enums;
using CoreLayer.Models.PackageModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dtos.PackageDtos
{
    public class PackageItemDto : BaseDto<int>
    {
        public PackageType PackageType { get; set; }
        public string Title { get; set; }
        public int Total { get; set; }
        public int PackageId { get; set; }
        public PackageDto? Package { get; set; }
    }
}
