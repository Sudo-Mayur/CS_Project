using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Web_App_Job_Seeker.Models;
using Web_App_Job_Seeker.Services;
using Web_App_Job_Seeker.SessionExtension;

namespace Web_App_Job_Seeker.Controllers
{
    // [Authorize(Policy = "EmployeerPolicy")]
    [Authorize(Roles ="Employeer")]
    public class EmployeerRegistrationController : Controller
    {
        private readonly IService<Employeer, int> empServ;
        IWebHostEnvironment hostEnvironment;


        public EmployeerRegistrationController(IService<Employeer, int> empServ, IWebHostEnvironment hostEnvironment)
        {
            this.empServ = empServ;
            this.hostEnvironment=hostEnvironment;
        }
        public IActionResult Index()
        {          
            return View();
        }
        public IActionResult Create()
        {
            var res = HttpContext.Session.GetSessionData<Employeer>("Employeer");
            if (res == null)
            {
                var employeer = new Employeer();
                return View(employeer);
            }
            return View(res);
            //var res = new Employeer();
            //return View(res);
        }
        [HttpPost]
        public IActionResult Create(Employeer user)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetSessionData<Employeer>("Employeer", user);
                return RedirectToAction("FileUploadNew");

                //var res = empServ.CreateAsync(user).Result;
               // return RedirectToAction("Index");
            }
            else
            {
                return View(user);
            }

        }

        public IActionResult FileUploadNew()
        {

            ProfileData data = new ProfileData();
            return View(data);

        }

        [HttpPost]
        public async Task<IActionResult> FileUploadNew(ProfileData data)
        {
            // REad the Current Directtory that is mapped with WebServer
            // var folder = Path.Combine(Directory.GetCurrentDirectory(), "UploadedImages");
            // Get the File Objet

            IFormFile file = data.ProfilePicture;

            // Process It
            // Always Check Length of file

            // if()
            if (file.Length > 0 && file.Length < 5000000)
            {
                // REad the Uploaded File Name
                var postedFileName = ContentDispositionHeaderValue
                  .Parse(file.ContentDisposition)
                    .FileName.Trim('"');

                FileInfo fileInfo = new FileInfo(postedFileName);


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
            }
            else
            {
                return RedirectToAction("FileUploadNew");
            }

            var person = HttpContext.Session.GetSessionData<Employeer>("Employeer");
            var loginid = HttpContext.Session.GetString("LoginID");
            person.ImagePath = data.ProfileFileName;
            person.UserId = loginid;
            var res=empServ.CreateAsync(person).Result;

            HttpContext.Session.Remove("Employeer");
            return RedirectToAction("Index");

           
        }

       
    }
}

