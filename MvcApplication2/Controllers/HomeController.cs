using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        abcEntities db = new abcEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string keyword = "")
        {
            if (keyword !="")
            {
                var products = db.Products.Where(p => p.Name.ToLower().StartsWith(keyword.ToLower()));
                return Json(products, JsonRequestBehavior.AllowGet);
            }
            return Json(null, JsonRequestBehavior.AllowGet);
        }

    }
}
