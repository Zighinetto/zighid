using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZigId.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.AcceptTypes.Contains("application/xrds+xml"))
            {
                ViewData["OPIdentifier"] = true;
                return View("Xrds");
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}