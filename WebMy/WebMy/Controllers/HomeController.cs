﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {          

            return View();
        }
        public string Index()
        {
            return "Hello " + Request.Form["Name"] + " " + Request.Form["Surname"];
        }

    }
}