using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestMVCMultiEdit.Models;

namespace TestMVCMultiEdit.Controllers
{
    public class PaymentBatchesController : Controller
    {
        private DB_A0009D_NovoHubEntities db = new DB_A0009D_NovoHubEntities();

        // GET: PaymentBatches
        public ActionResult Index()
        {
            return View(db.PaymentBatches.ToList());
        }

        // GET: PaymentBatches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentBatch paymentBatch = db.PaymentBatches.Find(id);
            if (paymentBatch == null)
            {
                return HttpNotFound();
            }
            return View(paymentBatch);
        }

        // GET: PaymentBatches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentBatches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,Note,status,datepaymentstarted,datepaymentcompleted,terminationdate,paidby,createdBy,Guid,CreatedOn,UpdatedOn,IsDeleted,SiteId,terminatedby")] PaymentBatch paymentBatch)
        {
            if (ModelState.IsValid)
            {
                db.PaymentBatches.Add(paymentBatch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paymentBatch);
        }

        // GET: PaymentBatches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentBatch paymentBatch = db.PaymentBatches.Find(id);
            if (paymentBatch == null)
            {
                return HttpNotFound();
            }
            return View(paymentBatch);
        }

        // POST: PaymentBatches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,Note,status,datepaymentstarted,datepaymentcompleted,terminationdate,paidby,createdBy,Guid,CreatedOn,UpdatedOn,IsDeleted,SiteId,terminatedby")] PaymentBatch paymentBatch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paymentBatch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paymentBatch);
        }

        // GET: PaymentBatches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentBatch paymentBatch = db.PaymentBatches.Find(id);
            if (paymentBatch == null)
            {
                return HttpNotFound();
            }
            return View(paymentBatch);
        }

        // POST: PaymentBatches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PaymentBatch paymentBatch = db.PaymentBatches.Find(id);
            db.PaymentBatches.Remove(paymentBatch);
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
