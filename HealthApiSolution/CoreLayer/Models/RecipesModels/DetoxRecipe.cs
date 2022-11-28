using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BaseModels;

namespace CoreLayer.Models.RecipesModels
{
    public class DetoxRecipe : BaseModel<int>
    {
        public string Description { get; set; }
        public string? Link { get; set; }
    }
}
