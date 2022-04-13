using System;
using System.Collections.Generic;

namespace Web_App_Job_Seeker.Models
{
    public partial class EducationalInfo
    {
        public int EducationId { get; set; }
        public int PersonId { get; set; }
        public string SscboardName { get; set; }
        public double Sscpercentage { get; set; }
        public int SscpassingDate { get; set; }
        public string HscboardName { get; set; }
        public double? Hscpercentage { get; set; }
        public int HscpassingDate { get; set; }
        public string DiplomaBoardName { get; set; }
        public double? DiplomaPercentage { get; set; }
        public int DiplomaPassingDate { get; set; }
        public string DegreeUniversityName { get; set; }
        public double? DegreePercentage { get; set; }
        public string DegreeType { get; set; }
        public int DegreePassingDate { get; set; }
        public string MastersUniversityName { get; set; }
        public double? MastersPercentage { get; set; }
        public int MastersPassingDate { get; set; }
        public string HighestQuaification { get; set; }

        public virtual PersonalInfo Person { get; set; }
    }
}
