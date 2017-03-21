using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloFangErController : Controller
    {
        // GET: HelloFangEr
        public ActionResult Index()
        {
            ViewBag.msg = "Hello! 方二";
            return View();
        }
    }
}