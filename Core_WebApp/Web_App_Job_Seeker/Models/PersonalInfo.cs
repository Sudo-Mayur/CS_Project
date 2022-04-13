using System;
using System.Collections.Generic;

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
        public string FullName { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string ImageFilePath { get; set; }
        public string ProfileFilePath { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<EducationalInfo> EducationalInfos { get; set; }
        public virtual ICollection<ProfessionalInfo> ProfessionalInfos { get; set; }
    }
}
