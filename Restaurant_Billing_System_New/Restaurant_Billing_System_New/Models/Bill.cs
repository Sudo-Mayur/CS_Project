using System;
using System.Collections.Generic;

namespace Restaurant_Billing_System_New.Models
{
    public partial class Bill
    {
        public DateTime? Date { get; set; }
        public int BillNo { get; set; }
        public int? CustomorId { get; set; }
        public string? CustName { get; set; }
        public string? MobileNo { get; set; }
        public int? TableNo { get; set; }
        public double? SubTotal { get; set; }
        public double? Tax { get; set; }
        public double? TotalBill { get; set; }
        public string? PaymentMode { get; set; }

        public virtual CustomorInfo? Customor { get; set; }
    }
}
