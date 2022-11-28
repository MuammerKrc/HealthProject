using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.AnamnesisFormModels;
using CoreLayer.Models.BaseModels;
using CoreLayer.Models.IdentityModels;

namespace CoreLayer.Models.DietModels
{
    public class Diet : BaseModel<int>
    {

        public AnamnesisForm? AnamnesisForm { get; set; }
        public string? UserId { get; set; }

        [ForeignKey("UserId")]
        public AppUser? User { get; set; }
        public List<DietWeekly> DietWeeklies { get; set; } = new();
    }
}
