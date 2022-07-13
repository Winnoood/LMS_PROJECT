﻿// <auto-generated />
using System;
using LMS_PROJECT.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LMS_PROJECT.Migrations
{
    [DbContext(typeof(DataAccessLayer_LMS))]
    partial class DataAccessLayer_LMSModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LMS_PROJECT.Models.EmployeeDBModel", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmpDept")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmpDoj")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmpMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EmpMobile")
                        .HasColumnType("bigint");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpPswd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpId");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}