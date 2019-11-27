using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestClasses;

namespace JilBugExampleNET.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         Jil.JSON.Deserialize<Dictionary<string, InheritedExampleGeneric>>("{}");
         ViewBag.Title = "Home Page";
         return View();
      }
   }
}
