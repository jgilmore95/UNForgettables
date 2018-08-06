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
 /*
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalDetail personalDetail = db.PersonalDetails.Find(id);
            if (personalDetail == null)
            {
                return HttpNotFound();
            }
            return View(personalDetail);
        }
     
        // POST: PersonalDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonalDetail personalDetail = db.Database1.Find(id);
            db.PersonalDetails.Remove(personalDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PersonalDetails
      
        public ActionResult Index()
        {
            return View(db.PersonalDetails.ToList());
        }*/
    }
}