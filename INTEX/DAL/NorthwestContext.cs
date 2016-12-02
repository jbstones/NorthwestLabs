using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using INTEX.Models;
using System.Data.Entity;
using INTEX.Models.Test;
using INTEX.Models.Payments;
using INTEX.Models.Compounds;

namespace INTEX.DAL
{
    public class NorthwestContext: DbContext
    {
         public NorthwestContext() : base("NorthwestContext") 
        {

        }

        public DbSet<Employees> Employee { get; set;}
        public DbSet<Assay> Assays { get; set;}
        public DbSet<Assay_description> Assay_descriptions { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Work_Order> Work_Orders { get; set; }
        public DbSet<Work_Order_Schedule> WOrk_Order_Schedules { get; set; }
        public DbSet<Materials> Material { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Test_Description> Test_Descriptions { get; set; }
        public DbSet<Test_Materials> Teset_Material { get; set; }
        public DbSet<Test_Results> Test_Result { get; set; }
        public DbSet<Test_Schedule> Test_Schedules { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Payment_Method> Payment_Methods { get; set; }
        public DbSet<Compounds> Compound { get; set; }
        public DbSet<Compounds_Assays> Compound_Assay { get; set; }
        public DbSet<Compound_Receipt> Compound_Receipts { get; set; }
        
    }
}