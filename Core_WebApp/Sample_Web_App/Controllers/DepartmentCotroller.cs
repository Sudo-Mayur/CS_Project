using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sample_Web_App.Models;
using Sample_Web_App.Services;
using System;

namespace Sample_Web_App.Controllers
{
    /// <summary>
    /// Apply Filter at Controller
    /// </summary>
    /// 
    // [LogFilter]
    public class DepartmentCotroller : Controller
    {
        private readonly IService<Department, int> deptService;
        public DepartmentCotroller(IService<Department,int> service)
        {
            deptService = service;
        }

        //[LogFilter]
        //Apply Filter at ActionLevel
        [Authorize(Policy = "ReadPolicy")]
        public IActionResult Index()
        {
            var res = deptService.GetAsync().Result;
            return View(res);
        }

        [Authorize(Policy ="ManagerClerkPolicy")]
       public IActionResult Create()
        {
            var dept=new Department();
            return View(dept);
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            //try
            //{
                var dept = deptService.GetAsync(department.DeptNo);
                if (dept.Result != null)
                {
                    throw new Exception($"Department No{department.DeptNo}is already present");
                }


                // USe if-else statements for Explict Model Validations
                // if no error then Process values
                if (ModelState.IsValid)
                {
                    var res = deptService.Create(department).Result;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewData["Message"] = "Wrong Data.....";
                    ViewBag.NewMessage = "Please enter proper data......";

                    //Stay on the same page
                    return View(department);
                }

            //}
            //catch(Exception ex)
            //{
            //    return View("Error", new ErrorViewModel()
            //    {
            //        ControllerName = RouteData.Values["controller"].ToString(),
            //        ActionName = RouteData.Values["action"].ToString(),
            //        ErrorMessage = ex.Message
            //    });
            //}
            }
        [Authorize(Policy ="ManagerClerkPolicy")]
        public IActionResult Edit(int id)
        {
            var res=deptService.GetAsync(id).Result;
            return View(res);
        }

        [HttpPost]
        public IActionResult Edit(int id,Department department)
        {
            if (ModelState.IsValid)
            {
                var res = deptService.UpdateAsync(id, department).Result;
                return RedirectToAction("Index");
            }
            else
            {
                return View(department);
            }
            
        }

        [Authorize(Policy ="ManagerPolicy")]
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


