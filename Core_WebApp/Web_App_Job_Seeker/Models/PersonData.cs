using System.ComponentModel.DataAnnotations;

namespace Web_App_Job_Seeker.Models
{
    public class PersonData
    {
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string HighestQuaification { get; set; }
        public string Image { get; set; }
        public string City { get; set; }

    }
}
//personDatas.Add(new PersonData() { FullName = d.Fullname, ContactNo = d.ContactNo, Email = d.Email, HighestQuaification = d.HighestQuaification, Image = d.ImageFilePath, PersonID = d.PersonID });

//Full Name COntact No Email Highest Quaification IMage
