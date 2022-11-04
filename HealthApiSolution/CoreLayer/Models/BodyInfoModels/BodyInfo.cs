using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BaseModels;
using CoreLayer.Models.IdentityModels;

namespace CoreLayer.Models.BodyInfoModels
{
    public class BodyInfo : BaseModel<int>
    {
        public int Age { get; set; }
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser? User { get; set; }

    }
}
