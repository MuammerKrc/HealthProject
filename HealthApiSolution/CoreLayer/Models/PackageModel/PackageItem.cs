using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Dtos;
using CoreLayer.Enums;
using CoreLayer.Models.BaseModels;

namespace CoreLayer.Models.PackageModel
{
    public class PackageItem : BaseModel<int>
    {
        public PackageType PackageType { get; set; }
        public int Total { get; set; }
        public int PackageId { get; set; }
        public Package? Package { get; set; }
    }
}
