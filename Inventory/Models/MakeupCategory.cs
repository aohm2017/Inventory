using System;
using System.Collections.Generic;

namespace Inventory.Models
{
    public partial class MakeupCategory
    {
        public MakeupCategory()
        {
            MakeupProduct = new HashSet<MakeupProduct>();
        }

        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public ICollection<MakeupProduct> MakeupProduct { get; set; }
    }
}
