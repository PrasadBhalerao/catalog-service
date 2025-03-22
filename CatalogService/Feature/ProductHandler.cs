using CatalogService.Models;
using CatalogService.Repository;
using System.Collections.Generic;

namespace CatalogService.Feature
{
    public class ProductHandler
    {
        private readonly ProductRepository _productRepository;

        public ProductHandler()
        {
            _productRepository = new ProductRepository();
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
