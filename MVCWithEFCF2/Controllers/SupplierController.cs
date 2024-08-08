using MVCWithEFCF2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFCF2.Controllers
{
    public class SupplierController : Controller
    {
        
        CompanyDBContext dc = new CompanyDBContext();
        public ActionResult Index()
        {
            //Supplier s1 = new Supplier { Sid = 101, SupplierName = "Ashok Distributors." };
            //Supplier s2 = new Supplier { Sid = 102, SupplierName = "Meghna Distributors." };
            //Supplier s3 = new Supplier { Sid = 103, SupplierName = "Diamond Distributors." };
            //Supplier s4 = new Supplier { Sid = 104, SupplierName = "Prasad Distributors." };
            //dc.Suppliers.Add(s1); //dc.Suppliers.Add(s2);
            //dc.Suppliers.Add(s3); //dc.Suppliers.Add(s4);
            /*var sup1 = dc.Suppliers.Find(101);
            dc.Entry(sup1).State = System.Data.Entity.EntityState.Deleted;
            dc.Entry(dc.Suppliers.Find(102)).State = System.Data.Entity.EntityState.Deleted;
            dc.Entry(dc.Suppliers.Find(103)).State = System.Data.Entity.EntityState.Deleted;
            dc.SaveChanges();*/
            return View(dc.Suppliers);
        }

    }
}