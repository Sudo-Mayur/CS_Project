using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    /// <summary>
    ///  Modifying the Route expression as
    ///  api/controllername/actionname
    /// </summary>
    [Route("api/[controller]/[action]")]
    // [ApiController]
    public class ProductArcController : ControllerBase
    {
        private readonly IService<Product, int> prdServ;

        public ProductArcController(IService<Product, int> serv)
        {
            prdServ = serv;
        }

        [HttpPost]
        [ActionName("FromBody")]
        public IActionResult Post([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                var res = prdServ.CreateAsync(product);
                return Ok(res);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        [ActionName("PostForm")]
        public IActionResult PostForm([FromForm] Product product)
        {
            if (ModelState.IsValid)
            {
                var res = prdServ.CreateAsync(product);
                return Ok(res);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        [ActionName("PostHeader")]
        public IActionResult PostHeader([FromHeader] Product product)
        {
            if (ModelState.IsValid)
            {
                var res = prdServ.CreateAsync(product);
                return Ok(res);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        [ActionName("PostQuery")]
        //public IActionResult PostQuery(string ProductId, string ProductName, string Description, int CategoryRowId)
        public IActionResult PostQuery([FromQuery] Product product)
        {

            //var product = new Product()
            //{
            //     ProductId = ProductId,
            //     ProductName = ProductName,
            //     Description = Description,
            //     CategoryRowId = CategoryRowId
            //};

            if (ModelState.IsValid)
            {
                var res = prdServ.CreateAsync(product);
                return Ok(res);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost("{ProductId}/{ProductName}/{Description}/{CategoryRowId}")]
        [ActionName("PostRoute")]
        public IActionResult PostRoute([FromRoute] Product product)
        {
            if (ModelState.IsValid)
            {
                var res = prdServ.CreateAsync(product);
                return Ok(res);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
