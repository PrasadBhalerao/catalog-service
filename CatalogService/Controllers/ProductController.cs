using CatalogService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("/api/product")]
    public class ProductController : Controller
    {
        private readonly List<Product> _products;

        public ProductController()
        {
            _products = new List<Product>()
            {
                new Product{ ProductId = 1, ProductName = "Laptop", Category = "Electornics", Price = 12000, ProductImage=""},
                new Product{ ProductId = 2, ProductName = "Keyboard", Category = "Electornics", Price = 12000, ProductImage=""},
                new Product{ ProductId = 3, ProductName = "Mouse", Category = "Electornics", Price = 12000, ProductImage=""},
                new Product{ ProductId = 4, ProductName = "AC", Category = "Electornics", Price = 12000, ProductImage=""},
                new Product{ ProductId = 5, ProductName = "T-Shirt", Category = "Clothing", Price = 600, ProductImage=""},
                new Product{ ProductId = 6, ProductName = "Book", Category = "Books", Price = 900, ProductImage=""},
            };
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            return _products;
        }
    }
}
