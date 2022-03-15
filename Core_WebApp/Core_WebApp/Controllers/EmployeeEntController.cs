using Microsoft.AspNetCore.Mvc;
using Core_WebApp.Models;
namespace Core_WebApp.Controllers
{
    public class EmployeeEntController : Controller
    {
      
        EmployeeEnt employees;
        public EmployeeEntController()
        {
            employees = new EmployeeEnt();
        }

        public IActionResult Index()
        {
            // Passing a Collection
            return View(employees);
        }


    }
}
