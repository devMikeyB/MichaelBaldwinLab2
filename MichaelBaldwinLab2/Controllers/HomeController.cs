using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MichaelBaldwinLab2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "InLine Description.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "InLine Developer Contact information.";

            return View();
        }
    }
}