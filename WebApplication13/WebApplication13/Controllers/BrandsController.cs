using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;
namespace WebApplication13.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        public ActionResult Index()
        {
           CompanyDbContext db = new CompanyDbContext();
            List<Brand> B = db.Brands.ToList();
            return View(B);
        }
    }
}