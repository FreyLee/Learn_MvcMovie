using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "项目描述";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "联系作者";

            return View();
        }
    }
}