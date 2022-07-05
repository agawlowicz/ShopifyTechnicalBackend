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
        private readonly IDeletionRepository repo2;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult DeleteProduct(int id)
        {
            Product prod = repo.GetProduct(id);

            // Null check
            return (prod == null) ? View("ProductNotFound") : View(prod);
            //return View(product);
        }

        public IActionResult AddDeletedProduct(Deleted deletion)
        {
            repo2.DeleteProduct(deletion);
            repo.DeleteProduct(deletion.Product);
            return RedirectToAction("Index");
        }

        //public IActionResult DeleteProduct(Product product)
        //{
        //    repo.
        //    repo.DeleteProduct(product);
        //    return RedirectToAction("Index");
        //}

        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }

        public IActionResult InsertProduct()
        {
            var product = new Product();
            return View(product);
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
