using System;
using System.Collections.Generic;

namespace Web_App_Job_Seeker.Models
{
    public partial class Employeer
    {
        public int EmployeerId { get; set; }
        public string EmployeerName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public string OrgName { get; set; }
        public string OrgType { get; set; }
        public string OrganizationInfo { get; set; }
        public string OrgAddress { get; set; }
        public string District { get; set; }
        public string OrgState { get; set; }
        public string OrgContact { get; set; }
        public string UserId { get; set; }
    }
}
