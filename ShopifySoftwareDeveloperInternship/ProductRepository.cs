using System;
using System.Collections.Generic;
using System.Data;
using ShopifySoftwareDeveloperInternship.Models;
using Dapper; // To work with SQL

namespace ShopifySoftwareDeveloperInternship
{
    public class ProductRepository : IProductRepository
    {
        // Protect connection to database
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void DeleteProduct(Product product)
        {
            _conn.Execute("DELETE FROM developerIntern WHERE ProductID = @id;", new { id = product.ProductID });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = _conn.Query("SELECT * FROM developerIntern;");

            return _conn.Query<Product>("SELECT * FROM developerIntern;");
        }

        public Product GetProduct(int productID)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM developerIntern WHERE productID = @id;",
                new { id = productID });
        }

        public void InsertProduct(Product product)
        {
            _conn.Execute("INSERT INTO developerIntern VALUES (@id, @name, @cost, @stock);",
                new { id = product.ProductID, name = product.Name, cost = product.Cost, stock = product.Stock });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE developerIntern SET Product = @name, Cost = @cost, Stock = @stock WHERE ProductID = @id;",
                new { name = product.Name, cost = product.Cost, stock = product.Stock, id = product.ProductID });
        }
    }
}
