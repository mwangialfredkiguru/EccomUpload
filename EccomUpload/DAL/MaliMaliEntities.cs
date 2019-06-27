using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EccomUpload.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EccomUpload.DAL
{
    public class MaliMaliEntities : DbContext
    {
        public MaliMaliEntities() : base("MaliMaliEntities")
        {
        }

        public DbSet<Customer_Reg_Table> Customer_Reg_Table { get; set; }
        public DbSet<Fcm_Token_Table> Fcm_Token_Table { get; set; }
        public DbSet<Products_Table> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}