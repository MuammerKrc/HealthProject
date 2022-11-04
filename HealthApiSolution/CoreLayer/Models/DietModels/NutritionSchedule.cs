using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BaseModels;

namespace CoreLayer.Models.DietModels
{
    public class NutritionSchedule : BaseModel<int>
    {
        public int DietWeeklyId { get; set; }
        [ForeignKey("DietWeeklyId")]
        public DietWeekly? DietWeekly { get; set; }
        public List<NutritionScheduleItem> NutritionScheduleItems { get; set; }
    }
}
