﻿namespace CatalogService.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal  Price { get; set; }
        public string ProductImage { get; set; }
    }
}
