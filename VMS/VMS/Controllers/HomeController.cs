using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VMS.Models;

namespace VMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("MyView");
        }

        [HttpGet]
        public ViewResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public ViewResult UserLogin(UserLoginInput userLoginInput)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(userLoginInput);
                return View("WellcomeBack", userLoginInput);
            }
            else
            {
                return View();
            }
        }

        public ViewResult MyAdministratorPage()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }


        public ViewResult AboutVMS()
        {
            return View();
        }











        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
