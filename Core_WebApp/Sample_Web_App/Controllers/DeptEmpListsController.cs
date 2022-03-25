using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sample_Web_App.Models;
using Sample_Web_App.Services;
using System.Linq;

namespace Sample_Web_App.Controllers
{
    public class DeptEmpListsController : Controller
    {
        private readonly IService<Department, int> deptServ;
        private readonly IService<Employee, int> empServ;

        public DeptEmpListsController(IService<Department, int> deptServ, IService<Employee, int> empServ)
        {
            this.deptServ = deptServ;
            this.empServ = empServ;
        }
     
        public IActionResult Index(int id)
        {
            ViewBag.Department = new SelectList(deptServ.GetAsync().Result.ToList(), "DeptNo", "DeptName");
            var deptemp=new DeptEmpList();
            deptemp.Departments=deptServ.GetAsync().Result.ToList();
            if(id==0)
            {
                deptemp.Employees = empServ.GetAsync().Result.ToList();
            }
            else
            {
                deptemp.Employees=empServ.GetAsync().Result.Where(e=>e.DeptNo==id).ToList();
            }         
            return View(deptemp);
        }

        public IActionResult show(DeptEmpList dept)
        {
            int deptNo = dept.DeptNo;
            // return to Index View with a Route Parameter
            return RedirectToAction("Index", new { id = deptNo });
        }
    }
}
