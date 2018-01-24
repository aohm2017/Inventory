using System;
using System.Collections.Generic;

namespace Inventory.Models
{
    public partial class MakeupProduct
    {
        public Guid Id { get; set; }
        public string Product { get; set; }
        public string Brand { get; set; }
        public double? Ounce { get; set; }
        public double? Price { get; set; }
        public double? PricePerOunce { get; set; }
        public string ProductLink { get; set; }
        public string Comments { get; set; }
        public DateTime DatePurchased { get; set; }
        public Guid? MakeupCategory { get; set; }

        public MakeupCategory MakeupCategoryNavigation { get; set; }
    }
}
