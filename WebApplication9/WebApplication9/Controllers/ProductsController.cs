using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;
namespace WebApplication9.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            //Retriving all Rows.
            List<Product> Produc = db.Products.ToList();
            //Retriving Single row
          //  List<Product> Produc= db.Products.Where(temp => temp.Price > 50000).ToList();
            return View(Produc);
        }
    }
}