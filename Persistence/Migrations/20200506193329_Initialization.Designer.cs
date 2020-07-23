﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200506193329_Initialization")]
    partial class Initialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Domain.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "max1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "max2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "max3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "max4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "max5"
                        });
                });

            modelBuilder.Entity("Domain.ProductionStocks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 1,
                            Name = "steel1"
                        },
                        new
                        {
                            Id = 2,
                            Count = 4,
                            Name = "steel2"
                        },
                        new
                        {
                            Id = 3,
                            Count = 3,
                            Name = "steel3"
                        },
                        new
                        {
                            Id = 4,
                            Count = 6,
                            Name = "steel4"
                        },
                        new
                        {
                            Id = 5,
                            Count = 5,
                            Name = "steel5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
