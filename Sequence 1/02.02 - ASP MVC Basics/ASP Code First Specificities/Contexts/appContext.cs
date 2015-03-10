using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ASP_Code_First_Specificities.Entities;
using System.ComponentModel.DataAnnotations.Schema;
namespace ASP_Code_First_Specificities.Contexts
{
    public class AppContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        public DbSet<School> Schools { get; set; }

        public AppContext()
            : base("name=AppContext")
        {
            Database.SetInitializer<AppContext>(new System.Data.Entity.CreateDatabaseIfNotExists<AppContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(student => student.Id);
            modelBuilder.Entity<Student>().Property(student => student.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            

            base.OnModelCreating(modelBuilder);
        }



    }
}