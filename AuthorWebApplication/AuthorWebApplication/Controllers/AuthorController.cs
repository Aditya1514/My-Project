using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthorWebApplication.Models;
namespace AuthorWebApplication.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            KingEntities db = new KingEntities();
            List<author> A = db.authors.ToList();
            return View(A);
        }
    }
}