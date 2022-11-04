using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BaseModels;

namespace CoreLayer.Models.PilatesModels
{
    public class PilatesWeekly : BaseModel<int>
    {
        public int Queue { get; set; }
        public bool IsCompleted { get; set; } = false;
        public bool IsNextItem { get; set; } = false;
        public DateTime? AppointmentDate { get; set; }
        public int PilatesId { get; set; }
        [ForeignKey("PilatesId")]
        public Pilates? Pilates { get; set; }
    }
}
