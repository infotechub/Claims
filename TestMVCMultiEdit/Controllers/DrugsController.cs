using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCMultiEdit.Models;

namespace TestMVCMultiEdit.Controllers
{
    public class DrugsController : Controller
    {
        // GET: Drugs
        public ActionResult Index(int? Id)
        {
            List<ClaimDrug> drugModel = new List<ClaimDrug>();
            DB_A0009D_NovoHubEntities DbDrugs = new DB_A0009D_NovoHubEntities();
            

            drugModel = DbDrugs.ClaimDrugs.Where(x => x.ClaimId == Id).ToList();
            return View(drugModel);
        }
        [HttpPost]
        public ActionResult Index(int? id, int? Id, List<ClaimDrug> drugList)
        {
            if (ModelState.IsValid)
            {
                using (DB_A0009D_NovoHubEntities DbDrugs = new DB_A0009D_NovoHubEntities())
                {
                    foreach (var i in drugList)
                    {
                        ClaimDrug drugRows = DbDrugs.ClaimDrugs.Where(a => a.ClaimId == i.Id).FirstOrDefault();

                        if (drugRows != null)
                        {
                            drugRows.ClaimId = i.ClaimId;
                            drugRows.costofdrug = i.costofdrug;
                            drugRows.DrugDescription = i.DrugDescription;
                            drugRows.DrugId = i.DrugId;
                            drugRows.DrugName = i.DrugName;
                            
                            drugRows.InitialAmount = i.InitialAmount;
                            drugRows.Quantity = i.Quantity;
                            drugRows.rate = i.rate;
                            drugRows.status = i.status;
                            drugRows.VettedAmount = i.VettedAmount;
                            drugRows.VettingComment = i.VettingComment;
                        }
                    }
                    DbDrugs.SaveChanges();
                }

               // ViewBag.Message = "Records have been Updated Successfully. '<a href='~/Services?Id = i.Id'> Next >>> </a>'";

                return RedirectToAction("Index", "Services", new { id });
            }
            else
            {
                ViewBag.Message = "Failed ! Please try again.";
                return View(drugList);
            }
        }
    }
}