using System;
using System.Collections.Generic;

namespace Hospital_Managment_System_Final.Models
{
    public partial class PatientInfo
    {
        public PatientInfo()
        {
            DailyCollections = new HashSet<DailyCollection>();
        }

        public int RecordNo { get; set; }
        public int PatientRegNo { get; set; }
        public string PatName { get; set; } = null!;
        public string PatAddress { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public int? Age { get; set; }
        public int? Wieght { get; set; }
        public double? PatBp { get; set; }
        public double? CholestrolHdl { get; set; }
        public double? CholestrolLdl { get; set; }
        public double? Sugurfast { get; set; }
        public double? SugurPotFast { get; set; }
        public string? Medicines { get; set; }
        public DateTime? Apdate { get; set; }
        public double? Fees { get; set; }

        public virtual ICollection<DailyCollection> DailyCollections { get; set; }
    }
}
