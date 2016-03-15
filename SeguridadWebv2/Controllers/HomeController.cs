using SistemaWebData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguridadWebv2.Controllers
{
    public class HomeController : Controller
    {
        SistemaWebContext db = new SistemaWebContext();
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var showautos = db.Autos.ToList();
            return View(showautos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
	}
}