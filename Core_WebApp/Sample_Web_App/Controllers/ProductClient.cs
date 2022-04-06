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
            var cats = await client.GetFromJsonAsync<List<Product>>("https://localhost:7161/api/Product");
            return View(cats);
        }

        public IActionResult Create()
        {
            return View(new Product());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {

            var response = await client.PostAsJsonAsync<Product>("https://localhost:7161/api/Product", product);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "No Succes";
                return View(product);
            }

        }

        public async Task<IActionResult> Edit(int id)
        {
            var res = await client.GetFromJsonAsync<Product>("https://localhost:7161/api/Product/" + id);
            return View(res);
            //return View(new Category());
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            var response = await client.PutAsJsonAsync<Product>("https://localhost:7161/api/Product/" + id, product);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "No Succes";
                return View(product);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var res = await client.GetFromJsonAsync<Product>("https://localhost:7161/api/Product/" + id);
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, Product product)
        {
            var response = await client.DeleteAsync("https://localhost:7161/api/Product/" + id);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "No Succes";
                return View(product);
            }
        }


    }
}
