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

        //Add a COntroller e.g.SearchtchController that will contain
        //Get method for Search Products by CategoryName

        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            List<Product> product = new List<Product>();

            int? cat = catServ.GetAsync().Result.Where(x => x.CategoryName == name).Select(x => x.CategoryRowId).FirstOrDefault();
            if (cat != 0)
            {
                if (cat != null)
                {

                    var products = productServ.GetAsync().Result.ToList();

                    var result = from prd in products
                                 where prd.CategoryRowId == cat
                                 select new Product()
                                 {
                                     ProductRowId = prd.ProductRowId,
                                     ProductId = prd.ProductId,
                                     ProductName = prd.ProductName,
                                     Description = prd.Description,
                                     Price = prd.Price,
                                 };

                    if (result.Count() > 0)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return Ok($"No Products for Category Name {name}");
                    }

                }
                else
                {
                    return BadRequest("Please provide Correct Caregory NAme");
                }
            }
            else
            {
                // return BadRequest("Please provide Correct Caregory NAme");
                //var pd = new Product();
                return Ok(product);
            }
        }

        //OR Condition
        //Create a API thet will have a Search GET Method with Following parameters
        //Search(string CategoryNAme, string condition, string ProductName)
        //This will return Data based on 'OR' value for 'condition' parameter

        [HttpGet]
        public IActionResult SearchProduct(string? CategoryNAme, string? ProductName, string Operator)
        {
            if (ModelState.IsValid)
            {
                if (Operator == "AND")
                {
                    if (CategoryNAme != null && ProductName != null)
                    {
                        var catID = catServ.GetAsync().Result.Where(x => x.CategoryName == CategoryNAme).Select(x => x.CategoryRowId).FirstOrDefault();
                        if (catID != 0)
                        {
                            var catResultant = catServ.GetAsync(catID).Result;
                            var proExistance = productServ.GetAsync().Result.Where(x => x.CategoryRowId == catID);
                            if (proExistance != null)
                            {
                                var product = proExistance.Where(x => x.ProductName.ToLower() == ProductName.ToLower());
                                CategoryProduct categoryProduct = new CategoryProduct()
                                {
                                    CategoryRowId = catID,
                                    CategoryId = catResultant.CategoryId,
                                    CategoryName = catResultant.CategoryName,
                                    BasePrice = catResultant.BasePrice,
                                };
                                categoryProduct.Products = new List<Product>();
                                foreach (Product p in product)
                                {
                                    categoryProduct.Products.Add(new Product() { ProductRowId = p.ProductRowId, ProductName = p.ProductName, Description = p.Description, Price = p.Price, CategoryRowId = p.CategoryRowId, ProductId = p.ProductId });
                                }
                                return Ok(categoryProduct);
                            }
                            else
                            {
                                return BadRequest("No Product Found");
                            }
                        }
                        else
                        {
                            return BadRequest("No Such Catagory found!");
                        }
                    }
                    return BadRequest("Both Feild Required");
                }
                else if (Operator == "OR")
                {
                    if (CategoryNAme != null && ProductName != null)
                    {
                        var catID = catServ.GetAsync().Result.Where(x => x.CategoryName == CategoryNAme).Select(x => x.CategoryRowId).FirstOrDefault();
                        //var proExist = productServ.GetAsync().Result.Where(x => x.CategoryRowId == catID);
                        //var prod = proExist.Where(x => x.ProductName.ToLower() == ProductName.ToLower());
                        if (catID != 0)
                        {
                            var catRes = catServ.GetAsync(catID).Result;
                            var proExistance = productServ.GetAsync().Result.Where(x => x.CategoryRowId == catID);
                            if (proExistance != null)
                            {
                                var product = proExistance.Where(x => x.ProductName.ToLower() == ProductName.ToLower());
                                CategoryProduct categoryProduct = new CategoryProduct()
                                {
                                    CategoryRowId = catID,
                                    CategoryId = catRes.CategoryId,
                                    CategoryName = catRes.CategoryName,
                                    BasePrice = catRes.BasePrice,
                                };
                                categoryProduct.Products = new List<Product>();
                                foreach (Product p in product)
                                {
                                    categoryProduct.Products.Add(new Product() { ProductRowId = p.ProductRowId, ProductName = p.ProductName, Description = p.Description, Price = p.Price, CategoryRowId = p.CategoryRowId, ProductId = p.ProductId });
                                }
                                return Ok(categoryProduct);
                            }
                            else
                            {
                                return Ok(catRes);
                            }
                        }
                        else
                        {
                            var prod = productServ.GetAsync().Result.Where(x => x.ProductName.ToLower() == ProductName.ToLower());
                            if (prod.Count() != 0)
                            {
                                return Ok(prod);
                            }
                            else
                            {
                                return BadRequest("No Such Category, No Such Product Exists");
                            }
                        }
                    }
                    else if (CategoryNAme != null)
                    {
                        var catID = catServ.GetAsync().Result.Where(x => x.CategoryName == CategoryNAme).Select(x => x.CategoryRowId).FirstOrDefault();
                        if (catID != 0)
                        {
                            var catRes = catServ.GetAsync(catID).Result;
                            return Ok(catRes);
                        }
                        else
                        {
                            return BadRequest("No Such Category Exists");
                        }
                    }
                    else if (ProductName != null)
                    {
                        var prod = productServ.GetAsync().Result.Where(x => x.ProductName.ToLower() == ProductName.ToLower());
                        if (prod.Count() != 0)
                        {
                            return Ok(prod);
                        }
                        else
                        {
                            return BadRequest("No Product Found");
                        }
                    }
                }
                else
                {
                    return BadRequest("Invalid Operator");
                }
            }
            return BadRequest("NO Found");
        }



        //[HttpGet("{catname}/{condition}/{prdname}")]
        //[ActionName("searchcomplex")]
        //public IActionResult SearchCondition(string catname, string condition, string prdname)
        //{
        //    List<Product> products = new List<Product>();
        //    Category cat = catServ.GetAsync().Result.Where(c => c.CategoryName == catname).FirstOrDefault();
        //    switch (condition)
        //    {
        //        case "AND":
        //            products = (from prd in productServ.GetAsync().Result.ToList()
        //                        where prd.CategoryRowId == cat.CategoryRowId && prd.ProductName == prdname
        //                        select prd).ToList();
        //            break;
        //        case "OR":
        //            products = (from prd in productServ.GetAsync().Result.ToList()
        //                        where prd.CategoryRowId == cat.CategoryRowId || prd.ProductName == prdname
        //                        select prd).ToList();
        //            break;
        //        default:
        //            products = new List<Product>();
        //            break;
        //    }
        //    return Ok(products);
        //}
    }
}

