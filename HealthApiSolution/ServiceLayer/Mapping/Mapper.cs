using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoreLayer.Dtos.AnamnesisFormDtos;
using CoreLayer.Dtos.BodyInfoDtos;
using CoreLayer.Dtos.BuyingReportsDtos;
using CoreLayer.Dtos.DietDtos;
using CoreLayer.Dtos.IdentityDtos;
using CoreLayer.Dtos.PackageDtos;
using CoreLayer.Dtos.PilatesDtos;
using CoreLayer.Dtos.TokenDtos;
using CoreLayer.Models;
using CoreLayer.Models.AnamnesisFormModels;
using CoreLayer.Models.BodyInfoModels;
using CoreLayer.Models.BuyingReportsModel;
using CoreLayer.Models.DietModels;
using CoreLayer.Models.IdentityModels;
using CoreLayer.Models.JwtModels;
using CoreLayer.Models.PackageModel;
using CoreLayer.Models.PilatesModels;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer.Mapping
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<AppUser, AppUserDto>().ReverseMap();
            CreateMap<AnamnesisFormDto, AnamnesisForm>().ReverseMap();
            CreateMap<BodyInfoDto, BodyInfo>().ReverseMap();
            CreateMap<BuyingReportsDto, BuyingReport>().ReverseMap();
            CreateMap<DietDto, Diet>().ReverseMap();
            CreateMap<DietWeeklyDto, DietWeekly>().ReverseMap();
            CreateMap<NutritionScheduleDto, NutritionSchedule>().ReverseMap();
            CreateMap<NutritionScheduleItemDto, NutritionScheduleItem>().ReverseMap();
            CreateMap<PackageDto, Package>().ReverseMap();
            CreateMap<PackageItemDto, PackageItem>().ReverseMap();
            CreateMap<PilatesDto, Pilates>().ReverseMap();
            CreateMap<JWToken, TokenDto>().ReverseMap();
        }
    }
}
