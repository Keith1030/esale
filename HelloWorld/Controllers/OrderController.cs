using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            Models.OrderService orderService = new Models.OrderService();
            var result = orderService.GetOrderById("001");
            ViewBag.CustId = result.CustId;
            ViewBag.CustName = result.CustName;
            ViewBag.EmpId = result.EmpId;
            ViewBag.EmpName = result.EmpName;
            ViewBag.Orderdate = result.Orderdate;
            return View();
        }
    }
}