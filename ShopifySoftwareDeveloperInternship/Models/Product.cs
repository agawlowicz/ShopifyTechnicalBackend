using System;
namespace ShopifySoftwareDeveloperInternship.Models
{
    public class Product
    {
        // Constructor that assigns values to Properties below
        public Product(int pID, string name, double cost, int stock)
        {
            Name = name;
            Cost = cost;
            Stock = stock;
            ProductID = pID;
        }

        // Properties of Product
        // Aligns with database column headers
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Stock { get; set; }
    }
}
