using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace GeneralElectionManagmentSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home_page()
        {
            ViewBag.Message = "My Home Page";
            return View();
        }
        [Route
            ("about us")]
        public ActionResult About()
        {
            ViewBag.Message = "My Home Page";
            return View("About");
        }

        public ActionResult Elections()
        {
            return View();
        }
        public ActionResult for_Voters()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }

        public ActionResult parties_and_candidates()
        {
            return View();
        }
        public ActionResult howtoregister()
        {
            return View();
        }
        public ActionResult how_to_vote()
        {
            return View();
        }
        public ActionResult check_for_validation()
        {
            return View();
        }
        public ActionResult General_election()
        {
            return View();
        }

        public ActionResult Election_laws()
        {
            return View();
        }

        public ActionResult Election_Rules()
        {
            return View();
        }
        public ActionResult Party_possition()
        {
            return View();
        }
        public ActionResult List_of_parties()
        {
            return View();
        }

        public ActionResult Symbols()
        {
            return View();
        }
        public ActionResult Available_symbols()
        {
            return View();
        }


    }
}