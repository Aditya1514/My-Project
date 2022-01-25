using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;
namespace WebApplication13.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Catagory
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Category> C = db.Categories.ToList();
            return View(C);
        }
    }
}