using Microsoft.AspNetCore.Mvc;
using Sample_Web_App.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Sample_Web_App.Controllers
{
    public class CategorySearchController : Controller
    {
        HttpClient client;
        public CategorySearchController()
        {
            client = new HttpClient();
        }


        public IActionResult Search()
        {
            return View(new Category());
        }

        [HttpPost]
        public async Task<IActionResult> Search(Category cat)
        {
            HttpContext.Session.SetString("CatRowName", cat.CategoryName);
            return RedirectToAction("GetInfo");
        }

        public async Task<IActionResult> GetInfo()
        {
            string name = HttpContext.Session.GetString("CatRowName");
            var cats = await client.GetFromJsonAsync<List<Product>>("https://localhost:7161/api/SearchProduct/" + name);
            if(cats.Count==0)
            {
                ViewBag.Message= "Record not found....!";
                //return View(cats);
            }
            return View(cats);

        }

    }
}
