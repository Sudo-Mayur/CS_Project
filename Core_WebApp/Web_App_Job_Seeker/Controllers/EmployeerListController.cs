using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_App_Job_Seeker.Models;
using Web_App_Job_Seeker.Services;

namespace Web_App_Job_Seeker.Controllers
{
    //[Authorize(Policy = "JobSeekerPolicy")]
    [Authorize(Roles = "JobSeeker")]
    public class EmployeerListController : Controller
    {
        private readonly IService<Employeer, int> empServ;

        public EmployeerListController(IService<Employeer, int> empServ)
        {
            this.empServ = empServ;
        }
        public IActionResult Index()
        {
            var res = empServ.GetAsync().Result;
            return View(res);
        }

        public IActionResult Details(int id)
        {
            var res = empServ.GetByIdAsync(id).Result;
            return View(res);
        }

    }
}
