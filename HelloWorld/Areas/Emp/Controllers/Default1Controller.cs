using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Areas.Emp.Controllers
{
    public class Default1Controller : Controller
    {
        // GET: Emp/Default1
        public ActionResult Index()
        {
            ViewBag.desc = "Hello Emp";
            return View();
        }
    }
}