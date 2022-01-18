using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;
namespace WebApplication9.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        public ActionResult Index()
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            //Retriving All rows
            List<Brands> Brands = db.Brands.ToList();
            //Retriving Single row
            // List<Brand> Brands =  db.Brands.Where(temp => temp.BrandName == "Samsung").ToList();
            return View(Brands);
        }
    }
}