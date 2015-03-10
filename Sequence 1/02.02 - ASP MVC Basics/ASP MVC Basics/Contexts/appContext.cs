using ASP_MVC_Basics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_MVC_Basics.Contexts
{
    public class AppContext : DbContext
    {
        public DbSet<Student> Students {  get; set; }

        public AppContext()
            : base("name=AppContextConnectionString")
        {
            Database.SetInitializer<AppContext>(new System.Data.Entity.CreateDatabaseIfNotExists<AppContext>());

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>().HasKey(p => p.ID);
            //modelBuilder.Entity<Student>().Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            base.OnModelCreating(modelBuilder);
        }

    }
}