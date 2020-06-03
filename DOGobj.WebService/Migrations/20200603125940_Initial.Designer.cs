﻿// <auto-generated />
using DOGobj.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DOGobj.WebService.Migrations
{
    [DbContext(typeof(DOGobjContext))]
    [Migration("20200603125940_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("DOGobj.DomainObjects.dogobj", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FencingSite")
                        .HasColumnType("TEXT");

                    b.Property<string>("Landmark")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlatformLighting")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteElements")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DOGobjs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            FencingSite = "да",
                            Landmark = "город Москва, Рублёвское шоссе, дом 26, корпус 4",
                            Name = "Департамент культуры города Москвы",
                            PlatformLighting = "нет",
                            SiteElements = "балансир для собак,барьер одинарный,бум для собак,вышка-лестница (с перилами),скамья для собаководов,трамплин,тренировочный снаряд с покрышкой,урна"
                        },
                        new
                        {
                            Id = 2L,
                            FencingSite = "да",
                            Landmark = "город Москва, улица Удальцова, дом 40",
                            Name = "Департамент культуры города Москвы",
                            PlatformLighting = "да",
                            SiteElements = "барьер одинарный,бум для собак,вышка-лестница (с перилами),горка-лестница (без перил),туннель (нора),скамья для собаководов,трамплин,тренировочный снаряд с покрышкой,урна"
                        },
                        new
                        {
                            Id = 3L,
                            FencingSite = "да",
                            Landmark = "город Москва, улица Мичуринский Проспект, Олимпийская Деревня, дом 1, корпус 2",
                            Name = "Департамент культуры города Москвы",
                            PlatformLighting = "да",
                            SiteElements = "барьер двойной,барьер кольца,входной элемент,горка-лестница (без перил),горка-мостик А-форма,информационный стенд,туннель (нора),скамья для собаководов,трап,урна"
                        },
                        new
                        {
                            Id = 4L,
                            FencingSite = "да",
                            Landmark = "город Москва, Борисовский проезд, дом 5, корпус 1",
                            Name = "Департамент культуры города Москвы",
                            PlatformLighting = "нет",
                            SiteElements = "барьер кольца, бум для собак, туннель (нора)"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
