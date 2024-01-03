using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AsyncController.Models;

namespace AsyncController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        NewDbEntities db = new NewDbEntities();
        
        public ActionResult Index()
        {
            var list = db.Employees.ToList();
            //db.SaveChanges();
            return View(list);
        }
    }
}