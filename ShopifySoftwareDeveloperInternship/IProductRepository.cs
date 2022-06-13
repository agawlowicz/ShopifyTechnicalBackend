using System;
using System.Collections.Generic;

// For using the Product class:
using ShopifySoftwareDeveloperInternship.Models;

namespace ShopifySoftwareDeveloperInternship
{
    public interface IProductRepository
    {
        // Stubbed out methods will collect and/or modify data in database.
        public void DeleteProduct(Product product);
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int productID);
        public void InsertProduct(Product product);
        public void UpdateProduct(Product product);
    }
}
