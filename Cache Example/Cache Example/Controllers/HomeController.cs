using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cache_Example.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache (Duration = 60)]
        public ActionResult ShowTime()
        {
            ViewBag.Time =  DateTime.Now;
            return View();
        }

    }
}