using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NJCPWebApplication.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "NJCP Home";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Title = "Services";
            return View();
        }

        public ActionResult Donate()
        {
            ViewBag.Title = "Donate";
            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Title = "Contacts";
            return View();
        }

        public ActionResult Ministries(string ministry)
        {
            ViewBag.Title = ministry;
            ViewBag.Page= ministry;
            return View();
        }
        public ActionResult PropheticMinistry()
        {
            //ViewBag.Title = "Prophetic Ministry";
            return PartialView();
        }
        public ActionResult WomenMinistry()
        {
            //ViewBag.Title = "Women Ministry ";
            return PartialView();
        }
        public ActionResult ChoirMinistry()
        {
            //ViewBag.Title = "Choir Ministry";
            return PartialView();
        }
        public ActionResult SundaySchool()
        {
            //ViewBag.Title = "Sunday School";
            return PartialView();
        }
        public ActionResult Ushering()
        {
           // ViewBag.Title = "Ushering";
            return PartialView();
        }
        public ActionResult Media()
        {
            //ViewBag.Title = "Media";
            return PartialView();
        }
        public ActionResult Welfare()
        {
            //ViewBag.Title = "Welfare";
            return PartialView();
        }
        public ActionResult Galary()
        {
            //ViewBag.Title = "Galary";
            return PartialView();
        }
        public ActionResult UpcomingEvent()
        {
            //ViewBag.Title = "Galary";
            return PartialView();
        }
    }
}
