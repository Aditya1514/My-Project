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
       
    }
}