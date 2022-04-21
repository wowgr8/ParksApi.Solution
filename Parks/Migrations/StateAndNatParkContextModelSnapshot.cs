﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parks.Models;

namespace Parks.Migrations
{
    [DbContext(typeof(StateAndNatParkContext))]
    partial class StateAndNatParkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Parks.Models.StateAndNatPark", b =>
                {
                    b.Property<int>("StateAndNatParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LocationByState")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("StateAndNatParkId");

                    b.ToTable("StateAndNatParks");
                });
#pragma warning restore 612, 618
        }
    }
}
