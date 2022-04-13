using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web_App_Job_Seeker.Models;
using Web_App_Job_Seeker.Services;
using Web_App_Job_Seeker.SessionExtension;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Web_App_Job_Seeker.Controllers
{
    //[Authorize(Policy = "JobSeekerPolicy")]
    [Authorize(Roles = "JobSeeker")]
    public class ShowMyDetailsController : Controller
    {
        private readonly IService<PersonalInfo, int> PerService;
        private readonly IService<EducationalInfo, int> EduService;
        private readonly IService<ProfessionalInfo, int> ProService;

        public ShowMyDetailsController(IService<PersonalInfo, int> PerService, IService<EducationalInfo, int> EduService, IService<ProfessionalInfo, int> ProService)
        {
            this.PerService = PerService;
            this.EduService = EduService;
            this.ProService = ProService;
        }
        public IActionResult Search()
        {
            return View(new PersonalInfo());
        }

        [HttpPost]
        public async Task<IActionResult> Search(PersonalInfo id)
        {
            HttpContext.Session.SetInt32("PersonId", id.PersonId);
            return RedirectToAction("GetInfo");
        }


        public IActionResult GetInfo()
        {
            var id = HttpContext.Session.GetString("LoginID");
            var res1 = PerService.GetAsync().Result.Where(x => x.UserId == id).FirstOrDefault();
           
            //int id = (int)HttpContext.Session.GetInt32("PersonId");

            FullInfo f = new FullInfo();
            //var res1 = PerService.GetByIdAsync(id).Result;
            f.PersonId = res1.PersonId;
            f.FullName = res1.FullName;
            f.ContactNo = res1.ContactNo;
            f.AddressLine1 = res1.AddressLine1;
            f.City = res1.City;
            f.PinCode = res1.PinCode;
            f.Email = res1.Email;
            f.ImageFile = res1.ImageFilePath;
            f.ProfileFile = res1.ProfileFilePath;

            var res2 =  EduService.GetAsync().Result.ToList().Where(x=>x.PersonId == res1.PersonId).FirstOrDefault();
            //var edu = res.Where(x => x.PersonId == id).FirstOrDefault();
            //var res2 = EduService.GetByIdAsync().Result.Where(x => x.PersonId == id)
            //var edu = res2.Where(x => x.PersonId == id).FirstOrDefault();
            f.EducationId= res2.EducationId;
            f.SscboardName = res2.SscboardName;
            f.Sscpercentage = res2.Sscpercentage;
            f.SscpassingDate = res2.SscpassingDate;
            f.HscboardName = res2.HscboardName;
            f.Hscpercentage = res2.Hscpercentage;
            f.HscpassingDate = res2.HscpassingDate;
            f.DiplomaBoardName = res2.DiplomaBoardName;
            f.DiplomaPercentage = res2.DiplomaPercentage;
            f.DiplomaPassingDate = res2.DiplomaPassingDate;
            f.DegreeUniversityName = res2.DegreeUniversityName;
            f.DegreePercentage = res2.DegreePercentage;
            f.DegreeType = res2.DegreeType;
            f.DegreePassingDate = res2.DegreePassingDate;
            f.MastersUniversityName = res2.MastersUniversityName;
            f.MastersPercentage = res2.MastersPercentage;
            f.MastersPassingDate = res2.MastersPassingDate;
            f.HighestQuaification = res2.HighestQuaification;

            //var res3 = ProService.GetByIdAsync(id).Result;
            var res3=ProService.GetAsync().Result.ToList().Where(x=>x.PersonId == res1.PersonId).FirstOrDefault();
            f.ProfessionalId = res3.ProfessionalId;
            f.WorkExperience = res3.WorkExperience;
            f.Companies = res3.Companies;
            f.ProjectInfo = res3.ProjectInfo;

            return View(f);
        }

        public IActionResult EditPersonalInfo(int id)
        {
           
            var res=PerService.GetByIdAsync(id).Result;
            HttpContext.Session.SetSessionData<PersonalInfo>("PersonalInfo", res);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> EditPersonalInfo(int id,PersonalInfo personalInfo)
        {
            if (ModelState.IsValid)
            {
                var res = HttpContext.Session.GetSessionData<PersonalInfo>("PersonalInfo");
                personalInfo.ImageFilePath = res.ImageFilePath;
                personalInfo.ProfileFilePath = res.ProfileFilePath;
                var result = await PerService.UpdateAsync(id, personalInfo);
                return RedirectToAction("GetInfo");
            }
            else
            {
                return View(personalInfo);
            }
        }

        public IActionResult EditEducationalInfo(int id)
        {
            var res = EduService.GetByIdAsync(id).Result;
            HttpContext.Session.SetSessionData<EducationalInfo>("EducationalInfo", res);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> EditEducationalInfo(int id, EducationalInfo educationalInfo)
        {
            if (ModelState.IsValid)
            {
                var res = HttpContext.Session.GetSessionData<EducationalInfo>("EducationalInfo");
                educationalInfo.PersonId=res.PersonId;
                var result = await EduService.UpdateAsync(id, educationalInfo);
                return RedirectToAction("GetInfo");
            }
            else
            {
                return View(educationalInfo);
            }
        }

        public IActionResult EditProfessionlInfo(int id)
        {
            var res = ProService.GetByIdAsync(id).Result;
            HttpContext.Session.SetSessionData<ProfessionalInfo>("ProfessionalInfo", res);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfessionlInfo(int id, ProfessionalInfo professionalInfo)
        {
            if (ModelState.IsValid)
            {
                var res = HttpContext.Session.GetSessionData<ProfessionalInfo>("ProfessionalInfo");
                professionalInfo.PersonId = res.PersonId;
                var result = await ProService.UpdateAsync(id, professionalInfo);
                return RedirectToAction("GetInfo");
            }
            else
            {
                return View(professionalInfo);
            }
        }

        public async Task<IActionResult> DeletePersonalInfo(int id)
        {
            var res = await PerService.GetByIdAsync(id);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePersonalInfo(int id, PersonalInfo personalInfo)
        {
            var res = await PerService.DeleteAsync(id);
            return RedirectToAction("GetInfo");
        }
        public async Task<IActionResult> DeleteEducationalInfo(int id)
        {
            var res= await EduService.GetByIdAsync(id);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEducationalInfo(int id,EducationalInfo educationalInfo)
        {
            var res = await EduService.DeleteAsync(id);
            return RedirectToAction("GetInfo");
        }

        public async Task<IActionResult> DeleteProfessionalInfo(int id)
        {
            var res = await ProService.GetByIdAsync(id);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProfessionalInfo(int id, ProfessionalInfo professionalInfo)
        {
            var res = await ProService.DeleteAsync(id);
            return RedirectToAction("GetInfo");
        }
       
    }
}


