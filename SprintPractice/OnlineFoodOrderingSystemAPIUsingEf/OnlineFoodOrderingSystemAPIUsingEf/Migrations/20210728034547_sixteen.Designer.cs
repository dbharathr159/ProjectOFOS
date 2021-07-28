﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineFoodOrderingSystemAPIUsingEf.Entities;

namespace OnlineFoodOrderingSystemAPIUsingEf.Migrations
{
    [DbContext(typeof(FoodOrderingContext))]
    [Migration("20210728034547_sixteen")]
    partial class sixteen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Admin", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<long>("Mobile")
                        .HasColumnType("Bigint");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.HasKey("UserId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeliveryAddress")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Email")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<long>("Mobile")
                        .HasColumnType("Bigint");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FoodCategory")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("MenuName")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("Decimal");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("NoOfServing")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("Decimal");

                    b.HasKey("OrderItemId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("Date");

                    b.Property<string>("OrderStatus")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PaidBy")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("PaymentStatus")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("Decimal");

                    b.HasKey("PaymentId");

                    b.ToTable("Payment");
                });
#pragma warning restore 612, 618
        }
    }
}
