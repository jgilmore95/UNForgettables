using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

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

        public ActionResult Delete(Int32 id)
        {
            VMS.DAL.OpportunityDAL ODAL = new VMS.DAL.OpportunityDAL();

            ODAL.DeleteOpportunity(id);

            return RedirectToAction("DeleteOpportunity");
        }
/*     
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