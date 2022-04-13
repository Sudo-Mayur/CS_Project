using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Web_App_Job_Seeker.Models;
using Web_App_Job_Seeker.Services;

namespace Web_App_Job_Seeker.Controllers
{
    //[Authorize(Policy = "EmployeerPolicy")]
    [Authorize(Roles = "Employeer")]
    public class EmployeerDetailsController : Controller
    {
        private readonly IService<Employeer, int> empServ;

        public EmployeerDetailsController(IService<Employeer, int> empServ)
        {
            this.empServ = empServ;
        }


        public IActionResult Details()
        {
            var id = HttpContext.Session.GetString("LoginID");
            var res = empServ.GetAsync().Result.Where(x => x.UserId == id).FirstOrDefault();
            return View(res);
        }

        public IActionResult Edit(int id)
        {
            var res = empServ.GetByIdAsync(id).Result;
            return View(res);
        }

        [HttpPost]
        public IActionResult Edit(int id, Employeer user)
        {
            if (ModelState.IsValid)
            {
                var res = empServ.UpdateAsync(id, user).Result;
                return RedirectToAction("Details");
            }
            else
            {
                return View(user);
            }

        }

        public IActionResult Delete(int id)
        {
            var res = empServ.GetByIdAsync(id).Result;
            return View(res);
        }

        [HttpPost]

        public IActionResult Delete(int id, Employeer user)
        {
            var res = empServ.DeleteAsync(id).Result;
            return RedirectToAction("Details");
        }


    }
}
