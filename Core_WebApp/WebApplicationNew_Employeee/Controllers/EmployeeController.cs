using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplicationNew_Employeee.Models;
using WebApplicationNew_Employeee.Services;

namespace WebApplicationNew_Employeee.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IService<Employee, int> empService;

        public EmployeeController(IService<Employee, int> service)
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
            var emp = new Employee();
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
            var res = empService.GetAsync(id).Result;
            return View(res);
        }
        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        {
            var res = empService.UpdateAsync(id, employee).Result;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var res = empService.GetAsync(id).Result;
            return View(res);
        }
        [HttpPost]
        public IActionResult Delete(int id, Employee employee)
        {
            var res = empService.DeleteAsync(id).Result;
            return RedirectToAction("Index");
        }
    }
}
