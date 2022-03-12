using System;
using System.Collections.Generic;

namespace Clinic_Managment_System.Models
{
    public partial class PatientInfo1
    {
        public int PatientRegNo { get; set; }
        public string? NextDateAp { get; set; }
        public int NestApFees { get; set; }

        public virtual PatientInfo PatientRegNoNavigation { get; set; } = null!;
    }
}
