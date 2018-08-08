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

    }
}