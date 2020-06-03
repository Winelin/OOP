using Microsoft.EntityFrameworkCore;
using DOGobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

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
            FillTestData(modelBuilder);
        }
        private void FillTestData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<dogobj>().HasData(
                new
                {
                    Id = 1L,
                    Name = "Департамент культуры города Москвы",
                    Landmark = "город Москва, Рублёвское шоссе, дом 26, корпус 4",
                    SiteElements = "балансир для собак,барьер одинарный,бум для собак,вышка-лестница (с перилами),скамья для собаководов,трамплин,тренировочный снаряд с покрышкой,урна",
                    PlatformLighting = "нет",
                    FencingSite = "да",
                },
                new
                {
                    Id = 2L,
                    Name = "Департамент культуры города Москвы",
                    Landmark = "город Москва, улица Удальцова, дом 40",
                    SiteElements = "барьер одинарный,бум для собак,вышка-лестница (с перилами),горка-лестница (без перил),туннель (нора),скамья для собаководов,трамплин,тренировочный снаряд с покрышкой,урна",
                    PlatformLighting = "да",
                    FencingSite = "да",

                },
                new
                {
                    Id = 3L,
                    Name = "Департамент культуры города Москвы",
                    Landmark = "город Москва, улица Мичуринский Проспект, Олимпийская Деревня, дом 1, корпус 2",
                    SiteElements = "барьер двойной,барьер кольца,входной элемент,горка-лестница (без перил),горка-мостик А-форма,информационный стенд,туннель (нора),скамья для собаководов,трап,урна",
                    PlatformLighting = "да",
                    FencingSite = "да",

                },
                new
                {
                    Id = 4L,
                    Name = "Департамент культуры города Москвы",
                    Landmark = "город Москва, Борисовский проезд, дом 5, корпус 1",
                    SiteElements = "барьер кольца, бум для собак, туннель (нора)",
                    PlatformLighting = "нет",
                    FencingSite = "да",

                }
               
            );
        }
    }
}
