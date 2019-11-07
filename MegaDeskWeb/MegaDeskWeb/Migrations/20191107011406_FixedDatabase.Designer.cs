﻿// <auto-generated />
using System;
using MegaDeskWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskWeb.Migrations
{
    [DbContext(typeof(MegaDeskWebContext))]
    [Migration("20191107011406_FixedDatabase")]
    partial class FixedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDesk.Desk", b =>
                {
                    b.Property<int>("DeskId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Depth");

                    b.Property<int>("NumberOfDrawers");

                    b.Property<int>("SurfaceMaterialId");

                    b.Property<decimal>("Width");

                    b.HasKey("DeskId");

                    b.HasIndex("SurfaceMaterialId");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("MegaDesk.DeskQuote", b =>
                {
                    b.Property<int>("DeskQuoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName");

                    b.Property<int>("DeskId");

                    b.Property<DateTime>("QuoteDate");

                    b.Property<decimal>("QuotePrice");

                    b.Property<int>("ShippingId");

                    b.HasKey("DeskQuoteId");

                    b.HasIndex("DeskId");

                    b.HasIndex("ShippingId");

                    b.ToTable("DeskQuote");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.Shipping", b =>
                {
                    b.Property<int>("ShippingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Between1000And2000");

                    b.Property<decimal>("Over2000");

                    b.Property<string>("ShippingType");

                    b.Property<decimal>("Under1000");

                    b.HasKey("ShippingId");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("MegaDeskWeb.Models.SurfaceMaterial", b =>
                {
                    b.Property<int>("SurfaceMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost");

                    b.Property<string>("SurfaceMaterialName");

                    b.HasKey("SurfaceMaterialId");

                    b.ToTable("SurfaceMaterial");
                });

            modelBuilder.Entity("MegaDesk.Desk", b =>
                {
                    b.HasOne("MegaDeskWeb.Models.SurfaceMaterial", "SurfaceMaterial")
                        .WithMany()
                        .HasForeignKey("SurfaceMaterialId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MegaDesk.DeskQuote", b =>
                {
                    b.HasOne("MegaDesk.Desk", "Desk")
                        .WithMany()
                        .HasForeignKey("DeskId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MegaDeskWeb.Models.Shipping", "Shipping")
                        .WithMany()
                        .HasForeignKey("ShippingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
