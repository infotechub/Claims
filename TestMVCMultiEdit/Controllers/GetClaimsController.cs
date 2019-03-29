using NovoClaims.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCMultiEdit.Models;

namespace TestMVCMultiEdit.Controllers
{
    public class GetClaimsController : Controller
    {

        private DB_A0009D_NovoHubEntities db = new DB_A0009D_NovoHubEntities();

        [HttpGet]
        public ActionResult ProviderList()
        {



            ViewBag.ProviderList = new SelectList(db.Providers.OrderBy(s => s.Name), "Id", "Name");


            return View();
        }
    }
}