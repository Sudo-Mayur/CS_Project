using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchProductController : ControllerBase
    {
        private readonly IService<Category, int> catServ;
        private readonly IService<Product, int> productServ;

        public SearchProductController(IService<Category, int> catServ, IService<Product, int> productServ)
        {
            this.catServ = catServ;
            this.productServ = productServ;
        }

        //Add a COntroller e.g.SeatchController that will contain
        //Get method for Search Products by CategoryName
        [HttpPost]
        public IActionResult Get(string name)
        {
            if (ModelState.IsValid)
            {
                var cat = catServ.GetAsync().Result.Where(x => x.CategoryName == name).Select(x => x.CategoryRowId).FirstOrDefault();
                var pro = productServ.GetAsync().Result.Where(x => x.CategoryRowId == cat);
                return Ok(pro);
            }
            else
            {
                return BadRequest(ModelState);
            }
           
        }

        //Create a API thet will have a Search GET Method with Following parameters
        //Search(string CategoryNAme, string condition, string ProductName)
        //This will return Data based on 'AND' and 'OR' value for 'condition' parameter

        [HttpGet]
        public IActionResult Search(string catname, string condition, string productname)
        {
            if (ModelState.IsValid)
            {
                if (condition == "And")
                {
                    var cat = catServ.GetAsync().Result.Where(x => x.CategoryName == catname).Select(x => x.CategoryRowId).FirstOrDefault();
                    var pro = productServ.GetAsync().Result.Where(x => x.CategoryRowId == cat).Select(y => y.ProductName);
                    foreach (var item in pro)
                    {
                        if (item == productname)
                        {
                            var productInfo = productServ.GetAsync().Result.Where(x => x.ProductName == productname).FirstOrDefault();
                            var catInfo = catServ.GetAsync().Result.Where(x => x.CategoryName == catname).FirstOrDefault();
                            catANDprod CP = new catANDprod();

                            CP.CategoryRowID = catInfo.CategoryRowId;
                            CP.CategoryName = catInfo.CategoryName;
                            CP.BasePrice = catInfo.BasePrice;
                            CP.ProductRowID = productInfo.ProductRowId;
                            CP.ProductName = productInfo.ProductName;
                            CP.Price = productInfo.Price;
                            return Ok(CP);
                        }
                    }
                }
                return BadRequest("Wrong Input");
            }

            else
            {
                return BadRequest(ModelState);
            }

            }
        }
    }

