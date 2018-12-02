using Moyasar;
using Moyasar.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPaymentMoyasarIssue.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MoyasarBase.ApiKey = "sk_test_xX7j6AcTGrLFL5x9E6d4uWivaP3zvCxP1ajdegxd";
            var payment = new Payment().Fetch("d39b5afb-4b2f-48a9-b4e5-06b507cc775b");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}