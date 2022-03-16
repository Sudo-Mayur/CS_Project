using Microsoft.AspNetCore.Mvc;
using Sample_Web_App.Models;
using Sample_Web_App.Services;

namespace Sample_Web_App.Controllers
{
    public class DepartmentCotroller : Controller
    {
        private readonly IService<Department, int> deptService;
        public DepartmentCotroller(IService<Department,int> service)
        {
            deptService = service;
        }
        public IActionResult Index()
        {
            var res = deptService.GetAsync().Result;
            return View(res);
        }
        public IActionResult Create()
        {
            var dept=new Department();
            return View(dept);
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            var res = deptService.Create(department).Result;
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var res=deptService.GetAsync(id).Result;
            return View(res);
        }

        [HttpPost]
        public IActionResult Edit(int id,Department department)
        {
            var res = deptService.UpdateAsync(id, department).Result;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var res =deptService.GetAsync(id).Result;
            return View(res);
        }

        [HttpPost]

        public IActionResult Delete(int id, Department department)
        {
            var res = deptService.DeleteAsync(id).Result;
            return RedirectToAction("Index");
        }
    }
}
