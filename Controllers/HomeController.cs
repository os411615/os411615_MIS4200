﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace os411615_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The World of O'Neal";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hi, Contact Me.";

            return View();
        }
    }
}