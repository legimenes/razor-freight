﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorFreight.Data;

#nullable disable

namespace RazorFreight.Data.Migrations
{
    [DbContext(typeof(RazorFreightDbContext))]
    partial class RazorFreightDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("RazorFreight.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DistanceInKm")
                        .HasColumnType("REAL");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Origin", "Destination")
                        .IsUnique()
                        .HasDatabaseName("OriginDestinationIndex");

                    b.ToTable("Courses", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
