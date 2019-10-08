using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AwareGroup.Demos.AspMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string testString = ConfigurationManager.AppSettings["EnvironmentType"];
            ViewBag.Message = testString;

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