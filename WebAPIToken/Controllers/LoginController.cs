﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIToken.Controllers
{
   [AllowAnonymous]
   public class LoginController : Controller
    {
      // GET: Login
      public ActionResult SecurityInfo()
      {
         return View();
      }
   }
}