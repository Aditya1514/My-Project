using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;
namespace WebApplication10.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(string rand = "")
        {
           KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            ViewBag.search = rand;
            List<Product> Products = db.Products.Where(temp => temp.ProductName.Contains(rand)).ToList();
            return View(Products);
        }
        public ActionResult Details(long id)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            Product P= db.Products.
                Where(temp =>temp.ProductID == id).FirstOrDefault();
            return View(P);
        }
        
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Product P)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            db.Products.Add(P);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}