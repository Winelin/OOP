using Microsoft.EntityFrameworkCore;
using DOGobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOGobj.InfrastructureServices.Gateways.Database
{
    public class DOGobjContext : DbContext
    {
        public DbSet<DomainObjects.DOGobj> DOGobjs { get; set; }


        public DOGobjContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DomainObjects.DOGobj>().HasData(
              new DomainObjects.DOGobj()
              {
                  Id = 1L,
                  DepartmentalAffiliation = "Департамент культуры города Москвы",
                  Landmark = "город Москва, Рублёвское шоссе, дом 26, корпус 4",
                  SiteElements = "балансир для собак,барьер одинарный,бум для собак,вышка-лестница (с перилами),скамья для собаководов,трамплин,тренировочный снаряд с покрышкой,урна",
                  PlatformLighting = "нет",
                  FencingSite = "да"
              }
           );
        }      
    }
}
