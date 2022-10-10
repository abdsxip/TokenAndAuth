using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TokenAndAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

         
        public ActionResult Redirect()
        {
            ViewBag.Title = "logged in Successfully";

            return View();
        }
    }
}
