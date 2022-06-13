using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopifySoftwareDeveloperInternship.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopifySoftwareDeveloperInternship.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult DeleteProduct(Product product)
        {
            repo.DeleteProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }

        // TO DO: CHECK AGAIN w categories
        public IActionResult InsertProductToDatabase(Product product)
        {
            repo.InsertProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateProduct(int id)
        {
            Product prod = repo.GetProduct(id);

            // Null check
            return (prod == null) ? View("ProductNotFound") : View(prod);
        }

        public IActionResult UpdateProductToDatabase(Product product)
        {
            repo.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        // Serves as Model to work with in ViewProduct View
        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);
            return View(product);
        }
    }
}
