using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateHtmlHelper.Models;


namespace TemplateHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["companyName"] = "Presto Infosolutions Pvt.Ltd";
            Employee emp = new Employee()
            {
                id = 1,
                name = "Nandu",
                DateOfBirth = DateTime.Now,
                Email = "nandu@gmail.com",
                IsOnline = true
            };
            return View(emp);
        }
    }
}