using System;
using System.Collections.Generic;

namespace Hospital_Managment_System_Final.Models
{
    public partial class DailyCollection
    {
        public int RecordNo { get; set; }
        public int PatientRegNo { get; set; }
        public DateTime? Apdate { get; set; }
        public double? Fees { get; set; }

        public virtual PatientInfo PatientRegNoNavigation { get; set; } = null!;
    }
}
