using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SayHello()
        {
            Models.TestClass objInfo = new Models.TestClass();
            objInfo.FirstName = "Alex";
            objInfo.LastName = "Kremenetskiy";
            objInfo.Age = "100";

            return View("InfoView", objInfo);
        }
    }
}