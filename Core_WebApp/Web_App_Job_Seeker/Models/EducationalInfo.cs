using System;
using System.Collections.Generic;

#nullable disable

namespace Web_App_Job_Seeker.Models
{
    public partial class EducationalInfo
    {
        public int EducationId { get; set; }
        public int PersonId { get; set; }
        public string SscboardName { get; set; }
        public double Sscpercentage { get; set; }
        public int SscpassingYear { get; set; }
        public string HscboardName { get; set; }
        public double? Hscpercentage { get; set; }
        public int? HscpassingYear { get; set; }
        public string DiplomaBoardName { get; set; }
        public double? DiplomaPercentage { get; set; }
        public int? DiplomaPassingYear { get; set; }
        public string DegreeUniversityName { get; set; }
        public double? DegreePercentage { get; set; }
        public int? DegreePassingYear { get; set; }
        public string MastersUniversityName { get; set; }
        public double? MastersPercentage { get; set; }
        public int? MastersPassingYear { get; set; }
        public string HighestQuaification { get; set; }

        public virtual PersonalInfo Person { get; set; }
    }
}
