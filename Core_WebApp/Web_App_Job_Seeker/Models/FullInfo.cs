using System;

namespace Web_App_Job_Seeker.Models
{
    public class FullInfo
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string ImageFile { get; set; }
        public string ProfileFile { get; set; }

        public int EducationId { get; set; }
        public string SscboardName { get; set; }
        public double? Sscpercentage { get; set; }
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

        public int ProfessionalId { get; set; }
        public string WorkExperience { get; set; }
        public string Companies { get; set; }
        public string ProjectInfo { get; set; }

    }
}
