using CustomExceptionFilter.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomExceptionFilter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [NandlalExceptionFilter]
        public ActionResult Index()
        {
            return View("Nandlal");
        }
    }
}