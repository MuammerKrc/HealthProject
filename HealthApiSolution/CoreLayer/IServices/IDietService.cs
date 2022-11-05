using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Dtos.DietDtos;
using CoreLayer.IServices.IBaseServices;
using CoreLayer.Models.DietModels;

namespace CoreLayer.IServices
{
    public interface IDietService : IBaseService<Diet, DietDto, int>
    {

    }
}
