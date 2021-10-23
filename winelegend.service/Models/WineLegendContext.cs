using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using winelegend.models;

namespace winelegend.service.Models
{
    public class WineLegendContext : DbContext
    {
        public WineLegendContext() : base("WineLegendContext") 
        {
            Database.SetInitializer<WineLegendContext>(null); ;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}