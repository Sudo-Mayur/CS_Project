using System;
using System.Collections.Generic;

namespace Clinic_Managment_System.Models
{
    public partial class PatientInfo
    {
        public int PatientRegNo { get; set; }
        public string PatName { get; set; } = null!;
        public string PatAddress { get; set; } = null!;
        public string? MobileNo { get; set; }
        public int? Age { get; set; }
        public int Wieght { get; set; }
        public string? PatBp { get; set; }
        public string? Cholestrol { get; set; }
        public string? Sugur { get; set; }
        public string Medicines { get; set; } = null!;
        public string FirstApdate { get; set; } = null!;
        public int FirstApfees { get; set; }

        public virtual PatientInfo1 PatientInfo1 { get; set; } = null!;
    }
}
