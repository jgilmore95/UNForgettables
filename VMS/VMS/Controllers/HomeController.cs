using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("MyView");
        }

        [HttpGet]
        public ViewResult UserLogin()
        {
            return View();
        }
        public ActionResult ManageOpportunity()
        {
            ViewData["Message"] = "Your Opportunity page.";

            return View();
        }
        /*
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
        */
        public ViewResult MyAdministratorPage()
        {
            return View();
        }


        public ViewResult AboutVMS()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        /*
        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
        public ActionResult Admin()
        {
            return View();
        }
        public ActionResult AddOp()
        {
            return View();
        }
    }
}
