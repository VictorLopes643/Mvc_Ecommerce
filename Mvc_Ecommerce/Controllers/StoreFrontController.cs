using Mvc_Ecommerce.DAL;
using Mvc_Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Ecommerce.Controllers
{
    public class StoreFrontController : Controller
    {

        private Mvc_EcommerceContext db = new Mvc_EcommerceContext();
        // GET: StoreFront
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }


    }
}