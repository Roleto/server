using Microsoft.AspNetCore.Mvc;

namespace hello_world.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int age)
        {
            object[] data = new object[2];
            data[0] = name;
            data[1] = age; 
            return View(data);
        }
    }
}
