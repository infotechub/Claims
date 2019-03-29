using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestMVCMultiEdit.Models;


namespace TestMVCMultiEdit.Controllers
{
    public class VetClaimController : Controller
    {
        // GET: VetClaim
        private DB_A0009D_NovoHubEntities db = new DB_A0009D_NovoHubEntities();

        // GET: Claims
        public ActionResult Index(int? Id, int? ProviderId, int? ClaimBatchId, string enrolleePolicyNumber, string enrolleeFullname, int? enrolleeCompanyId, int? Enrolleeid, int? pageNumber)
        {

            ViewBag.providers = db.Providers.Where(x => x.Id == ProviderId).ToList().ToPagedList(pageNumber ?? 1, 10);
            ViewBag.claimservices = db.ClaimServices.Where(x => x.Id == Id).ToList().ToPagedList(pageNumber ?? 1, 10);
            ViewBag.claimdrugs = db.ClaimDrugs.Where(x => x.Id == Id).ToList().ToPagedList(pageNumber ?? 1, 10);
            ViewBag.claimbatches = db.ClaimBatches.Where(x => x.ProviderId == ProviderId & x.Id == Id).ToList().ToPagedList(pageNumber ?? 1, 10);
            ViewBag.claimbatches = db.ClaimBatches.Where(x => x.ProviderId == ProviderId & x.Id == Id).ToList().ToPagedList(pageNumber ?? 1, 10);
            ViewBag.enrollees = db.Enrollees.Where(x => x.Policynumber == enrolleePolicyNumber || x.Id == Enrolleeid);
            ViewBag.companybenefits = db.CompanyBenefits.Where(x => x.Companyid == enrolleeCompanyId);
            




            if (ViewBag.claims == null)
            {

            }


            // Session["ClaimId"] = ViewBag.claims.Id;
            return View(db.Claims.Where(x => x.ClaimBatchId == Id || x.ClaimBatchId == ClaimBatchId).ToList().ToPagedList(pageNumber ?? 1, 10));


        }


        // GET: Claims/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Claim claim = db.Claims.Find(id);
            if (claim == null)
            {
                return HttpNotFound();
            }
            return View(claim);
        }

        // GET: Claims/Create
        public ActionResult Create()
        {
            ViewBag.ClaimBatchId = new SelectList(db.ClaimBatches, "Id", "Batch");
            return View();
        }

        // POST: Claims/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProviderId,Enrolleeid,enrolleeFullname,enrolleeGender,enrolleeCompanyName,enrolleeCompanyId,enrolleePolicyNumber,EnrolleePlan,ClaimsSerialNo,EVSCode,DoctorsName,DoctorsId,AreaOfSpecialty,Signature,DoctorSigned,DoctorSignecDate,specialistName,AreaOfSpecialtyforspecialist,specialistphonenumber,specialistSigned,specialistSignecDate,ServiceDate,AdmissionDate,DischargeDate,Durationoftreatment,Diagnosis,TreatmentGiven,TreatmentCode,referalCode,enrolleeSigned,EnrolleeSignDate,AllprescibedDrugs,LaboratoryInvestigation,Admission,Feeding,Note,Tag,capturedBy,capturedName,vettedBy,RevettedBy,VettedDate,ReVettedDate,status,Guid,CreatedOn,UpdatedOn,IsDeleted,ClaimBatchId,SiteId,enrolleeage,ClientsideID,diagnosticsIDString,SubmitByProvider,ipaddressofprovider,MyUserId,vettedName")] Claim claim)
        {
            if (ModelState.IsValid)
            {
                db.Claims.Add(claim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClaimBatchId = new SelectList(db.ClaimBatches, "Id", "Batch", claim.ClaimBatchId);
            return View(claim);
        }

        // GET: Claims/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Claim claim = db.Claims.Find(id);
            if (claim == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClaimBatchId = new SelectList(db.ClaimBatches, "Id", "Batch", claim.ClaimBatchId);
            return View(claim);
        }

        // POST: Claims/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, int Id,[Bind(Include = "Id,ProviderId,Enrolleeid,enrolleeFullname,enrolleeGender,enrolleeCompanyName,enrolleeCompanyId,enrolleePolicyNumber,EnrolleePlan,ClaimsSerialNo,EVSCode,DoctorsName,DoctorsId,AreaOfSpecialty,Signature,DoctorSigned,DoctorSignecDate,specialistName,AreaOfSpecialtyforspecialist,specialistphonenumber,specialistSigned,specialistSignecDate,ServiceDate,AdmissionDate,DischargeDate,Durationoftreatment,Diagnosis,TreatmentGiven,TreatmentCode,referalCode,enrolleeSigned,EnrolleeSignDate,AllprescibedDrugs,LaboratoryInvestigation,Admission,Feeding,Note,Tag,capturedBy,capturedName,vettedBy,RevettedBy,VettedDate,ReVettedDate,status,Guid,CreatedOn,UpdatedOn,IsDeleted,ClaimBatchId,SiteId,enrolleeage,ClientsideID,diagnosticsIDString,SubmitByProvider,ipaddressofprovider,MyUserId,vettedName")] Claim claim)
        {

           
            ViewBag.claimservices = db.ClaimServices.Where(x => x.Id == Id).ToList();
            ViewBag.claimdrugs = db.ClaimDrugs.Where(x => x.Id == Id).ToList();
           

            if (ModelState.IsValid)
            {
                db.Entry(claim).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index", "Drugs", new { id });
            }
            ViewBag.ClaimBatchId = new SelectList(db.ClaimBatches, "Id", "Batch", claim.ClaimBatchId);
            return RedirectToAction("Index", "Drugs", new { id });
        }

        // GET: Claims/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Claim claim = db.Claims.Find(id);
            if (claim == null)
            {
                return HttpNotFound();
            }
            return View(claim);
        }

        // POST: Claims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Claim claim = db.Claims.Find(id);
            db.Claims.Remove(claim);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}