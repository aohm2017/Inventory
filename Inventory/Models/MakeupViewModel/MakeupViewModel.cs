using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Models.MakeupViewModel
{
    public class MakeupViewModel
    {
        public List<MakeupProduct> MakeupProduct { get; set; }
        public List<MakeupCategory> MakeupCategory { get; set; }
    }
}
