using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Web_App_Job_Seeker.Models;
using Web_App_Job_Seeker.Services;
using Web_App_Job_Seeker.SessionExtension;

namespace Web_App_Job_Seeker.Controllers
{
    
    public class PersonalInfoController : Controller
    {
        private readonly IService<PersonalInfo, int> PerService;
        private readonly IService<EducationalInfo, int> EduService;
        private readonly IService<ProfessionalInfo, int> ProService;
        IWebHostEnvironment hostEnvironment;

        public PersonalInfoController(IService<PersonalInfo, int> PerService, IService<EducationalInfo, int> EduService, IService<ProfessionalInfo, int> ProService,IWebHostEnvironment hostEnvironment)
        {
            this.PerService = PerService;
            this.EduService = EduService;
            this.ProService = ProService;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var res = HttpContext.Session.GetSessionData<PersonalInfo>("PersonalInfo");
            if(res== null)
            {
                var personalInfo = new PersonalInfo();
                return View(personalInfo);
            }
            return View(res);
           
        }
        [HttpPost]
        public IActionResult Create(PersonalInfo personalInfo)
        {
            if(ModelState.IsValid)
            {
                HttpContext.Session.SetSessionData<PersonalInfo>("PersonalInfo", personalInfo);
                return RedirectToAction("CreateEdu", "PersonalInfo");
            }
            else
            {
                return View(personalInfo);
            }

        }

        public IActionResult CreateEdu()
        {
            var res = HttpContext.Session.GetSessionData<EducationalInfo>("EducationalInfo");
            //List<SelectListItem> Year = new List<SelectListItem>();
            //for (int i = 2010; i <= 2022; i++)
            //{
            //    Year.Add(new SelectListItem() { Text = $"{i}", Value = $"{i}" });
            //}
            //ViewBag.Passyear = Year;

            if (res==null)
            {
                var educationalInfo = new EducationalInfo();
                return View(educationalInfo);
            }
            return View(res);
           
        }
        [HttpPost]
        public IActionResult CreateEdu(EducationalInfo educationalInfo)
        {
            if(ModelState.IsValid)
            {
                HttpContext.Session.SetSessionData<EducationalInfo>("EducationalInfo", educationalInfo);
                return RedirectToAction("CreatePro", "PersonalInfo");
            }
            else
            {
                ViewBag.Message = " The Minimum Qulification is SSC So,Candidate Must Passed SSC Examination.";
                return View(educationalInfo);
            }
            
        }

        public IActionResult CreatePro()
        {
            var res = HttpContext.Session.GetSessionData<ProfessionalInfo>("ProfessionalInfo");
            if (res == null)
            {
                var professionalInfo = new ProfessionalInfo();
                return View(professionalInfo);
            }
            return View(res);   
        }
        [HttpPost]
        public IActionResult CreatePro(ProfessionalInfo professionalInfo,string action)
        {
           
            HttpContext.Session.SetSessionData<ProfessionalInfo>("ProfessionalInfo", professionalInfo);
            return RedirectToAction("FileUpload", "PersonalInfo");
        }

        public IActionResult FileUpload()
        {
            
                ProfileData data = new ProfileData();
                return View(data);
                       
        }

        [HttpPost]
        public async Task<IActionResult> FileUpload(ProfileData data)
        {
            // REad the Current Directtory that is mapped with WebServer
            // var folder = Path.Combine(Directory.GetCurrentDirectory(), "UploadedImages");
            // Get the File Objet
           if(data.ProfilePicture==null || data.Resume==null)
            {
                ViewBag.Message = "Its Mandetory Upload Profile picture and Resume";
                return View(data);              
            }

            IFormFile file = data.ProfilePicture;
            IFormFile Resume=data.Resume;

            // Process It
            // Always Check Length of file

            // if()
            if (file.Length > 0 && file.Length<5000000)
            {
                // REad the Uploaded File Name
                var postedFileName = ContentDispositionHeaderValue
                  .Parse(file.ContentDisposition)
                    .FileName.Trim('"');

                var resumeFileName = ContentDispositionHeaderValue
                .Parse(Resume.ContentDisposition)
                  .FileName.Trim('"');


                FileInfo fileInfo = new FileInfo(postedFileName);
                FileInfo fileInfonew = new FileInfo(resumeFileName);


                if (fileInfo.Extension == ".jpg" || fileInfo.Extension == ".png")
                {
                    var finalPath = Path.Combine(hostEnvironment.WebRootPath, "images", postedFileName);
                    using (var fs = new FileStream(finalPath, FileMode.Create))
                    {
                        // Create a File into the folder
                        await file.CopyToAsync(fs);
                    }
                    data.ProfileFileName = @$"~/images/{file.FileName}";
                    //data.ProfileUploadStatus = "File is Uploaded Successfully";

                }
                else
                {
                    data.ProfileUploadStatus = "Failed to Upload Profile Picture, The Profile Picture Must be JPG or in PNG Format......";
                    return View(data);
                }

                if (fileInfonew.Extension == ".pdf" || fileInfonew.Extension==".docx" || fileInfonew.Extension==".doc")
                {

                    var finalPath = Path.Combine(hostEnvironment.WebRootPath, "PDF", resumeFileName);
                    using (var fs = new FileStream(finalPath, FileMode.Create))
                    {
                        // Create a File into the folder
                        await Resume.CopyToAsync(fs);
                    }
                    data.ResumeFileName =@$"~/PDF/{Resume.FileName}";
                   //data.ResumeUploadStatus = "Resume Uploded Successfully";
                }
                else
                {
                    data.ResumeUploadStatus = "Failed to Upload Resume,The  Resume Must be PDF or in DOCX Format......";
                    return View(data);
                }
            }
            else
            {
                return RedirectToAction("FileUpload");
            }


            var person = HttpContext.Session.GetSessionData<PersonalInfo>("PersonalInfo");
            var education = HttpContext.Session.GetSessionData<EducationalInfo>("EducationalInfo");
            var professional = HttpContext.Session.GetSessionData<ProfessionalInfo>("ProfessionalInfo");
            

            person.ImageFilePath = data.ProfileFileName;
            person.ProfileFilePath = data.ResumeFileName;
            var res = PerService.CreateAsync(person).Result;

            education.PersonId = res.PersonId;

            if(education.MastersPercentage!=null)
            {
                education.HighestQuaification = "Master";
            }
            else if(education.DegreePercentage != null)
            {
                education.HighestQuaification = "Bachelor";
            }
            else if (education.DiplomaPercentage !=null)
            {
                education.HighestQuaification = "Diploma";
            }
            else if (education.Hscpercentage !=null)
            {
                education.HighestQuaification = "HSC";
            }
            else
            {
                education.HighestQuaification = "SSC";
            }

            var res1 = EduService.CreateAsync(education).Result;
            professional.PersonId =res.PersonId ;
            var res2 = ProService.CreateAsync(professional).Result;

            //var res3 = ProService.AddList(professional, res.PersonId);


            HttpContext.Session.Remove("PersonalInfo");
            HttpContext.Session.Remove("EducationalInfo");
            HttpContext.Session.Remove("ProfessionalInfo");


            return RedirectToAction("Index");
        }

        public IActionResult ValidateName(string FullName)
        {

            Regex reg = new Regex("^([a-zA-Z]+( [a-zA-Z]+)+)$");
            if (reg.IsMatch(Convert.ToString(FullName)))
            {
                return Json(data: true);
            }
            else
            {
                return Json(data: false);
            }
        }

    }
}


//dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=Company;Integrated Security=SSPI" Microsoft.EntityFrameworkCore.SqlServer -o Models --force
