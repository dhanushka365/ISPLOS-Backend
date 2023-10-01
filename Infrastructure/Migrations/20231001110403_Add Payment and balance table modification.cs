using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentandbalancetablemodification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_PaymentId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentStatus_PaymentStatusId",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropIndex(
                name: "IX_Payments_PaymentStatusId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PaymentId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("348f17fb-6082-4ec4-af0a-a9d4f765727b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("99ed9730-99eb-4327-ba78-3754f51604b9"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2009e393-32e4-4fb3-8f06-cafa4e4d10b4"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4f458ae8-4d78-4bfb-84bf-5eb122f0d5cb"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("53982c23-f8cf-47fe-91a3-637670b9a2e2"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("5f905eb4-bff1-4c9d-96cc-602a2cd3d5b3"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6d49a755-2849-4bd0-bf04-602c4659f8b0"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("73cad369-6a5d-4a18-a1b1-f371de0c09f9"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("75546efc-7810-4273-be72-b89f1aae6e43"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8ed01303-8171-476e-a739-b5c647ee9433"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a136f3a9-6edf-4519-948d-d3cf23b359f5"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a23130a2-1b70-4f64-b2b8-322abb3d4c50"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("abce4ca2-0527-4c67-82aa-c7f7cc6c94b2"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e898ee31-b650-4b1c-8bbd-7cd78681fee8"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ff16c9a3-c0a4-4f2c-9039-e253280cc24a"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("fdd7f0e4-5c31-4c23-b1cf-b4637f91e5a3"));

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentMethodDescription",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentMethodType",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentStatusId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "Balances");

            migrationBuilder.DropColumn(
                name: "UpdatedByUser",
                table: "Balances");

            migrationBuilder.InsertData(
                table: "OrderStatuseTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("05310e10-8742-4975-83e7-d85607871fb1"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(3936), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(3951) },
                    { new Guid("1ffea1ba-230b-4b53-8cf0-8eda37d8c642"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(3958), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(3958) },
                    { new Guid("9096c0b1-e08b-4fba-aa6e-fc27cabd414d"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(3973), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(3974) },
                    { new Guid("a154a6dc-7802-4e15-a265-7fe45c8ca679"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(3955), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(3956) },
                    { new Guid("a74b2ca2-59ee-4d0a-986a-b75c3252a8d1"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(3960), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(3960) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("19df71c3-460b-429e-9a89-a1fde8b01b52"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4083), "Financial Transaction-2", new Guid("a154a6dc-7802-4e15-a265-7fe45c8ca679"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4083) },
                    { new Guid("23bbc471-55fb-4003-921d-5a591c3cd55c"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4076), "Order Progression-5", new Guid("05310e10-8742-4975-83e7-d85607871fb1"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4077) },
                    { new Guid("2b853889-81ca-4093-bdef-36a638958aac"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4073), "Order Progression-4", new Guid("05310e10-8742-4975-83e7-d85607871fb1"), "Delivered", "104", "Order is delivered", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4074) },
                    { new Guid("2d06f1fa-2e2b-4fde-952e-4c021c561f4f"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4068), "Order Progression-2", new Guid("05310e10-8742-4975-83e7-d85607871fb1"), "Processing", "102", "Order is processing", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4068) },
                    { new Guid("2fc99977-7531-4091-8bd6-ca3884a909e2"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4091), "Financial Transaction-4", new Guid("a154a6dc-7802-4e15-a265-7fe45c8ca679"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4091) },
                    { new Guid("36587c38-bdaf-4876-a7e6-464e9bd9e3eb"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4071), "Order Progression-3", new Guid("05310e10-8742-4975-83e7-d85607871fb1"), "Shipped", "103", "Order is shipped", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4071) },
                    { new Guid("42e37bcb-e9a8-4979-9f7f-9f1e89921eb5"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4088), "Financial Transaction-3", new Guid("a154a6dc-7802-4e15-a265-7fe45c8ca679"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4089) },
                    { new Guid("8b73b1c4-5df9-4866-b29c-5762fd947d4c"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4063), "Order Progression-1", new Guid("05310e10-8742-4975-83e7-d85607871fb1"), "Pending", "101", "Order is pending", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4064) },
                    { new Guid("a054daef-7310-4f0c-bcde-c381f7ab86d4"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4094), "Authorization and Pay Mod-1", new Guid("1ffea1ba-230b-4b53-8cf0-8eda37d8c642"), "Verified", "301", "Payment method verified", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4095) },
                    { new Guid("adc4c5bf-1a7f-4ba3-b24e-8ab4cf9c8075"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4100), "Payment Status-2", new Guid("a154a6dc-7802-4e15-a265-7fe45c8ca679"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4100) },
                    { new Guid("d1c48752-7cce-42b1-8c74-7df91c74833c"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4097), "Payment Status-1", new Guid("a154a6dc-7802-4e15-a265-7fe45c8ca679"), "Paid", "401", "Order Paid", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4098) },
                    { new Guid("dfc5b07a-7680-4617-bf98-ed61731ea491"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4102), "Payment Status-3", new Guid("a154a6dc-7802-4e15-a265-7fe45c8ca679"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4103) },
                    { new Guid("e717f4b6-5a01-4a6b-9e2a-1250a0c21645"), new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4080), "Financial Transaction-1", new Guid("a154a6dc-7802-4e15-a265-7fe45c8ca679"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 10, 1, 16, 34, 3, 99, DateTimeKind.Local).AddTicks(4080) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("9096c0b1-e08b-4fba-aa6e-fc27cabd414d"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("a74b2ca2-59ee-4d0a-986a-b75c3252a8d1"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("19df71c3-460b-429e-9a89-a1fde8b01b52"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("23bbc471-55fb-4003-921d-5a591c3cd55c"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2b853889-81ca-4093-bdef-36a638958aac"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2d06f1fa-2e2b-4fde-952e-4c021c561f4f"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2fc99977-7531-4091-8bd6-ca3884a909e2"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("36587c38-bdaf-4876-a7e6-464e9bd9e3eb"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("42e37bcb-e9a8-4979-9f7f-9f1e89921eb5"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8b73b1c4-5df9-4866-b29c-5762fd947d4c"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a054daef-7310-4f0c-bcde-c381f7ab86d4"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("adc4c5bf-1a7f-4ba3-b24e-8ab4cf9c8075"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d1c48752-7cce-42b1-8c74-7df91c74833c"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("dfc5b07a-7680-4617-bf98-ed61731ea491"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e717f4b6-5a01-4a6b-9e2a-1250a0c21645"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("05310e10-8742-4975-83e7-d85607871fb1"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("1ffea1ba-230b-4b53-8cf0-8eda37d8c642"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("a154a6dc-7802-4e15-a265-7fe45c8ca679"));

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethodDescription",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethodType",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentStatusId",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "Balances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUser",
                table: "Balances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OrderStatuseTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3160), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3160) },
                    { new Guid("348f17fb-6082-4ec4-af0a-a9d4f765727b"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3218), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3219) },
                    { new Guid("99ed9730-99eb-4327-ba78-3754f51604b9"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3215), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3216) },
                    { new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3138), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3156) },
                    { new Guid("fdd7f0e4-5c31-4c23-b1cf-b4637f91e5a3"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3162), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3163) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2009e393-32e4-4fb3-8f06-cafa4e4d10b4"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3369), "Payment Status-2", new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3369) },
                    { new Guid("4f458ae8-4d78-4bfb-84bf-5eb122f0d5cb"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3344), "Order Progression-5", new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3344) },
                    { new Guid("53982c23-f8cf-47fe-91a3-637670b9a2e2"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3359), "Financial Transaction-4", new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3360) },
                    { new Guid("5f905eb4-bff1-4c9d-96cc-602a2cd3d5b3"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3371), "Payment Status-3", new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3372) },
                    { new Guid("6d49a755-2849-4bd0-bf04-602c4659f8b0"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3348), "Financial Transaction-1", new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3348) },
                    { new Guid("73cad369-6a5d-4a18-a1b1-f371de0c09f9"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3353), "Financial Transaction-2", new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3354) },
                    { new Guid("75546efc-7810-4273-be72-b89f1aae6e43"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3356), "Financial Transaction-3", new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3357) },
                    { new Guid("8ed01303-8171-476e-a739-b5c647ee9433"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3331), "Order Progression-1", new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"), "Pending", "101", "Order is pending", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3331) },
                    { new Guid("a136f3a9-6edf-4519-948d-d3cf23b359f5"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3366), "Payment Status-1", new Guid("290bffa7-fb4a-4909-a61e-0f327e2f1c28"), "Paid", "401", "Order Paid", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3366) },
                    { new Guid("a23130a2-1b70-4f64-b2b8-322abb3d4c50"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3338), "Order Progression-3", new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"), "Shipped", "103", "Order is shipped", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3338) },
                    { new Guid("abce4ca2-0527-4c67-82aa-c7f7cc6c94b2"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3335), "Order Progression-2", new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"), "Processing", "102", "Order is processing", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3335) },
                    { new Guid("e898ee31-b650-4b1c-8bbd-7cd78681fee8"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3363), "Authorization and Pay Mod-1", new Guid("fdd7f0e4-5c31-4c23-b1cf-b4637f91e5a3"), "Verified", "301", "Payment method verified", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3363) },
                    { new Guid("ff16c9a3-c0a4-4f2c-9039-e253280cc24a"), new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3341), "Order Progression-4", new Guid("cf685553-2f64-4d09-90ad-01b3afb9f026"), "Delivered", "104", "Order is delivered", new DateTime(2023, 10, 1, 10, 32, 50, 673, DateTimeKind.Local).AddTicks(3341) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentStatusId",
                table: "Payments",
                column: "PaymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentId",
                table: "Orders",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_PaymentId",
                table: "Orders",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentStatus_PaymentStatusId",
                table: "Payments",
                column: "PaymentStatusId",
                principalTable: "PaymentStatus",
                principalColumn: "Id");
        }
    }
}
