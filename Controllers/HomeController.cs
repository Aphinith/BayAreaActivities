using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BayAreaActivities.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "A website to connect you with fun and exciting activities in your area!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Please contact us at:";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
