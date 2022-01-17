using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;
namespace WebApplication8.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create([ModelBinder(typeof(CustomBinder))] Student st)
        {
            return View();
        }
    }

    internal class CustomBinder
    {
    }
}