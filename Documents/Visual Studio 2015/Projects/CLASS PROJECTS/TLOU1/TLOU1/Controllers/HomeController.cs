using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TLOU1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The world is scary. Find your safe space.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Email us at 12345@tlou.org.";

            return View();
        }
    }
}