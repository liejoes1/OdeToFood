﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        // [Authorize]
        public ActionResult Search(string name = "french")
        {
            throw new Exception("Something terrible happened");
            var message = Server.HtmlEncode(name);
            return Content(message);
        }
    }
}