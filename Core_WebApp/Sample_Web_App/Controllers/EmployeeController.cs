using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sample_Web_App.CustomSession;
using Sample_Web_App.Models;
using Sample_Web_App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Sample_Web_App.Controllers
{
    [Authorize]
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

            var resEmp = empService.GetAsync().Result; 
            var ResDept =deptService.GetAsync().Result;
            //return View(res);
            var Resultant = from e in resEmp
                            join d in ResDept on
                            e.DeptNo equals d.DeptNo
                            select new
                            {
                                EmpNo = e.EmpNo,
                                EmpName = e.EmpName,
                                Salary = e.Salary,
                                Designation = e.Designation,
                                DeptName = d.DeptName,
                                Email = e.Email,
                                Tax=e.Tax
                            };
            List<EmployeeData> employeeData = new List<EmployeeData>();
            foreach (var d in Resultant)
            {
                employeeData.Add(new EmployeeData() { EmpNo = d.EmpNo, EmpName = d.EmpName, Salary = d.Salary, Designation = d.Designation, DeptName = d.DeptName, Email = d.Email, Tax=d.Tax });
            }
            //employeeData.Clear();
            return View(employeeData);
        }

        public IActionResult Create()
        {
            ViewBag.Department = new SelectList(deptService.GetAsync().Result.ToList(), "DeptNo", "DeptName");
            var res=HttpContext.Session.GetObject<Employee>("Employee");
            if(res==null)
            {
                var emp = new Employee();
                return View(emp);
            }
            return View(res);
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            try
            {
                HttpContext.Session.SetObject<Employee>("Employee", employee);
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
                        HttpContext.Session.Remove("Employee");
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

            Regex reg = new Regex("^([a-zA-Z]+( [a-zA-Z]+)+)$");
            if (reg.IsMatch(Convert.ToString(EmpName)))
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

//dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=ApiDb;Integrated Security=SSPI" Microsoft.EntityFrameworkCore.SqlServer -o Models 