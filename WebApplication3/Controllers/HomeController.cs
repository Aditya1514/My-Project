using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
       /* public ActionResult RequestExample()
        {
            ViewBag.Url = Request.Url;
            ViewBag.PhysicalApplicationPath = Request.PhysicalApplicationPath;
              ViewBag.BrowserType = Request.Browser.Type;
              ViewBag.QueryString = Request.QueryString['n'];
              ViewBag.Headers = Request.Headers["Accept"];
             ViewBag.HttpMethod = Request.HttpMethod;
            return View();
        }*/
       public ActionResult ResponseExample()
        {
            Response.Write("Hello from Aditya");
            return View();
        }
       
    }
}