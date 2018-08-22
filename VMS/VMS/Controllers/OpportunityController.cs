/**
 * Robert Bolden
 * 
 * This alllows for the use of navigation from page to page via opportunity.  It also implements some of the views using models
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using VMS.Models;

namespace VMS.Controllers
{
    public class OpportunityController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
  
        public ActionResult ManageOpportunity()
        {
            ViewData["Message"] = "Your Opportunity page.";

            return View();
        }

        public ActionResult DeleteOpportunity()
        {
            var model = VMS.DAL.OpportunityDAL.GetAllActive();

            ViewData["Message"] = "Your Opportunity page.";

            return View(model);
        }

        public ActionResult ViewOpportunityVolunteer()
        {
            var model = VMS.DAL.OpportunityDAL.GetAllOppVols();

            ViewData["Message"] = "Your Opportunity Volunteers page.";

            return View(model);
        }

        public ActionResult Delete(Int32 id)
        {
            VMS.DAL.OpportunityDAL ODAL = new VMS.DAL.OpportunityDAL();

            ODAL.DeleteOpportunity(id);

            return RedirectToAction("DeleteOpportunity");
        }
        
        public ActionResult Add()
        {
            var model = VMS.DAL.OpportunityDAL.GetAllActive();
            
            return RedirectToAction("CreateOpportunity");
        }
        [HttpGet]
        public ActionResult CreateOpportunity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOpportunity(Opportunity opportunity)
        {
            return View("CreateConfirm", opportunity);


        }
        public ViewResult CreateConfirm(Opportunity opportunity)
        {
            return View("CreateConfirm", opportunity);
        }
        public ActionResult SearchOpportunity()
        {
            return View();
        }
    }
}