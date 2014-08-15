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


            ViewBag.Message = ConnectionStrings.Demo;

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

        public ActionResult OrderList()
        {
            List<Order> c = new List<Order>();
            c.Add(new Order
            {
                orderNum = 2,
                orderName = "Saleh"
            });
            ViewBag.Message = "Your contact page.";

            return View(c);
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
