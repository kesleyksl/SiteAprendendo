﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteAprendendo.Models;

namespace SiteAprendendo.Migrations
{
    [DbContext(typeof(SiteAprendendoContext))]
    [Migration("20190703132145_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SiteAprendendo.Models.Departament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departament");
                });

            modelBuilder.Entity("SiteAprendendo.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("MyProperty");

                    b.Property<int?>("SellerId");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("SiteAprendendo.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DepartamentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SiteAprendendo.Models.SalesRecord", b =>
                {
                    b.HasOne("SiteAprendendo.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("SiteAprendendo.Models.Seller", b =>
                {
                    b.HasOne("SiteAprendendo.Models.Departament", "Departament")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartamentId");
                });
#pragma warning restore 612, 618
        }
    }
}
