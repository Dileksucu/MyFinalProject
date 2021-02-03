using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak 
    public class NorthwindContext: DbContext
    {
        //override yazdıktan sonra on yazıp enterladık
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)mssqllocalIdb;Database-Nortwind;Trusted_Connection-true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> customers { get; set; }
         //DbSet - kategoriyle , kşilerle ve ürünlerle baplantı kurduj

    }


}
