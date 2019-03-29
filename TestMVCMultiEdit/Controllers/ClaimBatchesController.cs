using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestMVCMultiEdit.Models;
using PagedList;
using NovoClaims.ViewModel;

namespace TestMVCMultiEdit.Controllers
{
    public class ClaimBatchesController : Controller
    {
        private DB_A0009D_NovoHubEntities db = new DB_A0009D_NovoHubEntities();

       
        public ActionResult Index(int? Id, int? ClaimBatchId, int ProviderId, int year, int? pageNumber)
        {
            //ViewBag.ProviderList = new SelectList(db.Providers.OrderBy(s => s.Name), "Id", "Name");
            ViewBag.claims = db.Claims.Where(x => x.ClaimBatchId == Id || x.ClaimBatchId == ClaimBatchId).ToList().ToPagedList(pageNumber ?? 1, 10);
            
            ViewBag.providers = db.Providers.Where(x => x.Id == ProviderId).ToList().ToPagedList(pageNumber ?? 1, 10);
            return View(db.ClaimBatches.Where(x => x.ProviderId == ProviderId && x.year == year).ToList().ToPagedList(pageNumber ?? 1, 10));
           
           

        }
        // GET: ClaimBatches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClaimBatch claimBatch = db.ClaimBatches.Find(id);
            if (claimBatch == null)
            {
                return HttpNotFound();
            }
            return View(claimBatch);
        }

        // GET: ClaimBatches/Create
        public ActionResult Create()
        {
            ViewBag.paymentbatchId = new SelectList(db.PaymentBatches, "Id", "Title");
            return View();
        }

        // POST: ClaimBatches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProviderId,month,year,Batch,status,submitedVetbyUser,submitedReviewbyUser,SubmitedForReviewDate,reviewDate,reviewedBy,VetDate,SubmitedForPaymentDate,submitedPaymentbyUser,AuthorizationStatus,AuthorizationNote,DisapprovalNote,AuthorizedBy,DisapprovedBy,AuthorizedDate,DisapprovalDate,DeletionNote,Guid,CreatedOn,UpdatedOn,IsDeleted,SiteId,paymentbatchId,AmountPaid,paymentmethod,paymentref,chequeno,sourceBankName,sourceBankAccountNo,DestBankName,DestBankAccountNo,remark,paymentdate,paidby,markpaidby,ProviderName,claimscountfromclient,paymentmethodstring,paymentadvicesent,datepaymentadvicesent,isremote")] ClaimBatch claimBatch)
        {
            if (ModelState.IsValid)
            {
                db.ClaimBatches.Add(claimBatch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.paymentbatchId = new SelectList(db.PaymentBatches, "Id", "Title", claimBatch.paymentbatchId);
            return View(claimBatch);
        }

        // GET: ClaimBatches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClaimBatch claimBatch = db.ClaimBatches.Find(id);
            if (claimBatch == null)
            {
                return HttpNotFound();
            }
            ViewBag.paymentbatchId = new SelectList(db.PaymentBatches, "Id", "Title", claimBatch.paymentbatchId);
            return View(claimBatch);
        }

        // POST: ClaimBatches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProviderId,month,year,Batch,status,submitedVetbyUser,submitedReviewbyUser,SubmitedForReviewDate,reviewDate,reviewedBy,VetDate,SubmitedForPaymentDate,submitedPaymentbyUser,AuthorizationStatus,AuthorizationNote,DisapprovalNote,AuthorizedBy,DisapprovedBy,AuthorizedDate,DisapprovalDate,DeletionNote,Guid,CreatedOn,UpdatedOn,IsDeleted,SiteId,paymentbatchId,AmountPaid,paymentmethod,paymentref,chequeno,sourceBankName,sourceBankAccountNo,DestBankName,DestBankAccountNo,remark,paymentdate,paidby,markpaidby,ProviderName,claimscountfromclient,paymentmethodstring,paymentadvicesent,datepaymentadvicesent,isremote")] ClaimBatch claimBatch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(claimBatch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.paymentbatchId = new SelectList(db.PaymentBatches, "Id", "Title", claimBatch.paymentbatchId);
            return View(claimBatch);
        }

        // GET: ClaimBatches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClaimBatch claimBatch = db.ClaimBatches.Find(id);
            if (claimBatch == null)
            {
                return HttpNotFound();
            }
            return View(claimBatch);
        }

        // POST: ClaimBatches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClaimBatch claimBatch = db.ClaimBatches.Find(id);
            db.ClaimBatches.Remove(claimBatch);
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
