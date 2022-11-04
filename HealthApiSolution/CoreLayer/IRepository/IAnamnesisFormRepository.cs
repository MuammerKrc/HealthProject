using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IRepositories.IBaseRepositories;
using CoreLayer.Models.AnamnesisFormModels;

namespace CoreLayer.IRepository
{
    public interface IAnamnesisFormRepository : IBaseRepository<AnamnesisForm, int>
    {
    }
}
