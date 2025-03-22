using CatalogService.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CatalogService.Repository
{
    public class ProductRepository
    {
        private readonly string _dataFilePath = "Data/products.json";

        public List<Product> GetAllProducts()
        {
            if (File.Exists(_dataFilePath))
            {
                var json = File.ReadAllText(_dataFilePath);
                return JsonConvert.DeserializeObject<List<Product>>(json);
            }
            return new List<Product>();
        }
    }
}
