using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Enums;
using CoreLayer.Models.BaseModels;
using CoreLayer.Models.RecipesModels;
using Microsoft.VisualBasic;

namespace CoreLayer.Models.DietModels
{
    public class NutritionScheduleItem : BaseModel<int>
    {
        public int NutritionScheduleId { get; set; }
        [ForeignKey("NutritionScheduleId")]
        public NutritionSchedule? NutritionSchedule { get; set; }
        public MealTimeType MealTimeType { get; set; }
        public string? GeneralInfo { get; set; }
        public string? Description { get; set; }
        public string? TimeInterval { get; set; }
        public List<DietDividedIntoDays>? DietDividedIntoDays { get; set; }
    }
}
