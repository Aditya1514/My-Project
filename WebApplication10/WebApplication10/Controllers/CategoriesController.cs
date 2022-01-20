﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;
namespace WebApplication10.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            List<Category> Cat = db.Categories.ToList();
            return View(Cat);
        }
    }
}