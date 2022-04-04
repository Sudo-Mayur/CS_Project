using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryProductController : ControllerBase
    {
        private readonly IService<Category, int> catServ;
        private readonly IService<Product, int> productServ;

        public CategoryProductController(IService<Category, int> catServ, IService<Product, int> productServ)
        {
            this.catServ = catServ;
            this.productServ = productServ;
        }
        [HttpPost]
        public IActionResult Create(CategoryProduct product)
        {
            if (ModelState.IsValid)
            {
                var cat = new Category()
                {
                    CategoryId = product.CategoryId,
                    CategoryName = product.CategoryName,
                    BasePrice = product.BasePrice,
                };
                var catResultant = catServ.CreateAsync(cat).Result;
                foreach (var item in product.Products)
                {
                    item.CategoryRowId = catResultant.CategoryRowId;
                    var res = productServ.CreateAsync(item).Result;
                }
                //var res = prdServ.CreateAsync(product);
                return Ok(product);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
