using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJECT_CSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";

            return View();
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Your Profile page.";

            return View();
        }

        public ActionResult OrderDetail()
        {
            ViewBag.Message = "Your OrderDetail page.";

            return View();
        }

        public ActionResult ProductGrid()
        {
            ViewBag.Message = "Your ProductGrid page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Your Register page.";

            return View();
        }

        public ActionResult ProductDetail()
        {
            ViewBag.Message = "Your ProductDetail page.";

            return View();
        }

        public ActionResult AccountDetail()
        {
            ViewBag.Message = "Your AccountDetail page.";

            return View();
        }

        public ActionResult VoucherDetail()
        {
            ViewBag.Message = "Your VoucherDetail page.";

            return View();
        }

        public ActionResult CategoryDetail()
        {
            ViewBag.Message = "Your CategoryDetail page.";

            return View();
        }

        public ActionResult Cart()
        {
            ViewBag.Message = "Your Card page.";

            return View();
        }

        public ActionResult Checkout()
        {
            ViewBag.Message = "Your Checkout page.";

            return View();
        }

        public ActionResult SingleProduct()
        {
            ViewBag.Message = "Your SingleProduct page.";

            return View();
        }
    }
}