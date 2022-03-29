using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Web_App_Job_Seeker.Models;
using Web_App_Job_Seeker.Services;


namespace Web_App_Job_Seeker.Controllers
{
    public class JobSeekersListController : Controller
    {
        private readonly IService<PersonalInfo, int> PerService;
        private readonly IService<EducationalInfo, int> EduService;
        private readonly IService<ProfessionalInfo, int> ProService;

        

        public JobSeekersListController(IService<PersonalInfo, int> PerService, IService<EducationalInfo, int> EduService, IService<ProfessionalInfo, int> ProService)
        {
            this.PerService = PerService;
            this.EduService = EduService;
            this.ProService = ProService;
        }
        public IActionResult Index()
        {
            var resPer = PerService.GetAsync().Result;
            var resEdu = EduService.GetAsync().Result;

            //Full Name COntact No Email Highest Quaification IMage

            var Resultant = from e in resPer
                            join d in resEdu on
                            e.PersonId equals d.PersonId
                            select new
                            {
                                Fullname = e.FullName,
                                ContactNo = e.ContactNo,
                                Email = e.Email,
                                HighestQuaification=d.HighestQuaification,
                                ImageFilePath =e.ImageFilePath,
                                PersonID=e.PersonId,
                               
                            };

        
        List<PersonData> personDatas = new List<PersonData>();
            foreach (var d in Resultant)
            {
                personDatas.Add(new PersonData() { FullName = d.Fullname, ContactNo = d.ContactNo, Email = d.Email, HighestQuaification=d.HighestQuaification, Image =d.ImageFilePath , PersonID=d.PersonID});
            }

            return View(personDatas);
        }

        public IActionResult Details(int id)
        {
            FullInfo f = new FullInfo();
            var res1 = PerService.GetByIdAsync(id).Result;
            f.FullName = res1.FullName;
            f.ContactNo = res1.ContactNo;
            f.Address= res1.Address;
            f.Email = res1.Email;
            f.ImageFilePath = res1.ImageFilePath;
            f.ProfileFilePath= res1.ProfileFilePath;

            var res2 = EduService.GetByIdAsync(id).Result;
            f.SscboardName= res2.SscboardName;
            f.Sscpercentage= res2.Sscpercentage;
            f.SscpassingYear= res2.SscpassingYear;
            f.HscboardName=res2.HscboardName;
            f.Hscpercentage= res2.Hscpercentage;
            f.HscpassingYear=res2.HscpassingYear;
            f.DiplomaBoardName=res2.DiplomaBoardName;
            f.DegreePercentage= res2.DegreePercentage;
            f.DiplomaPassingYear= res2.DiplomaPassingYear;
            f.DegreeUniversityName= res2.DegreeUniversityName;
            f.DegreePercentage=res2.DegreePercentage;
            f.DegreePassingYear=res2.DegreePassingYear;
            f.MastersUniversityName=res2.MastersUniversityName ;
            f.MastersPercentage=res2.MastersPercentage;
            f.MastersPassingYear = res2.MastersPassingYear;

            var res3 = ProService.GetByIdAsync(id).Result;
            f.WorkExperience= res3.WorkExperience;
            f.Companies= res3.Companies;
            f.ProjectInfo= res3.ProjectInfo;
            
            return View(f);
        }

        //public int PersonId { get; set; }
        //public string FullName { get; set; }
        //public string Address { get; set; }
        //public string ContactNo { get; set; }
        //public string Email { get; set; }
        //public string ImageFilePath { get; set; }
        //public string ProfileFilePath { get; set; }

        //public string SscboardName { get; set; }
        //public double Sscpercentage { get; set; }
        //public int SscpassingYear { get; set; }
        //public string HscboardName { get; set; }
        //public double? Hscpercentage { get; set; }
        //public int? HscpassingYear { get; set; }
        //public string DiplomaBoardName { get; set; }
        //public double? DiplomaPercentage { get; set; }
        //public int? DiplomaPassingYear { get; set; }
        //public string DegreeUniversityName { get; set; }
        //public double? DegreePercentage { get; set; }
        //public int? DegreePassingYear { get; set; }
        //public string MastersUniversityName { get; set; }
        //public double? MastersPercentage { get; set; }
        //public int? MastersPassingYear { get; set; }
        //public string HighestQuaification { get; set; }

        //public string WorkExperience { get; set; }
        //public string Companies { get; set; }
        //public string ProjectInfo { get; set; }


    }
}
