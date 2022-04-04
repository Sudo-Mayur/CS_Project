using Microsoft.AspNetCore.Mvc;
using Sample_Web_App.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Sample_Web_App.Controllers
{
    public class ProductClient : Controller
    {
        HttpClient client;
        public ProductClient()
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
    }
}
