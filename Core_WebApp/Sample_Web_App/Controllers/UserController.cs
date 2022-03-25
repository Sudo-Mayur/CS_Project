using Microsoft.AspNetCore.Mvc;
using Sample_Web_App.Models;
using Sample_Web_App.Services;

namespace Sample_Web_App.Controllers
{
    public class UserController : Controller
    {
        private readonly IService<UserInfo, int> userService;

        public UserController(IService<UserInfo, int> service)
        {
            userService = service;
        }
        public IActionResult Index()
        {
            var res = userService.GetAsync().Result;
            return View(res);
        }
        public IActionResult Create()
        {
            var user = new UserInfo();
            return View(user);
        }
        [HttpPost]
        public IActionResult Create(UserInfo user)
        {
            if(ModelState.IsValid)
            {
                var res = userService.Create(user).Result;
                return RedirectToAction("Index");
            }
            else
            {
                return View(user);
            }
          
        }

        public IActionResult Edit(int id)
        {
            var res = userService.GetAsync(id).Result;
            return View(res);
        }

        [HttpPost]
        public IActionResult Edit(int id, UserInfo user)
        {
            if(ModelState.IsValid)
            {
                var res = userService.UpdateAsync(id, user).Result;
                return RedirectToAction("Index");
            }
            else
            {
                return View(user);
            }
           
        }

        public IActionResult Delete(int id)
        {
            var res = userService.GetAsync(id).Result;
            return View(res);
        }

        [HttpPost]

        public IActionResult Delete(int id, UserInfo user)
        {
            var res = userService.DeleteAsync(id).Result;
            return RedirectToAction("Index");
        }

    }
}
