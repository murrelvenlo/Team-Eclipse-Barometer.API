﻿// <auto-generated />
using System;
using Barometer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Barometer.DAL.Migrations
{
    [DbContext(typeof(BarometerContext))]
    [Migration("20240112125932_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Barometer.Data.Model.BarometerModel", b =>
                {
                    b.Property<int>("BarometerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("barometer_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BarometerId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int")
                        .HasColumnName("employee_count");

                    b.HasKey("BarometerId");

                    b.ToTable("Barometer");
                });
#pragma warning restore 612, 618
        }
    }
}
