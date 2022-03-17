using Microsoft.AspNetCore.Mvc;
using Sample_Web_App.Models;
using Sample_Web_App.Services;

namespace Sample_Web_App.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IService<Employee, int> empService;

        public EmployeeController(IService<Employee,int> service)
        {
            empService = service;
        }
        public IActionResult Index()
        {
            var res = empService.GetAsync().Result; 
            return View(res);
        }

        public IActionResult Create()
        {
            var emp=new Employee();
            return View(emp);
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            var res = empService.Create(employee).Result;
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var res=empService.GetAsync(id).Result;
            return View(res);
        }
        [HttpPost]
        public IActionResult Edit(int id,Employee employee)
        {
            var res=empService.UpdateAsync(id, employee).Result;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var res = empService.GetAsync(id).Result;
            return View(res);
        }
        [HttpPost]
        public IActionResult Delete(int id,Employee employee)
        {
            var res=empService.DeleteAsync(id).Result;
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var res = empService.GetAsync(id).Result;
            return View(res);
        }

    }
}
//dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=Enterprise1;Integrated Security=SSPI" Microsoft.EntityFrameworkCore.SqlServer -o Models --force