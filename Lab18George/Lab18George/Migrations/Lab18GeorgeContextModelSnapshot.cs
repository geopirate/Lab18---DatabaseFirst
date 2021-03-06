﻿// <auto-generated />
using Lab18George.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Lab18George.Migrations
{
    [DbContext(typeof(Lab18GeorgeContext))]
    partial class Lab18GeorgeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab18George.Models.Destination", b =>
                {
                    b.Property<int>("DestinationID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.Property<int>("WeatherID");

                    b.HasKey("DestinationID");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("Lab18George.Models.Supply", b =>
                {
                    b.Property<int>("SupplyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DestinationID");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("SupplyID");

                    b.HasIndex("DestinationID");

                    b.ToTable("Supply");
                });

            modelBuilder.Entity("Lab18George.Models.Supply", b =>
                {
                    b.HasOne("Lab18George.Models.Destination", "Destination")
                        .WithMany("Supplies")
                        .HasForeignKey("DestinationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
