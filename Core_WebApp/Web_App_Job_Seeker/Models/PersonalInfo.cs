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
        //[Remote(action: "ValidateName", controller: "PersonalInfo", ErrorMessage = "Enter Candidate Name in Proper Formate Like Mayur Mahadev Chavan")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Candidate AddressLine1 is Required")]
        public string AddressLine1 { get; set; }
        [Required(ErrorMessage = "Candidate City is Required")]
        public string City { get; set; }
        [Required(ErrorMessage = "PinCode is Required")]
        [PinCode(ErrorMessage = "Please Enter The Pin Code in Proper Format")]
        public string PinCode { get; set; }

        [Number(ErrorMessage = "Please Enter Correct Contact Number")]
        public string ContactNo { get; set; }
        [Email(ErrorMessage = "Please Enter  Email in Correct Format")]
        public string Email { get; set; }
        public string ImageFilePath { get; set; }
        public string ProfileFilePath { get; set; }

        public virtual ICollection<EducationalInfo> EducationalInfos { get; set; }
        public virtual ICollection<ProfessionalInfo> ProfessionalInfos { get; set; }
    }
}


