using System;
using System.Collections.Generic;

namespace Web_App_Job_Seeker.Models
{
    public partial class ProfessionalInfo
    {
        public int ProfessionalId { get; set; }
        public int PersonId { get; set; }
        public string WorkExperience { get; set; }
        public string Companies { get; set; }
        public string ProjectInfo { get; set; }

        public virtual PersonalInfo Person { get; set; }
    }
}
