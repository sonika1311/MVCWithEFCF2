using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEFCF2.Models
{
    public class CompanyDBContext : DbContext
    {
       public CompanyDBContext() : base("ConStr")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<CompanyDBContext>());
            Database.SetInitializer(new CompanyDBInitialiser());

        }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}