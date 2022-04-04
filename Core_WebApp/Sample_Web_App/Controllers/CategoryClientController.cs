﻿using Microsoft.AspNetCore.Mvc;
using Sample_Web_App.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Sample_Web_App.Controllers
{
    public class CategoryClientController : Controller
    {
        HttpClient client;
        public CategoryClientController()
        {
            client = new HttpClient();
        }
        public async Task<IActionResult> Index()
        {
            var cats = await client.GetFromJsonAsync<List<Category>>("https://localhost:7161/api/Category");
            return View(cats);
        }

        public IActionResult Create()
        {
            return View(new Category());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {

            var response = await client.PostAsJsonAsync<Category>("https://localhost:7161/api/Category", category);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "No Succes";
                return View(category);
            }

        }

        public IActionResult Edit()
        {
            return View(new Category());
        }

        [HttpPut]
        public async Task<IActionResult> Edit(int id,Category category)
        {
            var response = await client.PutAsJsonAsync<Category>("https://localhost:7161/api/Category", category);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "No Succes";
                return View(category);
            }
        }

        //public IActionResult Delete()
        //{
        //    return View(new Category());
        //}

        //[HttpDelete]
        //public async Task<IActionResult> Delete(int id, Category category)
        //{
        //    var response = await client.DeleteAsJsonAsync<Category>("https://localhost:7161/api/Category", category);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        ViewBag.Message = "No Succes";
        //        return View(category);
        //    }
        //}

    }
}
