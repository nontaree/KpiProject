using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kpiTest.Models;

namespace kpiTest.Controllers
{
    public class HomeController : Controller
    {
        private KPIEntities db = new KPIEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuTeacher()
        {
            return View();
        }

        //public ActionResult AssessmentTeacher()
        //{
        //    return View();
        //}


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