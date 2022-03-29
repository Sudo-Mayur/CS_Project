using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
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
            var personalInfo = new PersonalInfo();
            return View(personalInfo);
        }
        [HttpPost]
        public IActionResult Create(PersonalInfo personalInfo)
        {

            //var res=PerService.CreateAsync(personalInfo).Result;
            HttpContext.Session.SetSessionData<PersonalInfo>("PersonalInfo", personalInfo);
            return RedirectToAction("CreateEdu", "PersonalInfo");

            //return RedirectToAction("CreateEdu");

        }

        public IActionResult CreateEdu()
        {
            var educationalInfo=new EducationalInfo();
            return View(educationalInfo);
        }
        [HttpPost]
        public IActionResult CreateEdu(EducationalInfo educationalInfo)
        {
            //var res = EduService.CreateAsync(educationalInfo).Result;
            //return RedirectToAction("CreatePro");
            HttpContext.Session.SetSessionData<EducationalInfo>("EducationalInfo", educationalInfo);
            return RedirectToAction("CreatePro", "PersonalInfo");
        }

        public IActionResult CreatePro()
        {
            var professionalInfo=new ProfessionalInfo();
            return View(professionalInfo);
        }
        [HttpPost]
        public IActionResult CreatePro(ProfessionalInfo professionalInfo)
        {
            //var res = ProService.CreateAsync(professionalInfo).Result;
            //return RedirectToAction("Index");
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

            IFormFile file = data.ProfilePicture;
            IFormFile Resume=data.Resume;

            // Process It
            // Always Check Length of file

            // if()
            if (file.Length > 0)
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
                    data.ProfileUploadStatus = "File is Uploaded Successfully";
                }
                else
                {
                    data.ProfileUploadStatus = "Failed......";
                }

                if (fileInfonew.Extension == ".pdf")
                {

                    var finalPath = Path.Combine(hostEnvironment.WebRootPath, "PDF", resumeFileName);
                    using (var fs = new FileStream(finalPath, FileMode.Create))
                    {
                        // Create a File into the folder
                        await Resume.CopyToAsync(fs);
                    }
                    data.ResumeFileName =@$"~/PDF/{Resume.FileName}";
                    data.ResumeUploadStatus = "Resume Uploded Successfully";
                }
                else
                {
                    data.ResumeUploadStatus = "Failed......";
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

            if(education.MastersPassingYear!=null)
            {
                education.HighestQuaification = "Master";
            }
            else if(education.DegreePassingYear!=null)
            {
                education.HighestQuaification = "Bachelor";
            }
            else if (education.DiplomaPassingYear !=null)
            {
                education.HighestQuaification = "Diploma";
            }
            else if (education.HscpassingYear !=null)
            {
                education.HighestQuaification = "HSC";
            }
            else
            {
                education.HighestQuaification = "SSC";
            }

            var res1 = EduService.CreateAsync(education).Result;
            professional.PersonId = res.PersonId;
            var res2 = ProService.CreateAsync(professional).Result;

            return RedirectToAction("Index");
        }

    }
}

//dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=Company;Integrated Security=SSPI" Microsoft.EntityFrameworkCore.SqlServer -o Models --force
