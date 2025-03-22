using CatalogService.Feature;
using CatalogService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("/api/product")]
    public class ProductController : Controller
    {
        private readonly ProductHandler _productHandler;

        public ProductController()
        {
            _productHandler = new ProductHandler();
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var products = _productHandler.GetProducts();
            return products.Any() ? Ok(products) : NotFound("No products available.");
        }
    }
}
