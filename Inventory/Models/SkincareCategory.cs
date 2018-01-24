using System;
using System.Collections.Generic;

namespace Inventory.Models
{
    public partial class SkincareCategory
    {
        public SkincareCategory()
        {
            SkincareProduct = new HashSet<SkincareProduct>();
        }

        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public ICollection<SkincareProduct> SkincareProduct { get; set; }
    }
}
