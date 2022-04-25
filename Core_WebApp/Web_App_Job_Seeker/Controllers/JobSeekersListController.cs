using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Web_App_Job_Seeker.Models;
using Web_App_Job_Seeker.Services;

namespace Web_App_Job_Seeker.Controllers
{
   // [Authorize(Policy = "EmployeerPolicy")]
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
                                HighestQuaification = d.HighestQuaification,
                                ImageFilePath = e.ImageFilePath,
                                PersonID = e.PersonId,
                            };


            List<PersonData> personDatas = new List<PersonData>();
            foreach (var d in Resultant)
            {
                personDatas.Add(new PersonData() { FullName = d.Fullname, ContactNo = d.ContactNo, Email = d.Email, HighestQuaification = d.HighestQuaification, Image = d.ImageFilePath, PersonID = d.PersonID });
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
            f.AddressLine1 = res1.AddressLine1;
            f.City = res1.City;
            f.PinCode = res1.PinCode;
            f.Email = res1.Email;
            f.ImageFile = res1.ImageFilePath;
            f.ProfileFile = res1.ProfileFilePath;

            var res2 = EduService.GetAsync().Result.ToList().Where(x => x.PersonId == id).FirstOrDefault();
            //var res2 = EduService.GetByIdAsync(id).Result;
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

            var res3 = ProService.GetAsync().Result.ToList().Where(x => x.PersonId == id).FirstOrDefault();
            //var res3 = ProService.GetByIdAsync(id).Result;
            f.WorkExperience = res3.WorkExperience;
            f.Companies = res3.Companies;
            f.ProjectInfo = res3.ProjectInfo;

            return View(f);
        }

        public IActionResult Search(string SearchBy, string search)
        {
            if(search==null)
            {
                return RedirectToAction("Index");
            }
            if (SearchBy == "Name")
            {
                var res1 = PerService.GetAsync().Result.Where(e => e.FullName.StartsWith(search)).ToList();
                if(res1.Count==0)
                {
                    ViewBag.Message = "No Record Found";
                   // return RedirectToAction("Index");
                }
                var resEdu = EduService.GetAsync().Result;
                var Resultant = from e in res1
                                join d in resEdu on
                                e.PersonId equals d.PersonId
                                select new
                                {
                                    Fullname = e.FullName,
                                    ContactNo = e.ContactNo,
                                    Email = e.Email,
                                    HighestQuaification = d.HighestQuaification,
                                    ImageFilePath = e.ImageFilePath,
                                    PersonID = e.PersonId,
                                    City = e.City
                                };


                List<PersonData> personDatas = new List<PersonData>();
                foreach (var d in Resultant)
                {
                    personDatas.Add(new PersonData() { FullName = d.Fullname, ContactNo = d.ContactNo, Email = d.Email, HighestQuaification = d.HighestQuaification, Image = d.ImageFilePath, PersonID = d.PersonID , City = d.City });
                }

                return View(personDatas);
            }

            else if(SearchBy=="Quailification")
            {
                var resPer = EduService.GetAsync().Result.Where(e => e.HighestQuaification==search).ToList();
                if (resPer.Count == 0)
                {
                    ViewBag.Message = "No Record Found";
                }
                var res1 = PerService.GetAsync().Result;
                var Resultant = from e in res1
                                join d in resPer on
                                e.PersonId equals d.PersonId
                                select new
                                {
                                    Fullname = e.FullName,
                                    ContactNo = e.ContactNo,
                                    Email = e.Email,
                                    HighestQuaification = d.HighestQuaification,
                                    ImageFilePath = e.ImageFilePath,
                                    PersonID = e.PersonId,
                                    City = e.City
                                };


                List<PersonData> personDatas = new List<PersonData>();
                foreach (var d in Resultant)
                {
                    personDatas.Add(new PersonData() { FullName = d.Fullname, ContactNo = d.ContactNo, Email = d.Email, HighestQuaification = d.HighestQuaification, Image = d.ImageFilePath, PersonID = d.PersonID, City = d.City });
                }

                return View(personDatas);

            }

            else if(SearchBy == "WorkExperience")
            {
                var res = ProService.GetAsync().Result.Where(e => e.WorkExperience == search).ToList();
                var resPer = PerService.GetAsync().Result;
                var Resultant = from e in resPer
                                join d in res on
                                e.PersonId equals d.PersonId
                                select new
                                {
                                    Fullname = e.FullName,
                                    ContactNo = e.ContactNo,
                                    Email = e.Email,
                                    ImageFilePath = e.ImageFilePath,
                                    PersonID = e.PersonId,
                                    City=e.City
                                };


                List<PersonData> personDatas = new List<PersonData>();
                foreach (var d in Resultant)
                {
                    personDatas.Add(new PersonData() { FullName = d.Fullname, ContactNo = d.ContactNo, Email = d.Email,  Image = d.ImageFilePath, PersonID = d.PersonID, City = d.City });
                }

                return View(personDatas);



            }
            else
            {
                return View(Search);
            }
        }
      
    }
}


