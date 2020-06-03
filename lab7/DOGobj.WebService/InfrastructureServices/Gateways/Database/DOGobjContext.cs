using Microsoft.EntityFrameworkCore;
using DOGobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using DOGobj.ApplicationServices.Synchronization;
namespace DOGobj.InfrastructureServices.Gateways.Database
{
    public class DOGobjContext : DbContext
    {
        public DbSet<dogobj> DOGobjs { get; set; }

        public DOGobjContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var v = new UseCaseDOGobj();

            modelBuilder.Entity<dogobj>().HasData(v.dogobjs);
        }
    }
}
