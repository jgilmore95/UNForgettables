using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VMS.Controllers
{
    public class OpportunityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
  
        public IActionResult ManageOpportunity()
        {
            ViewData["Message"] = "Your Opportunity page.";

            return View();
        }
        public IActionResult DeleteOpportunity()
        {
            ViewData["Message"] = "Your Opportunity page.";

            return View();
        }
        //private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PersonalDetails
        /*
        public ActionResult Index()
        {
            return View(db.PersonalDetails.ToList());
        }*/
    }
}