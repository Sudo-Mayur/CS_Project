using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Web_App_Job_Seeker.Models;
using Web_App_Job_Seeker.Services;

namespace Web_App_Job_Seeker.Controllers
{
    public class PersonalInfoController : Controller
    {
        private readonly IService<PersonalInfo, int> PerService;
        private readonly IService<EducationalInfo, int> EduService;
        private readonly IService<ProfessionalInfo, int> ProService;

        public PersonalInfoController(IService<PersonalInfo, int> PerService, IService<EducationalInfo, int> EduService, IService<ProfessionalInfo, int> ProService)
        {
            this.PerService = PerService;
            this.EduService = EduService;
            this.ProService = ProService;
        }

        public IActionResult Index()
        {
            //var resPer = PerService.GetAsync().Result;
            //var resEdu = EduService.GetAsync().Result;
            ////Full Name COntact No Email Highest Quaification IMage

            //var Resultant = from e in resPer
            //                join d in resEdu on
            //                e.PersonId equals d.PersonId
            //                select new
            //                {
            //                    Fullname = e.FullName,
            //                    ContactNo = e.ContactNo,
            //                    Email = e.Email,
            //                    Designation = e.Designation,
            //                    DeptName = d.DeptName,
            //                    Email = e.Email,
            //                    Tax = e.Tax
            //                };
            var res=PerService.GetAsync().Result;
            return View(res);
        }

        public IActionResult Create()
        {
            var personalInfo = new PersonalInfo();
            return View(personalInfo);
        }
        [HttpPost]
        public IActionResult Create(PersonalInfo personalInfo)
        {
            var res=PerService.CreateAsync(personalInfo).Result;
            return RedirectToAction("CreateEdu");

        }

        public IActionResult CreateEdu()
        {
            var educationalInfo=new EducationalInfo();
            return View(educationalInfo);
        }
        [HttpPost]
        public IActionResult CreateEdu(EducationalInfo educationalInfo)
        {
            var res = EduService.CreateAsync(educationalInfo).Result;
            return RedirectToAction("CreatePro");

        }

        public IActionResult CreatePro()
        {
            var professionalInfo=new ProfessionalInfo();
            return View(professionalInfo);
        }
        [HttpPost]
        public IActionResult CreatePro(ProfessionalInfo professionalInfo)
        {
            var res = ProService.CreateAsync(professionalInfo).Result;
            return RedirectToAction("Index");
        }

    }
}
