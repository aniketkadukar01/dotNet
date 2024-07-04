using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Models;
using ECommerceApp.Services;

namespace ECommerceApp.Controllers
{
   
    public class AuthController : Controller
    {

        private IUserService userService;

        public AuthController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //input type parameter is same as view "name"
        public IActionResult Login(string email , string password)
        {
            if(email== "aniket@gmail.com" && password == "aniket")
            {
                //first give controller method name and second controller name without
                //writting controller
                return RedirectToAction("Index", "Products");
            }
            return View(); 
        }
        
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string firstname, string lastname, string email)
        {
            User user = new User();
            user.Email = email;
            user.FirstName = firstname;
            user.LastName = lastname;
            userService.Insert(user);
            return View();
        }

        public IActionResult GetUsers()
        {
            return Json(userService.GetUsers());
        }

        
    }
}
