using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CallFromReactCart.Data;
using System.Text.Json.Nodes;

namespace CallFromReactCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        
        [HttpGet]
        public List<Product> GetAll()
        {
            var res = new List<Product>()
                {
                    new Product()
                        {
                            id = 1,
                            price = 10.99,
                            name = "Book"
                        },
                    new Product()
                        {
                            id = 2,
                            price = 1199,
                            name = "Computer"
                        },
                        new Product()
                        {
                            id = 3,
                            price = 1.05,
                            name = "Banana"
                        },
                            new Product()
                        {
                            id = 4,
                            price = 14000,
                            name = "Car"
                        }

                };

            return res;
        }
    }
}

