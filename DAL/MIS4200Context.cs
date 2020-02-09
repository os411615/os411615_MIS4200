using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using os411615_MIS4200.Models; // to access the models
using System.Data.Entity; // this is needed to access the DbContext object

namespace os411615_MIS4200.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // add the SetInitializer statement here
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, os411615_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        // this method is a 'constructor' and is called when a new context is created
        // the base attribute says which connection string to use

        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Appointment> Appointment { get; set; }

        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}