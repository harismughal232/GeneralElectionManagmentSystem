﻿using System;
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

    }
}