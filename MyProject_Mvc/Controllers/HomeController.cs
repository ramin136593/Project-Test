using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyProject_Mvc.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyProject_Mvc.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
           
        }
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی"),
            new Service(3, "پلاتین"),
            new Service(4, "الماس"),
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
