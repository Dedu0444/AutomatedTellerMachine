using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        //GET/home/index
        public ActionResult Index()
        {
         
            return View();
        }
        //GET/home/about 
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

        public ActionResult Foo()
        {

            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {

            var Serial = "ASPNETMVCATM1";
            if (letterCase == "lower")
            {
                return Content(Serial.ToLower());
            }

            return Content(Serial);

        }
    }


}