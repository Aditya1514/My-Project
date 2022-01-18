using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;
namespace WebApplication9.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            List<Category> cat = db.Categories.ToList();
            return View(cat);
        }
    }
}