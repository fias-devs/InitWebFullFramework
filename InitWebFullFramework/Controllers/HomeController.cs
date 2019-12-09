using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InitWebFullFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int a = 0;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = "Your application description page.";
            ViewBag.Message = "Your application description page2.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}