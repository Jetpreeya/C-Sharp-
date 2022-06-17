using Microsoft.AspNetCore.Mvc;
using MVC_13062022.Models;

namespace MVC_13062022.Controllers
{
    public class ProductsController : Controller
    {
        MyDbContext Context; 

        public ProductsController(MyDbContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
            ViewData["ProductInfo"] = "Here is you can find information about our products.";
            List <Product> AllProducts = Context.Products.ToList();
            return View(AllProducts);
        }

        public IActionResult GetProduct(Product? Product1)
        {
            /*Product Product = new Product();
            Product.Id = 1;
            Product.Name = "Pink Shoes";
            Product.Price = 2000.0;*/
            return View(Product1);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int id, string name, double price)
        {
            Product Product = new Product();
            /*Product.Id = id;*/
            Product.Name = name;
            Product.Price = Convert.ToDouble(price);
            Context.Products.Add(Product);
            Context.SaveChanges();

            System.Diagnostics.Debug.WriteLine("Id" + Product.Id + "Name: " + Product.Name + "Price: " + Product.Price);
            return RedirectToAction("GetProduct", Product);
        }

        public IActionResult Edit(int? id)
        {
            Product Product = Context.Products.FirstOrDefault(x => x.Id == id);
            return View(Product);
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, double price)
        {
            Product Product = Context.Products.FirstOrDefault(x => x.Id == id);
            Product.Name = name;
            Product.Price= Convert.ToDouble(price);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            Product Product = Context.Products.FirstOrDefault(x => x.Id == id);
            return View(Product);
        }


        [HttpPost]
        public IActionResult DeleteYes(int? id)
        {
            Product Product = Context.Products.FirstOrDefault(x => x.Id == id);
            Context.Remove(Product);
            Context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
