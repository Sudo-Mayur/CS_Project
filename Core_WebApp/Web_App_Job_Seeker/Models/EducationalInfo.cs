using System;
using System.Collections.Generic;

#nullable disable

namespace Web_App_Job_Seeker.Models
{
    public partial class EducationalInfo
    {
        public int EducationId { get; set; }
        public int PersonId { get; set; }
        public string SscschoolName { get; set; }
        public string SscboardName { get; set; }
        public double? Sscpercentage { get; set; }
        public string HsccollegeName { get; set; }
        public string HscboardName { get; set; }
        public double? Hscpercentage { get; set; }
        public string DegreeCollegeName { get; set; }
        public string DegreeUniversityName { get; set; }
        public double? DegreePercentage { get; set; }
        public string MastersUniversityName { get; set; }
        public double? MastersPercentage { get; set; }

        public virtual PersonalInfo Person { get; set; }
    }
}
