using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> Products = new List<Product>()
            {
                new Product() {ProductId =101, ProductName="Addon",ProductRate=1000,Productdate=12-1-21},
                new Product() {ProductId = 102,ProductName="Trimmer",ProductRate=1200,Productdate=13-1-21},
                new Product() {ProductId= 103,ProductName="Fogg",ProductRate=1500,Productdate=14-1-21},
                new Product() {ProductId= 104,ProductName= "Pen",ProductRate= 10,Productdate=15-1-12}
            };
            return View(Products);
        }
        public ActionResult Details(int Id)
        {
            List<Product> Products = new List<Product>()
            {
                new Product() {ProductId =101, ProductName="Addon",ProductRate=1000,Productdate=12-1-21},
                new Product() {ProductId = 102,ProductName="Trimmer",ProductRate=1200,Productdate=13-1-21},
                new Product() {ProductId= 103,ProductName="Fogg",ProductRate=1500,Productdate=14-1-21},
                new Product() {ProductId= 104,ProductName= "Pen",ProductRate= 10,Productdate=15-1-21}
            };
            Product matchingProduct = null;
            
                foreach (var item in Products)

                {
                    if (item.ProductId == Id)
                    {
                        matchingProduct = item;
                    }
                }

               
                return View(matchingProduct);
            
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Product A)
        {
            return View();
        }


    }
     
   
}