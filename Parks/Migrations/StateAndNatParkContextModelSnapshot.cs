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

                    b.HasData(
                        new
                        {
                            StateAndNatParkId = 1,
                            LocationByState = "California",
                            Name = "Yosimite",
                            Type = "National Park"
                        },
                        new
                        {
                            StateAndNatParkId = 2,
                            LocationByState = "Wyoming",
                            Name = "Yellowstone",
                            Type = "National Park"
                        },
                        new
                        {
                            StateAndNatParkId = 3,
                            LocationByState = "Utah",
                            Name = "Arches",
                            Type = "National Park"
                        },
                        new
                        {
                            StateAndNatParkId = 4,
                            LocationByState = "Texas",
                            Name = "Palo Duro Canyon",
                            Type = "State Park"
                        },
                        new
                        {
                            StateAndNatParkId = 5,
                            LocationByState = "North Carolina",
                            Name = "Chimney Rock",
                            Type = "State Park"
                        },
                        new
                        {
                            StateAndNatParkId = 6,
                            LocationByState = "Michigan",
                            Name = "Porcupine Mountains Wilderness",
                            Type = "State Park"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
