using System;
using System.Collections.Generic;

namespace Restaurant_Billing_System_Updated.Models
{
    public partial class DishInfo
    {
        public int LogId { get; set; }
        public int? CustomorId { get; set; }
        public int? DishNo { get; set; }
        public string? DishName { get; set; }
        public int? Quantity { get; set; }
        public double? Rate { get; set; }
        public double? Amount { get; set; }

        public virtual CustomorInfo? Customor { get; set; }
        public virtual Dish? DishNoNavigation { get; set; }
    }
}
