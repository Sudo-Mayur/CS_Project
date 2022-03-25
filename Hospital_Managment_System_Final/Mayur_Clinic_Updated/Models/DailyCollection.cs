using System;
using System.Collections.Generic;

namespace Mayur_Clinic_Updated.Models
{
    public partial class DailyCollection
    {
        public int RecordNo { get; set; }
        public DateTime? Apdate { get; set; }
        public double? Fees { get; set; }

        public virtual PatientInfo RecordNoNavigation { get; set; } = null!;
    }
}
