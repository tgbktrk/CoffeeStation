﻿// <auto-generated />
using System;
using CoffeeStation.Discount.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoffeeStation.Discount.Migrations
{
    [DbContext(typeof(DapperContext))]
    [Migration("20241208135601_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoffeeStation.Discount.Entities.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponId"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");
                });
#pragma warning restore 612, 618
        }
    }
}
