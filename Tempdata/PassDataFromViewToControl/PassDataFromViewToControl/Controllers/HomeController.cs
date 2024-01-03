using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassDataFromViewToControl.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostUsingParameter(string firstName, string lastName)
        {
            return "Data From -" + firstName + lastName;
        }

        [HttpPost]
        public string PostUsingRequest()
        {

            string firstName = Request["firstName"];
            string lastName = Request["lastName"];
            return "Data From -" + firstName + lastName;
        }

        [HttpPost]
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];
            return "Data From Form Collection -" + firstName + lastName;
        }
    }
}