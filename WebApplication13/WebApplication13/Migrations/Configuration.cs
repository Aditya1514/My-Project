namespace WebApplication13.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication13.Models.CompanyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication13.Models.CompanyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Brands.Add(new Models.Brand() { BrandID = 1, BrandName = "Samsung" });
            context.Brands.Add(new Models.Brand() { BrandID = 2, BrandName = "WashingMachine" });
            context.Categories.Add(new Models.Category() { CategoryID = 1, CategoryName = "Electronics" });
            context.Categories.Add(new Models.Category()
            { CategoryID = 2, CategoryName = "HomeAppliances" });
            context.Products.Add(new Models.Product() { ProductID = 1, ProductName = "Samsung S21", Price = 25000, DateOfPurchase = DateTime.Now, CategoryID = 1, BrandID = 1 });
            context.Products.Add(new Models.Product() { ProductID = 2, ProductName = "WashingMachine", Price = 30000, DateOfPurchase = DateTime.Today, CategoryID = 2, BrandID = 2 });


        }
    }
}
