using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;
namespace WebApplication13.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
           CompanyDbContext  db = new CompanyDbContext();
            List<Product> P = db.Products.ToList();
            return View(P);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product P)
        {
            CompanyDbContext db = new CompanyDbContext();
            db.Products.Add(P);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}