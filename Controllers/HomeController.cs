using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW_6_u19056509.Models;
using PagedList;
using PagedList.Mvc;

namespace HW_6_u19056509.Controllers
{
    public class HomeController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();
        public ActionResult Orders(int? id, string search, int? i)
        {
            return View(db.products.Where(x => x.product_name.StartsWith(search) || search == null).ToList().ToPagedList(i ?? 1, 10));
        }

        public ActionResult Report()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }


    }
}