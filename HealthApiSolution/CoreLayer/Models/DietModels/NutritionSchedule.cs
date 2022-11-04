using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BaseModels;

namespace CoreLayer.Models.DietModels
{
    public class NutritionSchedule : BaseModel<int>
    {
        public List<NutritionScheduleItem> NutritionScheduleItems { get; set; }
    }
}
