﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20230928193719_db modified1")]
    partial class dbmodified1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Balance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedByUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("remainBalance")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Balances");
                });

            modelBuilder.Entity("Core.Entities.Identity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Core.Entities.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.DeliveryMethod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeliveryTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("deliveryPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("DeliveryMethods");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DeliveryMethodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrderStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryMethodId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.OrderProduct", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.OrderStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrderStatusTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusTypeId");

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d8e228d9-f450-4470-b0d1-bedc8d271a08"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8106),
                            Name = "Order Progression-1",
                            OrderStatusTypeId = new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"),
                            Status = "Pending",
                            StatusCode = "101",
                            StatusMessage = "Order is pending",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8107)
                        },
                        new
                        {
                            Id = new Guid("50a8f2ee-15eb-4cca-be6f-8f827538fe4e"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8111),
                            Name = "Order Progression-2",
                            OrderStatusTypeId = new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"),
                            Status = "Processing",
                            StatusCode = "102",
                            StatusMessage = "Order is processing",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8111)
                        },
                        new
                        {
                            Id = new Guid("5226e18a-3d39-4ac6-9d55-40f83b183f61"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8113),
                            Name = "Order Progression-3",
                            OrderStatusTypeId = new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"),
                            Status = "Shipped",
                            StatusCode = "103",
                            StatusMessage = "Order is shipped",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8114)
                        },
                        new
                        {
                            Id = new Guid("ad183ff7-01b4-4ba8-bdcf-fb5a3ac4727b"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8116),
                            Name = "Order Progression-4",
                            OrderStatusTypeId = new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"),
                            Status = "Delivered",
                            StatusCode = "104",
                            StatusMessage = "Order is delivered",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8116)
                        },
                        new
                        {
                            Id = new Guid("c6e7cc7d-d709-4c89-9fce-81f354999fd9"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8119),
                            Name = "Order Progression-5",
                            OrderStatusTypeId = new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"),
                            Status = "Cancelled",
                            StatusCode = "105",
                            StatusMessage = "Order is cancelled",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8119)
                        },
                        new
                        {
                            Id = new Guid("0c080bca-5b18-4439-8329-9c75406ec2c4"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8124),
                            Name = "Financial Transaction-1",
                            OrderStatusTypeId = new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"),
                            Status = "Pending",
                            StatusCode = "201",
                            StatusMessage = "Financial transaction is pending",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8124)
                        },
                        new
                        {
                            Id = new Guid("f3a5aac9-202a-4182-ab2c-0acad10b4be0"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8126),
                            Name = "Financial Transaction-2",
                            OrderStatusTypeId = new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"),
                            Status = "Processing",
                            StatusCode = "202",
                            StatusMessage = "Financial transaction is processing",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8127)
                        },
                        new
                        {
                            Id = new Guid("adf79873-b563-4db7-bbc6-357f8d635880"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8129),
                            Name = "Financial Transaction-3",
                            OrderStatusTypeId = new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"),
                            Status = "Completed",
                            StatusCode = "203",
                            StatusMessage = "Financial transaction is completed",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8129)
                        },
                        new
                        {
                            Id = new Guid("1dcc80b0-5744-4cb4-a8f0-0b5eb68eea99"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8131),
                            Name = "Financial Transaction-4",
                            OrderStatusTypeId = new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"),
                            Status = "Cancelled",
                            StatusCode = "204",
                            StatusMessage = "Financial transaction is cancelled",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8132)
                        },
                        new
                        {
                            Id = new Guid("c0ca5199-f7f2-450d-82e4-b62716dca827"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8134),
                            Name = "Authorization and Pay Mod-1",
                            OrderStatusTypeId = new Guid("210ec0e5-3d9f-435c-9767-e6ff68c2d4b7"),
                            Status = "Verified",
                            StatusCode = "301",
                            StatusMessage = "Payment method verified",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8135)
                        },
                        new
                        {
                            Id = new Guid("a1566bb2-a323-4c2a-aada-542590cddacf"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8137),
                            Name = "Payment Status-1",
                            OrderStatusTypeId = new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"),
                            Status = "Paid",
                            StatusCode = "401",
                            StatusMessage = "Order Paid",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8137)
                        },
                        new
                        {
                            Id = new Guid("e344ac0c-66c2-49ae-9804-67d605608f04"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8139),
                            Name = "Payment Status-2",
                            OrderStatusTypeId = new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"),
                            Status = "partially Paid",
                            StatusCode = "402",
                            StatusMessage = "Order Partially Paid",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8139)
                        },
                        new
                        {
                            Id = new Guid("e9417aec-3b06-4dcd-85e5-616e3680101a"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8141),
                            Name = "Payment Status-3",
                            OrderStatusTypeId = new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"),
                            Status = "unPaid",
                            StatusCode = "403",
                            StatusMessage = "Order is UnPaid",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8142)
                        });
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.OrderStatusType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuseTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8028),
                            Description = "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.",
                            Name = "Order Progression",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8040)
                        },
                        new
                        {
                            Id = new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8043),
                            Description = "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.",
                            Name = "Financial Transaction",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8044)
                        },
                        new
                        {
                            Id = new Guid("210ec0e5-3d9f-435c-9767-e6ff68c2d4b7"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8061),
                            Description = "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch",
                            Name = "Authorization and Pay Mod",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8061)
                        },
                        new
                        {
                            Id = new Guid("36fda6f1-45b2-4278-bc6a-a88d7b6c5b46"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8063),
                            Description = "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.",
                            Name = "Payment Status",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8063)
                        },
                        new
                        {
                            Id = new Guid("0f149801-d8c2-40b4-bf61-6d6639101921"),
                            CreatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8065),
                            Description = "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.",
                            Name = "Review and Dispute",
                            UpdatedAt = new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8066)
                        });
                });

            modelBuilder.Entity("Core.Entities.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethodDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PaymentStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PaymentStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Core.Entities.PaymentStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PaymentStatus");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("nvarchar(180)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductBrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Core.Entities.ProductBrand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductBrands");
                });

            modelBuilder.Entity("Core.Entities.ProductType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("Core.Entities.Balance", b =>
                {
                    b.HasOne("Core.Entities.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.Identity.User", b =>
                {
                    b.HasOne("Core.Entities.Identity.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.Order", b =>
                {
                    b.HasOne("Core.Entities.OrderAggregate.DeliveryMethod", "DeliveryMethod")
                        .WithMany()
                        .HasForeignKey("DeliveryMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.OrderAggregate.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Payment", null)
                        .WithMany("Orders")
                        .HasForeignKey("PaymentId");

                    b.HasOne("Core.Entities.Identity.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryMethod");

                    b.Navigation("OrderStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.OrderProduct", b =>
                {
                    b.HasOne("Core.Entities.OrderAggregate.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.OrderStatus", b =>
                {
                    b.HasOne("Core.Entities.OrderAggregate.OrderStatusType", "OrderStatusType")
                        .WithMany("OrderStatuses")
                        .HasForeignKey("OrderStatusTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderStatusType");
                });

            modelBuilder.Entity("Core.Entities.Payment", b =>
                {
                    b.HasOne("Core.Entities.PaymentStatus", "PaymentStatus")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentStatusId");

                    b.HasOne("Core.Entities.Identity.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.HasOne("Core.Entities.ProductBrand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("ProductBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Core.Entities.Identity.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Core.Entities.OrderAggregate.OrderStatusType", b =>
                {
                    b.Navigation("OrderStatuses");
                });

            modelBuilder.Entity("Core.Entities.Payment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Core.Entities.PaymentStatus", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Navigation("OrderProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
