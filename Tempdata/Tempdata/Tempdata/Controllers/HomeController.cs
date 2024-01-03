using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tempdata.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["keyData"] = "Hello how Are You";
            ViewBag.Message = TempData.Peek("keyData");
            //TempData.Keep();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = TempData.Peek("keyData");
            TempData.Keep();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = TempData.Peek("keyData");
            return View();
        }
    }
}