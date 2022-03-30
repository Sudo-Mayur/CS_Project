using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Web_App_Job_Seeker.Models
{
    public partial class PersonalInfo
    {
        public PersonalInfo()
        {
            EducationalInfos = new HashSet<EducationalInfo>();
            ProfessionalInfos = new HashSet<ProfessionalInfo>();
        }

        public int PersonId { get; set; }
        [Name(ErrorMessage = "Enter Candidate Name in Proper Formate Like Mayur Mahadev Chavan")]
        [Required(ErrorMessage = "Candidate Name is Required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Candidate Address is Required")]
        public string Address { get; set; }
        [Number(ErrorMessage = "Please Enter Correct Contact Number")]
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string ImageFilePath { get; set; }
        public string ProfileFilePath { get; set; }

        public virtual ICollection<EducationalInfo> EducationalInfos { get; set; }
        public virtual ICollection<ProfessionalInfo> ProfessionalInfos { get; set; }
    }
}
