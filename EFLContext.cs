using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EntityFrameworkLearn
{
    class EFLContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public EFLContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);Database=EntityDB;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Data Source=" + Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "EntityDB") + " Trusted_Connection=True; server=(local)");
            //optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB; Database=EntityDB; Trusted_Connection=True;");
        }
    }
}