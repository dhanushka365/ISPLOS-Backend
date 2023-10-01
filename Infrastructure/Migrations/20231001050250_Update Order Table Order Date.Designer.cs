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
    [Migration("20231001050250_Update Order Table Order Date")]
    partial class UpdateOrderTableOrderDate
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

            modelBuilder.Entity("Core.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");
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

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("OrderDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

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
                            Id = new Guid("8ed01303-8171-476e-a739-b5c647ee9433"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3331),
                            Name = "Order Progression-1",
                            OrderStatusTypeId = new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"),
                            Status = "Pending",
                            StatusCode = "101",
                            StatusMessage = "Order is pending",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3331)
                        },
                        new
                        {
                            Id = new Guid("abce4ca2-0527-4c67-82aa-c7f7cc6c94b2"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3335),
                            Name = "Order Progression-2",
                            OrderStatusTypeId = new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"),
                            Status = "Processing",
                            StatusCode = "102",
                            StatusMessage = "Order is processing",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3335)
                        },
                        new
                        {
                            Id = new Guid("a23130a2-1b70-4f64-b2b8-322abb3d4c50"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3338),
                            Name = "Order Progression-3",
                            OrderStatusTypeId = new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"),
                            Status = "Shipped",
                            StatusCode = "103",
                            StatusMessage = "Order is shipped",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3338)
                        },
                        new
                        {
                            Id = new Guid("ff16c9a3-c0a4-4f2c-9039-e253280cc24a"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3341),
                            Name = "Order Progression-4",
                            OrderStatusTypeId = new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"),
                            Status = "Delivered",
                            StatusCode = "104",
                            StatusMessage = "Order is delivered",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3341)
                        },
                        new
                        {
                            Id = new Guid("4f458ae8-4d78-4bfb-84bf-5eb122f0d5cb"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3344),
                            Name = "Order Progression-5",
                            OrderStatusTypeId = new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"),
                            Status = "Cancelled",
                            StatusCode = "105",
                            StatusMessage = "Order is cancelled",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3344)
                        },
                        new
                        {
                            Id = new Guid("6d49a755-2849-4bd0-bf04-602c4659f8b0"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3348),
                            Name = "Financial Transaction-1",
                            OrderStatusTypeId = new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"),
                            Status = "Pending",
                            StatusCode = "201",
                            StatusMessage = "Financial transaction is pending",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3348)
                        },
                        new
                        {
                            Id = new Guid("73cad369-6a5d-4a18-a1b1-f371de0c09f9"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3353),
                            Name = "Financial Transaction-2",
                            OrderStatusTypeId = new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"),
                            Status = "Processing",
                            StatusCode = "202",
                            StatusMessage = "Financial transaction is processing",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3354)
                        },
                        new
                        {
                            Id = new Guid("75546efc-7810-4273-be72-b89f1aae6e43"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3356),
                            Name = "Financial Transaction-3",
                            OrderStatusTypeId = new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"),
                            Status = "Completed",
                            StatusCode = "203",
                            StatusMessage = "Financial transaction is completed",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3357)
                        },
                        new
                        {
                            Id = new Guid("53982c23-f8cf-47fe-91a3-637670b9a2e2"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3359),
                            Name = "Financial Transaction-4",
                            OrderStatusTypeId = new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"),
                            Status = "Cancelled",
                            StatusCode = "204",
                            StatusMessage = "Financial transaction is cancelled",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3360)
                        },
                        new
                        {
                            Id = new Guid("e898ee31-b650-4b1c-8bbd-7cd78681fee8"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3363),
                            Name = "Authorization and Pay Mod-1",
                            OrderStatusTypeId = new Guid("fdd7f0e4-5c31-4c23-b1cf-b4637f91e5a3"),
                            Status = "Verified",
                            StatusCode = "301",
                            StatusMessage = "Payment method verified",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3363)
                        },
                        new
                        {
                            Id = new Guid("a136f3a9-6edf-4519-948d-d3cf23b359f5"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3366),
                            Name = "Payment Status-1",
                            OrderStatusTypeId = new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"),
                            Status = "Paid",
                            StatusCode = "401",
                            StatusMessage = "Order Paid",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3366)
                        },
                        new
                        {
                            Id = new Guid("2009e393-32e4-4fb3-8f06-cafa4e4d10b4"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3369),
                            Name = "Payment Status-2",
                            OrderStatusTypeId = new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"),
                            Status = "partially Paid",
                            StatusCode = "402",
                            StatusMessage = "Order Partially Paid",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3369)
                        },
                        new
                        {
                            Id = new Guid("5f905eb4-bff1-4c9d-96cc-602a2cd3d5b3"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3371),
                            Name = "Payment Status-3",
                            OrderStatusTypeId = new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"),
                            Status = "unPaid",
                            StatusCode = "403",
                            StatusMessage = "Order is UnPaid",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3372)
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
                            Id = new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3138),
                            Description = "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.",
                            Name = "Order Progression",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3156)
                        },
                        new
                        {
                            Id = new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3160),
                            Description = "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.",
                            Name = "Financial Transaction",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3160)
                        },
                        new
                        {
                            Id = new Guid("fdd7f0e4-5c31-4c23-b1cf-b4637f91e5a3"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3162),
                            Description = "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch",
                            Name = "Authorization and Pay Mod",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3163)
                        },
                        new
                        {
                            Id = new Guid("99ed9730-99eb-4327-ba78-3754f51604b9"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3215),
                            Description = "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.",
                            Name = "Payment Status",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3216)
                        },
                        new
                        {
                            Id = new Guid("348f17fb-6082-4ec4-af0a-a9d4f765727b"),
                            CreatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3218),
                            Description = "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.",
                            Name = "Review and Dispute",
                            UpdatedAt = new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3219)
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

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

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
                    b.HasOne("Core.Entities.Payment", null)
                        .WithMany("Orders")
                        .HasForeignKey("PaymentId");

                    b.HasOne("Core.Entities.Identity.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
