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
    [Migration("20210725133305_seven")]
    partial class seven
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
                    b.Property<int>("Userid")
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

                    b.HasKey("Userid");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Customer", b =>
                {
                    b.Property<int>("Customerid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.HasKey("Customerid");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Menu", b =>
                {
                    b.Property<int>("Menuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FoodCategory")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("MenuName")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Menuid");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Order", b =>
                {
                    b.Property<int>("Orderid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Customerid")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("Date");

                    b.Property<string>("OrderStatus")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("Decimal");

                    b.HasKey("Orderid");

                    b.HasIndex("Customerid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderItemid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Amount")
                        .HasColumnType("Decimal");

                    b.Property<int>("Menuid")
                        .HasColumnType("int");

                    b.Property<int?>("NoOfServing")
                        .HasColumnType("int");

                    b.Property<int>("Orderid")
                        .HasColumnType("int");

                    b.Property<decimal?>("Total")
                        .HasColumnType("Decimal");

                    b.HasKey("OrderItemid");

                    b.HasIndex("Menuid");

                    b.HasIndex("Orderid");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Payment", b =>
                {
                    b.Property<int>("Paymentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Orderid")
                        .HasColumnType("int");

                    b.Property<string>("PaidBy")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("Varchar(20)");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("Decimal");

                    b.HasKey("Paymentid");

                    b.HasIndex("Orderid");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Order", b =>
                {
                    b.HasOne("OnlineFoodOrderingSystemAPIUsingEf.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.OrderItem", b =>
                {
                    b.HasOne("OnlineFoodOrderingSystemAPIUsingEf.Entities.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("Menuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineFoodOrderingSystemAPIUsingEf.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("Orderid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("OnlineFoodOrderingSystemAPIUsingEf.Entities.Payment", b =>
                {
                    b.HasOne("OnlineFoodOrderingSystemAPIUsingEf.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("Orderid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
