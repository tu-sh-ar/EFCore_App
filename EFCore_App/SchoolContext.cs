using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_App
{
    public class SchoolContext:DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }

        public SchoolContext() : base()
        {
        }

        // Summary:OnConfiguring
        //     Override this method to set defaults and configure conventions before they run.
        //     This method is invoked before Microsoft.EntityFrameworkCore.DbContext.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder).
        //
        // Parameters:
        //   configurationBuilder:
        //     The builder being used to set defaults and configure conventions that will be
        //     used to build the model for this context.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SI2PJCE;Database=SchoolDB;Trusted_Connection=True;");
        }


        // Summary:OnModelCreating
        //     Override this method to further configure the model that was discovered by convention
        //     from the entity types exposed in Microsoft.EntityFrameworkCore.DbSet`1 properties
        //     on your derived context. The resulting model may be cached and re-used for subsequent
        //     instances of your derived context.
        //
        // Parameters:
        //   modelBuilder:
        //     The builder being used to construct the model for this context. Databases (and
        //     other extensions) typically define extension methods on this object that allow
        //     you to configure aspects of the model that are specific to a given database.
        

    }
}
