using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.desc = "Hello World";
            return View();
        }
        
        public ActionResult Index2(string id)
        {
            ViewBag.desc = "Hello World"+ id;
            return View();
        }
        
    }
}