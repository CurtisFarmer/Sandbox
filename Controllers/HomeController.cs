using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Curtis Farmer's"; 
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Need to get in touch?";

            return View();
        }

        public ActionResult Item()
        {
            

            return View();
        }

        public ActionResult Vendor()
        {


            return View();
        }

        public ActionResult PurchaseOrder()
        {


            return View();
        }
    }
}