using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BaseModels;
using CoreLayer.Models.PilatesModels;

namespace CoreLayer.Models.DietModels
{
    public class DietWeekly : BaseModel<int>
    {
        public int Queue { get; set; }
        public bool IsCompleted { get; set; } = false;
        public bool IsNextItem { get; set; } = false;
        public DateTime? AppointmentDate { get; set; }
        public int DietId { get; set; }

        [ForeignKey("DietId")]
        public Diet? Diet { get; set; }
        public NutritionSchedule NutritionSchedule { get; set; }
    }
}
