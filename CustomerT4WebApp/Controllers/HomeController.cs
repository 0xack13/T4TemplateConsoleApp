using CustomerT4WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerT4WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult customerList()
        {
            List<Customer> c = new List<Customer>();
            c.Add( new Customer
            {
                Id = 2,
                Name = "Saleh",
                Age = 14
            });
            ViewBag.Message = "Your contact page.";

            return View(c);
        }
    }
}
