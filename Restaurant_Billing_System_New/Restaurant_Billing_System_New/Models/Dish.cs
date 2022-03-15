using System;
using System.Collections.Generic;

namespace Restaurant_Billing_System_New.Models
{
    public partial class Dish
    {
        public Dish()
        {
            DishInfos = new HashSet<DishInfo>();
        }

        public int DishNo { get; set; }
        public string DishName { get; set; } = null!;
        public double Rate { get; set; }

        public virtual ICollection<DishInfo> DishInfos { get; set; }
    }
}
