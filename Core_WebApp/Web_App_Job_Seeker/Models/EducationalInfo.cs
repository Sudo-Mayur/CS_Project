using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Web_App_Job_Seeker.Models
{
    public partial class EducationalInfo
    {
        public int EducationId { get; set; }
        public int PersonId { get; set; }
        [Required(ErrorMessage = "SSC Board name is Required")]
        public string SscboardName { get; set; }
        [Required(ErrorMessage = "SSC Percentage is Required")]
        [NonNegative(ErrorMessage = "Percentage must be Positive value")]
        public double? Sscpercentage { get; set; }
        [Required(ErrorMessage = "SSC Passing Year is Required")]
        [Year(ErrorMessage = "Add Year in Proper Format Like 2016")]
        public int SscpassingDate { get; set; }
        public string HscboardName { get; set; }
        [NonNegative(ErrorMessage = "Percentage must be Positive value")]
        public double? Hscpercentage { get; set; }
        public int HscpassingDate { get; set; }
        public string DiplomaBoardName { get; set; }
        [NonNegative(ErrorMessage = "Percentage must be Positive value")]
        public double? DiplomaPercentage { get; set; }
        public int DiplomaPassingDate { get; set; }
        public string DegreeUniversityName { get; set; }
        [NonNegative(ErrorMessage = "Percentage must be Positive value")]
        public double? DegreePercentage { get; set; }
        public string DegreeType { get; set; }
        public int DegreePassingDate { get; set; }
        public string MastersUniversityName { get; set; }
        [NonNegative(ErrorMessage = "Percentage must be Positive value")]
        public double? MastersPercentage { get; set; }
        public int MastersPassingDate { get; set; }
        public string HighestQuaification { get; set; }


        public virtual PersonalInfo Person { get; set; }
    }
}
