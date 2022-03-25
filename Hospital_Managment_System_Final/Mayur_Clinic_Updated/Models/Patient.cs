using System;
using System.Collections.Generic;

namespace Mayur_Clinic_Updated.Models
{
    public partial class Patient
    {
        public Patient()
        {
            PatientInfos = new HashSet<PatientInfo>();
        }

        public int PatientRegNo { get; set; }
        public string PatName { get; set; } = null!;
        public string PatAddress { get; set; } = null!;
        public string MobileNo { get; set; } = null!;

        public virtual ICollection<PatientInfo> PatientInfos { get; set; }
    }
}
