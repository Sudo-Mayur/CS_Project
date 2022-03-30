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
            f.PersonId = res1.PersonId;
            f.FullName = res1.FullName;
            f.ContactNo = res1.ContactNo;
            f.Address= res1.Address;
            f.Email = res1.Email;
            f.ImageFile = res1.ImageFilePath;
            f.ProfileFile= res1.ProfileFilePath;

            var res2 = EduService.GetByIdAsync(id).Result;
            f.SscboardName= res2.SscboardName;
            f.Sscpercentage= res2.Sscpercentage;
            f.SscpassingYear= res2.SscpassingYear;
            f.HscboardName=res2.HscboardName;
            f.Hscpercentage= res2.Hscpercentage;
            f.HscpassingYear=res2.HscpassingYear;
            f.DiplomaBoardName=res2.DiplomaBoardName;
            f.DiplomaPercentage= res2.DiplomaPercentage;
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
    }
}
