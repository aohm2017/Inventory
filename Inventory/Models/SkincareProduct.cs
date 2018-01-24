using System;
using System.Collections.Generic;

namespace Inventory.Models
{
    public partial class SkincareProduct
    {
        public Guid Id { get; set; }
        public string Product { get; set; }
        public string Brand { get; set; }
        public double? Ounces { get; set; }
        public double? Price { get; set; }
        public double? PricePerOunce { get; set; }
        public string ProductLink { get; set; }
        public string Comments { get; set; }
        public DateTime DatePurchased { get; set; }
        public Guid? SkincareCategory { get; set; }

        public SkincareCategory SkincareCategoryNavigation { get; set; }
    }
}
