using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BaseModels;
using CoreLayer.Models.RecipesModels;

namespace CoreLayer.Models.DietModels
{
    public class DietDividedIntoDays : BaseModel<long>
    {
        public string? HowManyDays { get; set; }
        public string? WhichDay { get; set; }
        public string? Description { get; set; }
        public int? DetoxRecipeId { get; set; }

        [ForeignKey("DetoxRecipeId")]
        public DetoxRecipe? DetoxRecipe { get; set; }
        public int? FoodRecipeId { get; set; }
        
        [ForeignKey("FoodRecipeId")]
        public FoodRecipe? FoodRecipe { get; set; }
    }
}
