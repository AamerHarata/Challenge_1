﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestGoogle.Data;

namespace TestGoogle.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190905230019_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("TestGoogle.Models.Defect", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DefType");

                    b.Property<int>("TestNumber");

                    b.Property<DateTime>("Time");

                    b.Property<string>("xAco");

                    b.Property<string>("xGeo");

                    b.Property<string>("yAco");

                    b.Property<string>("yGeo");

                    b.Property<string>("zAco");

                    b.HasKey("Id");

                    b.ToTable("Defects");
                });

            modelBuilder.Entity("TestGoogle.Models.MobileData", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("TestNumber");

                    b.Property<string>("xAco");

                    b.Property<string>("xGeo");

                    b.Property<string>("yAco");

                    b.Property<string>("yGeo");

                    b.Property<string>("zAco");

                    b.HasKey("Id");

                    b.ToTable("MobileData");
                });

            modelBuilder.Entity("TestGoogle.Models.Possible", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TestNumber");

                    b.Property<bool>("Tested");

                    b.Property<DateTime>("Time");

                    b.Property<int>("Type");

                    b.Property<string>("xAco");

                    b.Property<string>("xGeo");

                    b.Property<string>("yAco");

                    b.Property<string>("yGeo");

                    b.Property<string>("zAco");

                    b.HasKey("Id");

                    b.ToTable("Possibles");
                });
#pragma warning restore 612, 618
        }
    }
}
