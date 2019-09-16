using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jirada.Models;
using Microsoft.AspNetCore.Http;

namespace jirada.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult plus(int id)
        {
            int i = id + 10;
            ViewData["sum"] = i;
            return View();
        }
        public IActionResult multiply(int id)
        {
            int m = id * 10;
            ViewData["resualt"] = m;
            return View();
        }
        [Route("minus/{a}/{b}")]
        public IActionResult minus(int a, int b)
        {
            int mi = a - b;
            ViewData["pollub"] = mi;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactPost(IFormCollection values)
        {
            ViewData["Name"] = values["name"];
            ViewData["Email"] = values["email"];
            ViewData["ShowAlert"] = true;
            return View("Index");
        }
        public IActionResult Contact2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactPost2(Contact model)
        {
            ViewData["Name"] = model.Name;
            ViewData["Email"] = model.Email;
            ViewData["ShowAlert"] = true;
            return View("Index");
        }

    }
}
