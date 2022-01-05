using LoginProcess.BusinessLayer.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.AppLoginProcess.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Test test = new Test();
            test.List();
            return View();
        }
    }
}