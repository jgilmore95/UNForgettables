/**
 * Robert Bolden
 * 
 * This page allows for the movement of pages via volunteer
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace VMS.Controllers
{
    public class VolunteerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageVolunteer()
        {
            ViewData["Message"] = "Your Opportunity page.";

            return View();
        }
        public ActionResult ViewVolunteerOpportunity()
        {
            var model = VMS.DAL.OpportunityDAL.GetAllVolsOpps();

            ViewData["Message"] = "Your Opportunity page.";

            return View(model);
        }

    }
}