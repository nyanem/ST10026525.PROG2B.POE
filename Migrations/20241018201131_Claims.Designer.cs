﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ST10026525.PROG62112.POE.part1.Data;

#nullable disable

namespace ST10026525.PROG62112.POE.part1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241018201131_Claims")]
    partial class Claims
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ST10026525.PROG62112.POE.part1.Models.Claims", b =>
                {
                    b.Property<int>("ClaimsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClaimsId"));

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("claimDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("hourlyRate")
                        .HasColumnType("int");

                    b.Property<int>("hoursWorked")
                        .HasColumnType("int");

                    b.Property<string>("supportingDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClaimsId");

                    b.ToTable("claims");
                });

            modelBuilder.Entity("ST10026525.PROG62112.POE.part1.Models.Lecturer", b =>
                {
                    b.Property<int>("LecturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LecturerId"));

                    b.Property<string>("LecturerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("claimDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("hours")
                        .HasColumnType("int");

                    b.Property<int>("ratePH")
                        .HasColumnType("int");

                    b.HasKey("LecturerId");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("ST10026525.PROG62112.POE.part1.Models.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerId"));

                    b.Property<string>("ManagerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManagerName")
                        .HasColumnType("int");

                    b.Property<string>("ManagerPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManagerId");

                    b.ToTable("Managers");
                });
#pragma warning restore 612, 618
        }
    }
}
