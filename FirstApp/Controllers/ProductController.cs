using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace FirstApp.Controllers
{
    public class ProductController:Controller
    {

        public List<Product> Products { get; set; }

        public ProductController()
        {
            Products = new List<Product>()
            {
                new Product("Macbook Air M2", 2170, "Phone"),
                new Product("Samsung Galaxy", 1650, "Phone"),
                new Product("Apple Airpods", 499, "headset"),
                new Product("Apple Ipad", 1200, "Tablet"),
                new Product("HTC DESIRE 820", 420, "Phone"),
            };
        }


        public IActionResult Index()
        {
            ViewBag.products = Products;
            return View();
        }


        public IActionResult Detail(int id)
        {
            var product = Products.Find(prod => prod.ProductId == id);

            if (product == null)
            {
                return View("error");
            }

            ViewBag.product = product;

            return View();
        }
    }
}
