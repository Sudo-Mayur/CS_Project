using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IService<Product, int> ProServ;

        public ProductController(IService<Product, int> serv)
        {
            ProServ= serv;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var res=ProServ.GetAsync().Result;
            return Ok(res);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var res=ProServ.GetAsync(id).Result;
            return Ok(res);
        }

        [HttpPost]
        public IActionResult Post(Product Pro)
        {
            if(ModelState.IsValid)
            {
                var res = ProServ.CreateAsync(Pro).Result;
                return Ok(res);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Product pro)
        {
            var Record=ProServ.UpdateAsync(id, pro).Result;
            if(Record == null) return NotFound($"BAsed of Product Row Id {id} the record is not found");

            if (id != pro.ProductRowId) return BadRequest($"Id for seaarch {id} does not match with Product Row Id in Body {pro.ProductRowId}");

            if(ModelState.IsValid)
            {
                var res=ProServ.UpdateAsync(id,pro).Result;
                return Ok(res);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var res=ProServ.DeleteAsync(id).Result;
            return Ok(res);
        }

    }
}
