using System;
using System.Collections.Generic;

namespace Restaurant_Billing_System_New.Models
{
    public partial class CustomorInfo
    {
        public CustomorInfo()
        {
            Bills = new HashSet<Bill>();
            DishInfos = new HashSet<DishInfo>();
        }

        public int CustomorId { get; set; }
        public string? CustName { get; set; }
        public string? MobileNo { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<DishInfo> DishInfos { get; set; }
    }
}
