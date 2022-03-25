using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sample_Web_App.Models;
using Sample_Web_App.Services;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Sample_Web_App.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IService<Employee, int> empService;
        private readonly IService<Department, int> deptService;

        //public EmployeeController(IService<Employee,int> service, IService<Department, int> service1)
        //{
        //    empService = service;
        //    deptService = service1;
        //}
        public EmployeeController(IService<Employee, int> empService, IService<Department, int> deptService)
        {
            this.empService = empService;
            this.deptService = deptService;
        }
        public IActionResult Index()
        {
            var res = empService.GetAsync().Result; 
            return View(res);
        }

        public IActionResult Create()
        {
            ViewBag.Department = new SelectList(deptService.GetAsync().Result.ToList(), "DeptNo", "DeptName");
            var emp=new Employee();
            return View(emp);
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            try
            {
                var emp = empService.GetAsync(employee.EmpNo);
                if (emp.Result != null)
                {
                    throw new Exception($"Employee No{employee.EmpNo}is already present");
                }

                int capacity = deptService.GetAsync().Result.ToList().Where(x => x.DeptNo == employee.DeptNo).Select(x => x.Capacity).FirstOrDefault();
                int count = empService.GetAsync().Result.ToList().Where(x => x.DeptNo == employee.DeptNo).Count();

                if((ModelState.IsValid))
                    {
                    if(capacity > count)
                    {
                        var result = empService.Create(employee).Result;
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        //throw new Exception($"department Capacity is Full.....");

                        ViewBag.Department = new SelectList(deptService.GetAsync().Result.ToList(), "DeptNo", "DeptName");
                        ViewBag.NewMessage = "department Capacity is Full.....";
                        return View(employee);
                    }
                }
                else
                {
                    ViewBag.Department = new SelectList(deptService.GetAsync().Result.ToList(), "DeptNo", "DeptName");
                    ViewBag.NewMessage = "Please Enter Correct Data";
                    return View(employee);
                }

                //if (ModelState.IsValid && capacity > count)
                //{
                //    var result = empService.Create(employee).Result;
                //    return RedirectToAction("Index");
                //}
                //else
                //{
                //    ViewBag.Department = new SelectList(deptService.GetAsync().Result.ToList(), "DeptNo", "DeptName");
                //    ViewBag.NewMessage = "Please Enter Correct Data";
                //    return View(employee);
                //}

                //if (capacity > count)
                //{
                //    var res = empService.Create(employee).Result;
                //    return RedirectToAction("Index");
                //}

                //else
                //{
                //    ViewBag.Department = new SelectList(deptService.GetAsync().Result.ToList(), "DeptNo", "DeptName");

                //    ViewData["Message"] = "Wrong Data.....";
                //    ViewBag.NewMessage = "Please enter proper data......";

                //    //Stay on the same page
                //    return View(employee);
                //}

            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel()
                {
                    ControllerName = RouteData.Values["controller"].ToString(),
                    ActionName = RouteData.Values["action"].ToString(),
                    ErrorMessage = ex.Message
                });

            }
        }

        public IActionResult ValidateEmpName(string  EmpName)
        {
           // var emp = empService.GetAsync(EmpName).Result;
            //Regex reg = new Regex("[a-zA-z]+[\b]{1}[a-zA-z]+[\b]{1}[a-zA-z]+");
            //if(reg.IsMatch(Convert.ToString(EmpName)))
            //{
            //    return Json(data: true);
            //}
            //else
            //{
            //    return Json(data: "EmpName is not in correct format");
            //}
            int count = 0;
            foreach (char c in EmpName)
            {
                if (c == ' ')
                {
                    count++;
                }
            }

            if(count==2)
            {
                return Json(data: true);
            }
            else
            {
                return Json(data: false);
            }
        }
            

        public IActionResult Edit(int id)
        {
            ViewBag.Department = new SelectList(deptService.GetAsync().Result.ToList(), "DeptNo", "DeptName");

            var res =empService.GetAsync(id).Result;
            return View(res);
        }
        [HttpPost]
        public IActionResult Edit(int id,Employee employee)
        {
            if(ModelState.IsValid)
            {
                var res = empService.UpdateAsync(id, employee).Result;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Department = new SelectList(deptService.GetAsync().Result.ToList(), "DeptNo", "DeptName");
                return View(employee);
            }
           
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

//dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=SuperMarket;Integrated Security=SSPI" Microsoft.EntityFrameworkCore.SqlServer -o Models --force