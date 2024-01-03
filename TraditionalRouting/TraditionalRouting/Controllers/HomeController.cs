using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TraditionalRouting.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("Student")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("AboutStudent")]
        public ActionResult About()
        {
            return View();
        }
        [Route("ContactStudent")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}