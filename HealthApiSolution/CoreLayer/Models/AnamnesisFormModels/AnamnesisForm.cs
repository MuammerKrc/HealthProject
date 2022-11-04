using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BaseModels;
using CoreLayer.Models.DietModels;

namespace CoreLayer.Models.AnamnesisFormModels
{
    public class AnamnesisForm : BaseModel<int>
    {
        public int DietId { get; set; }
        [ForeignKey("DietId")]
        public Diet? Diet { get; set; }
        public string? Question1 { get; set; }
        public string? Question2 { get; set; }
        public string? Question3 { get; set; }
        public string? Question4 { get; set; }
        public string? Question5 { get; set; }
        public string? Question6 { get; set; }

    }
}
