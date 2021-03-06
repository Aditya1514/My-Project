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

        //search
        public ActionResult Index(string rand = "")
        {
           KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            ViewBag.search = rand;
            List<Product> Products = db.Products.Where(temp => temp.ProductName.Contains(rand)).ToList();
            return View(Products);
        }

        //Retriving a row single into another Webpage
        public ActionResult Details(long id)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            Product P= db.Products.
                Where(temp =>temp.ProductID == id).FirstOrDefault();
            return View(P);
        }
        
        //creating a row in a db [get]Method
        public ActionResult Create()
        {
            //Creating a dynamic drop down//

            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Brands = db.Brands.ToList();
            return View();
        }


        //creating a row in a db [Post]Method
        [HttpPost]
        public ActionResult Create(Product P)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            //posting a image
            if(Request.Files.Count >= 1)
            {
                var file = Request.Files[0];
                var imgBytes = new Byte[file.ContentLength];
                file.InputStream.Read(imgBytes, 0, file.ContentLength);
                var base64String = Convert.ToBase64String(imgBytes, 0, imgBytes.Length);
                P.Photo = base64String;
            }
            db.Products.Add(P);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Creating a Update
        //Get
        public ActionResult Edit(long id)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            Product existingProduct = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(existingProduct);
        }
        //Post req
        [HttpPost]
         public ActionResult Edit (Product A)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            Product existingProduct = db.Products.Where(temp => temp.ProductID == A.ProductID).FirstOrDefault();
            existingProduct.ProductID = A.ProductID;
            existingProduct.ProductName = A.ProductName;
            existingProduct.Price = A.Price;
            existingProduct.DateOfPurchase = A.DateOfPurchase;
            existingProduct.CategoryID = A.CategoryID;
            existingProduct.BrandID = A.BrandID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Delete request
         public ActionResult Delete(long id)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            Product existingProduct = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(existingProduct);
        }

        [HttpPost]
         public ActionResult Delete (long id,Product A)
        {
            KingFirstDatabaseEntities db = new KingFirstDatabaseEntities();
            Product existingProduct = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            db.Products.Remove(existingProduct);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}