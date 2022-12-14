using CoreLayer.Models.JwtModels;
using CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BodyInfoModels;
using CoreLayer.Models.BuyingReportsModel;
using CoreLayer.Models.DietModels;
using CoreLayer.Models.PilatesModels;

namespace CoreLayer.Dtos.IdentityDtos
{
    public class AppUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
        public List<BuyingReport> BuyingReports { get; set; } = new();
        public Diet? Diet { get; set; }
        public Pilates? Pilates { get; set; }
        public BodyInfo? BodyInfo { get; set; }
        public bool IsCustomer { get; set; } = true;
    }
}
