using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BaseModels;
using CoreLayer.Models.IdentityModels;

namespace CoreLayer.Models.PilatesModels
{
    public class Pilates : BaseModel<int>
    {
        public string? UserId { get; set; }

        [ForeignKey("UserId")]
        public AppUser? User { get; set; }
        public List<PilatesWeekly> PilatesWeeklies { get; set; } = new();
    }
}
