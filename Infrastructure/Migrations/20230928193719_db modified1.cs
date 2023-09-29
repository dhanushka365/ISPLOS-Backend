using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbmodified1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("19999238-c2e6-404b-84b9-08bf38e5581e"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("6a2d4724-9af2-4148-92c1-215d2a24ab01"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1d8449a8-9bce-43b1-8e97-e6fb040adf71"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2bb410a4-d570-4315-be29-15a0a5d6ff5b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4d5c99dd-fc7d-4378-999e-cbc9d60926d2"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("5cf3e667-2b83-49a7-b917-df9e0778e6b3"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("69d3b75c-924b-472e-a299-ce7fb5674445"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6e945897-1a70-4a04-9f55-b97c13ff173a"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7a2f4b91-347c-4a8c-bac0-8804014ed883"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("9d7edef0-7f81-4c1a-a1d1-c4cf1ae432bf"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("9f82234d-5df5-4c29-847a-c6c4506a5521"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a02ce708-fe79-480d-b258-4c04794f9c6a"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("dd875b91-7750-42f6-a6de-c8f002d1626a"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ef8fe961-0853-41b6-be96-b20e821631b0"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f7623165-9292-4e6d-9f99-9734b2b9379b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("443f92c6-55bb-45e9-a868-c6b1ce691622"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("7702aa75-a747-419f-991e-fa2138ab35e2"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("9fccd6fb-4a08-4247-89a8-fdd52c5c1885"));

            migrationBuilder.InsertData(
                table: "OrderStatuseTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0f149801-d8c2-40b4-bf61-6d6639101921"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8065), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8066) },
                    { new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8043), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8044) },
                    { new Guid("210ec0e5-3d9f-435c-9767-e6ff68c2d4b7"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8061), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8061) },
                    { new Guid("36fda6f1-45b2-4278-bc6a-a88d7b6c5b46"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8063), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8063) },
                    { new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8028), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8040) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c080bca-5b18-4439-8329-9c75406ec2c4"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8124), "Financial Transaction-1", new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8124) },
                    { new Guid("1dcc80b0-5744-4cb4-a8f0-0b5eb68eea99"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8131), "Financial Transaction-4", new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8132) },
                    { new Guid("50a8f2ee-15eb-4cca-be6f-8f827538fe4e"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8111), "Order Progression-2", new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"), "Processing", "102", "Order is processing", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8111) },
                    { new Guid("5226e18a-3d39-4ac6-9d55-40f83b183f61"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8113), "Order Progression-3", new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"), "Shipped", "103", "Order is shipped", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8114) },
                    { new Guid("a1566bb2-a323-4c2a-aada-542590cddacf"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8137), "Payment Status-1", new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"), "Paid", "401", "Order Paid", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8137) },
                    { new Guid("ad183ff7-01b4-4ba8-bdcf-fb5a3ac4727b"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8116), "Order Progression-4", new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"), "Delivered", "104", "Order is delivered", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8116) },
                    { new Guid("adf79873-b563-4db7-bbc6-357f8d635880"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8129), "Financial Transaction-3", new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8129) },
                    { new Guid("c0ca5199-f7f2-450d-82e4-b62716dca827"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8134), "Authorization and Pay Mod-1", new Guid("210ec0e5-3d9f-435c-9767-e6ff68c2d4b7"), "Verified", "301", "Payment method verified", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8135) },
                    { new Guid("c6e7cc7d-d709-4c89-9fce-81f354999fd9"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8119), "Order Progression-5", new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8119) },
                    { new Guid("d8e228d9-f450-4470-b0d1-bedc8d271a08"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8106), "Order Progression-1", new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"), "Pending", "101", "Order is pending", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8107) },
                    { new Guid("e344ac0c-66c2-49ae-9804-67d605608f04"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8139), "Payment Status-2", new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8139) },
                    { new Guid("e9417aec-3b06-4dcd-85e5-616e3680101a"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8141), "Payment Status-3", new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8142) },
                    { new Guid("f3a5aac9-202a-4182-ab2c-0acad10b4be0"), new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8126), "Financial Transaction-2", new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 9, 29, 1, 7, 19, 459, DateTimeKind.Local).AddTicks(8127) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("0f149801-d8c2-40b4-bf61-6d6639101921"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("36fda6f1-45b2-4278-bc6a-a88d7b6c5b46"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("0c080bca-5b18-4439-8329-9c75406ec2c4"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1dcc80b0-5744-4cb4-a8f0-0b5eb68eea99"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("50a8f2ee-15eb-4cca-be6f-8f827538fe4e"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("5226e18a-3d39-4ac6-9d55-40f83b183f61"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a1566bb2-a323-4c2a-aada-542590cddacf"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ad183ff7-01b4-4ba8-bdcf-fb5a3ac4727b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("adf79873-b563-4db7-bbc6-357f8d635880"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c0ca5199-f7f2-450d-82e4-b62716dca827"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c6e7cc7d-d709-4c89-9fce-81f354999fd9"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d8e228d9-f450-4470-b0d1-bedc8d271a08"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e344ac0c-66c2-49ae-9804-67d605608f04"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e9417aec-3b06-4dcd-85e5-616e3680101a"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f3a5aac9-202a-4182-ab2c-0acad10b4be0"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("13e02cc9-0d8c-48cd-ae77-d64d033c3c60"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("210ec0e5-3d9f-435c-9767-e6ff68c2d4b7"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("68d5655d-9da1-4347-8029-9cd0db0e5631"));

            migrationBuilder.InsertData(
                table: "OrderStatuseTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("19999238-c2e6-404b-84b9-08bf38e5581e"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8584), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8584) },
                    { new Guid("443f92c6-55bb-45e9-a868-c6b1ce691622"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8573), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8574) },
                    { new Guid("6a2d4724-9af2-4148-92c1-215d2a24ab01"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8586), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8586) },
                    { new Guid("7702aa75-a747-419f-991e-fa2138ab35e2"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8558), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8568) },
                    { new Guid("9fccd6fb-4a08-4247-89a8-fdd52c5c1885"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8571), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8572) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1d8449a8-9bce-43b1-8e97-e6fb040adf71"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8638), "Order Progression-2", new Guid("7702aa75-a747-419f-991e-fa2138ab35e2"), "Processing", "102", "Order is processing", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8639) },
                    { new Guid("2bb410a4-d570-4315-be29-15a0a5d6ff5b"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8663), "Payment Status-1", new Guid("9fccd6fb-4a08-4247-89a8-fdd52c5c1885"), "Paid", "401", "Order Paid", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8663) },
                    { new Guid("4d5c99dd-fc7d-4378-999e-cbc9d60926d2"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8661), "Authorization and Pay Mod-1", new Guid("443f92c6-55bb-45e9-a868-c6b1ce691622"), "Verified", "301", "Payment method verified", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8661) },
                    { new Guid("5cf3e667-2b83-49a7-b917-df9e0778e6b3"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8665), "Payment Status-2", new Guid("9fccd6fb-4a08-4247-89a8-fdd52c5c1885"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8665) },
                    { new Guid("69d3b75c-924b-472e-a299-ce7fb5674445"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8658), "Financial Transaction-4", new Guid("9fccd6fb-4a08-4247-89a8-fdd52c5c1885"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8658) },
                    { new Guid("6e945897-1a70-4a04-9f55-b97c13ff173a"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8646), "Order Progression-5", new Guid("7702aa75-a747-419f-991e-fa2138ab35e2"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8646) },
                    { new Guid("7a2f4b91-347c-4a8c-bac0-8804014ed883"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8667), "Payment Status-3", new Guid("9fccd6fb-4a08-4247-89a8-fdd52c5c1885"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8667) },
                    { new Guid("9d7edef0-7f81-4c1a-a1d1-c4cf1ae432bf"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8656), "Financial Transaction-3", new Guid("9fccd6fb-4a08-4247-89a8-fdd52c5c1885"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8656) },
                    { new Guid("9f82234d-5df5-4c29-847a-c6c4506a5521"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8653), "Financial Transaction-2", new Guid("9fccd6fb-4a08-4247-89a8-fdd52c5c1885"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8654) },
                    { new Guid("a02ce708-fe79-480d-b258-4c04794f9c6a"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8649), "Financial Transaction-1", new Guid("9fccd6fb-4a08-4247-89a8-fdd52c5c1885"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8649) },
                    { new Guid("dd875b91-7750-42f6-a6de-c8f002d1626a"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8641), "Order Progression-3", new Guid("7702aa75-a747-419f-991e-fa2138ab35e2"), "Shipped", "103", "Order is shipped", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8642) },
                    { new Guid("ef8fe961-0853-41b6-be96-b20e821631b0"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8634), "Order Progression-1", new Guid("7702aa75-a747-419f-991e-fa2138ab35e2"), "Pending", "101", "Order is pending", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8634) },
                    { new Guid("f7623165-9292-4e6d-9f99-9734b2b9379b"), new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8644), "Order Progression-4", new Guid("7702aa75-a747-419f-991e-fa2138ab35e2"), "Delivered", "104", "Order is delivered", new DateTime(2023, 9, 29, 0, 47, 30, 237, DateTimeKind.Local).AddTicks(8644) }
                });
        }
    }
}
