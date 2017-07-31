using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VCACoreMetronic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Conozcanos!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Estamos para servirlo!";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
