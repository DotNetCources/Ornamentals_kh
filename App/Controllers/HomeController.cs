using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
           if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Products");
            else
                return RedirectToAction("Login", "Account");
        
        }
      

        public ActionResult Contact()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Products");
            else
                return RedirectToAction("Login", "Account");

           //   return View();
        }
    }
}