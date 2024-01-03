using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypeView.Models;


namespace StronglyTypeView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                name = "Nandlal",
                Address = "Noida Sector - 62",
                desination = "Software developer"
            };
            
            return View(emp);
        }
    }
}