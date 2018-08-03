using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VMS.Controllers
{
    public class VolunteerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ManageVolunteer()
        {
            ViewData["Message"] = "Your Opportunity page.";

            return View();
        }

    }
}