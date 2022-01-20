using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;
namespace WebApplication10.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        //Search
        public ActionResult Index(string search ="")
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            ViewBag.search = search;
            List<Brand> Br= db.Brands.Where(temp => temp.BrandName.Contains(search)).ToList();
            return View(Br);
        }
        //Retriving a row
        public ActionResult Details(long id)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            Brand B = db.Brands.Where(temp => temp.BrandID == id).FirstOrDefault();
            return View(B);
        }
        public ActionResult Edit(long id)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            Brand existingBrand = db.Brands.Where(temp => temp.BrandID == id).FirstOrDefault();
            return View(existingBrand);
        }
        //Post req
        [HttpPost]
        public ActionResult Edit(Brand A)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            Product existingBrand = db.Products.Where(temp => temp.BrandID == A.BrandID).FirstOrDefault();
            existingBrand.BrandID = A.BrandID;
            existingBrand.ProductName = A.BrandName;
           
            db.SaveChanges();
            return RedirectToAction("Index","Brands");
        }
    }


}
