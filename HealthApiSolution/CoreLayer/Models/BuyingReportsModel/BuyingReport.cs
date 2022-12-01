using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Enums;
using CoreLayer.Models.BaseModels;
using CoreLayer.Models.IdentityModels;
using CoreLayer.Models.PackageModel;

namespace CoreLayer.Models.BuyingReportsModel
{
    public class BuyingReport : BaseModel<int>
    {
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser? User { get; set; }
        public string Description { get; set; }
        public float TotalPrice { get; set; }
        public string PackageTitle { get; set; }
        public ICollection<PackageItem> PackageItems { get; set; }
        public PaymentResultType PaymentResultType { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
