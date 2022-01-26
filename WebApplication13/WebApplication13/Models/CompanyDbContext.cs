using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using WebApplication13.Migrations;
namespace WebApplication13.Models
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("MyConnectionStrings")
        {
          Database.SetInitializer(new MigrateDatabaseToLatestVersion<CompanyDbContext, Configuration>());
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}