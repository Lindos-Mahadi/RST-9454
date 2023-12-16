﻿// <auto-generated />
using System;
using AppDomainLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppDomainLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231216155033_UserModelChangeProperty")]
    partial class UserModelChangeProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppDomainLayer.Models.Account.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<long?>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AppDomainLayer.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "USA",
                            Email = "john.doe@example.com",
                            Gender = "Male",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            Country = "USA",
                            Email = "jane.doe@example.com",
                            Gender = "Female",
                            Name = "Jane Doe"
                        },
                        new
                        {
                            Id = 3,
                            Country = "Canada",
                            Email = "alice.johnson@example.com",
                            Gender = "Female",
                            Name = "Alice Johnson"
                        },
                        new
                        {
                            Id = 4,
                            Country = "UK",
                            Email = "bob.smith@example.com",
                            Gender = "Male",
                            Name = "Bob Smith"
                        },
                        new
                        {
                            Id = 5,
                            Country = "Australia",
                            Email = "eva.williams@example.com",
                            Gender = "Female",
                            Name = "Eva Williams"
                        },
                        new
                        {
                            Id = 6,
                            Country = "USA",
                            Email = "michael.brown@example.com",
                            Gender = "Male",
                            Name = "Michael Brown"
                        },
                        new
                        {
                            Id = 7,
                            Country = "Canada",
                            Email = "sophia.taylor@example.com",
                            Gender = "Female",
                            Name = "Sophia Taylor"
                        },
                        new
                        {
                            Id = 8,
                            Country = "UK",
                            Email = "william.davis@example.com",
                            Gender = "Male",
                            Name = "William Davis"
                        },
                        new
                        {
                            Id = 9,
                            Country = "Australia",
                            Email = "olivia.martinez@example.com",
                            Gender = "Female",
                            Name = "Olivia Martinez"
                        },
                        new
                        {
                            Id = 10,
                            Country = "USA",
                            Email = "james.johnson@example.com",
                            Gender = "Male",
                            Name = "James Johnson"
                        },
                        new
                        {
                            Id = 11,
                            Country = "Canada",
                            Email = "emma.brown@example.com",
                            Gender = "Female",
                            Name = "Emma Brown"
                        },
                        new
                        {
                            Id = 12,
                            Country = "UK",
                            Email = "liam.davis@example.com",
                            Gender = "Male",
                            Name = "Liam Davis"
                        },
                        new
                        {
                            Id = 13,
                            Country = "Australia",
                            Email = "ava.williams@example.com",
                            Gender = "Female",
                            Name = "Ava Williams"
                        },
                        new
                        {
                            Id = 14,
                            Country = "USA",
                            Email = "noah.miller@example.com",
                            Gender = "Male",
                            Name = "Noah Miller"
                        },
                        new
                        {
                            Id = 15,
                            Country = "Canada",
                            Email = "isabella.smith@example.com",
                            Gender = "Female",
                            Name = "Isabella Smith"
                        },
                        new
                        {
                            Id = 16,
                            Country = "UK",
                            Email = "mason.davis@example.com",
                            Gender = "Male",
                            Name = "Mason Davis"
                        },
                        new
                        {
                            Id = 17,
                            Country = "Australia",
                            Email = "sophia.wilson@example.com",
                            Gender = "Female",
                            Name = "Sophia Wilson"
                        },
                        new
                        {
                            Id = 18,
                            Country = "USA",
                            Email = "jackson.johnson@example.com",
                            Gender = "Male",
                            Name = "Jackson Johnson"
                        },
                        new
                        {
                            Id = 19,
                            Country = "Canada",
                            Email = "olivia.taylor@example.com",
                            Gender = "Female",
                            Name = "Olivia Taylor"
                        },
                        new
                        {
                            Id = 20,
                            Country = "UK",
                            Email = "logan.davis@example.com",
                            Gender = "Male",
                            Name = "Logan Davis"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
