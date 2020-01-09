using System;
using System.Web.Http;
using System.Collections.Generic;

namespace vueJsWithMVC.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetMessage()
        {
            return Ok($"{DateTime.Now} - New test message.");
        }

        [HttpGet]
        public IHttpActionResult GetList()
        {
            var list = new List<string>()
            {
                $"Item 1",
                $"Item 2",
                $"Item 3"
            };
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult GetProductList()
        {
            var products = new List<ProductDto>()
            {
                new ProductDto(){ ProductId = 1, Description = "Coffee", Price = 10.99m },
                new ProductDto() { ProductId = 2, Description = "Flan", Price = 2.00m },
                new ProductDto() { ProductId = 3, Description = "Cookies", Price = 5.98m },
                new ProductDto(){ ProductId = 4, Description = "Cameo Cookies", Price = 210m },
                new ProductDto(){ ProductId = 5, Description = "Cheese", Price = 8.95m },
                new ProductDto(){ ProductId = 6, Description = "Bread", Price = 7.99m },
                new ProductDto(){ ProductId = 7, Description = "C#", Price = 30.95m },
                new ProductDto(){ ProductId = 8, Description = "Clojure", Price = 100.00m },
                new ProductDto(){ ProductId = 9, Description = "Blazor Rocks!", Price = 10.99m },
                new ProductDto(){ ProductId = 10, Description = "F#", Price = 8.99m }
            };

            return Ok(products);
        }
    }
}
