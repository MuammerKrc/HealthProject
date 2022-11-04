using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models.BaseModels;

namespace CoreLayer.Models.PackageModel
{
    public class Package : BaseModel<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<PackageItem> PackageItems { get; set; } = new();
    }
}
