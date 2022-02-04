using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthorWebApplication.Models;
namespace AuthorWebApplication.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            KingEntities db = new KingEntities();
            List<book> B = db.books.ToList();
            return View(B);
        }
    }
}