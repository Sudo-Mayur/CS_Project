using Microsoft.AspNetCore.Mvc;
using Core_WebApp.Models;


namespace Sample_Web_App.Controllers
{
    public class EmpController : Controller
    {

        EmployeeEnts employees;

        public EmpController()
        {
            employees = new EmployeeEnts();
        }
        public IActionResult Index()
        {
            // Passing a Collection
            return View(employees);
        }
    }
}
