using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication2.Controllers
{
    public class HelloWorldController : Controller
    {

        // every public method in a controller is an action method
        // get /HelloWorld/Index
        public IActionResult Index()
        {
            return View();
        }

        // get /HelloWorld/Welcome 
        public IActionResult Welcome(string name, int num = 1)
        {
            ViewData["message"] = "Hello " + name;
            ViewData["num"] = num;
            return View();
        }
    }
}
