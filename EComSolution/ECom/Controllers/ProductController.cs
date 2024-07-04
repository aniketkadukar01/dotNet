using Microsoft.AspNetCore.Mvc;
using ProductsOnline.Models;
using ProductsOnline.Services;

namespace ProductsOnline.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
           _productService.InsertProduct(model);
            return RedirectToAction("Index");
        }

        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return View(products);
        }

        public IActionResult DeleteProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteProduct(int Id)
        {
            _productService.DeleteProduct(Id);
            return View("Index");
        }

        public IActionResult UpdateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product model)
        {
            _productService.UpdateProduct(model);
            return RedirectToAction("Index");
        }
        
    }
}
