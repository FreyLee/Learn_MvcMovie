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
        public ActionResult Welcome(string name, string greeting = "Hi")
        {
            ViewBag.Name = name == null ? "!" : "," + name + "!";
            ViewBag.Greeting = greeting;

            return View();
        }
    }
}