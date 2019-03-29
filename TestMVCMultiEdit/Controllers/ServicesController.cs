using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCMultiEdit.Models;

namespace TestMVCMultiEdit.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult Index(int? Id)
        {
            List<ClaimService> serviceModel = new List<ClaimService>();
            DB_A0009D_NovoHubEntities DbServices = new DB_A0009D_NovoHubEntities();
            serviceModel = DbServices.ClaimServices.Where(x => x.ClaimId == Id).ToList();
            return View(serviceModel);
        }
        [HttpPost]
        public ActionResult Index(int? id, int? Id, List<ClaimService> serviceList)
        {
            if (ModelState.IsValid)
            {
                using (DB_A0009D_NovoHubEntities DbServices = new DB_A0009D_NovoHubEntities())
                {
                    foreach (var y in serviceList)
                    {
                        ClaimService serviceRows = DbServices.ClaimServices.Where(a => a.ClaimId == y.Id).FirstOrDefault();

                        if (serviceRows != null)
                        {
                            serviceRows.ClaimId = y.ClaimId;
                            serviceRows.costofdrug = y.costofdrug;
                            serviceRows.ServiceDescription = y.ServiceDescription;
                            serviceRows.ServiceId = y.ServiceId;
                            serviceRows.ServiceName = y.ServiceName;

                            serviceRows.InitialAmount = y.InitialAmount;
                            serviceRows.Duration = y.Duration;
                            serviceRows.rate = y.rate;
                            serviceRows.status = y.status;
                            serviceRows.VettedAmount = y.VettedAmount;
                            serviceRows.VettingComment = y.VettingComment;
                        }
                    }
                    DbServices.SaveChanges();
                }

                ViewBag.Message = "Records have been Updated Successfully.";

                return RedirectToAction("Index", "VetClaim", new { id });
            }
            else
            {
                ViewBag.Message = "Failed ! Please try again.";
                return View(serviceList);
            }
        }
    }
}