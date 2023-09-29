using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbmodified12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0cce8285-f52b-4b16-b8f5-7bcc199c8bde"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5650), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5650) },
                    { new Guid("2c25195f-c68e-48cd-9668-3e8882750690"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5630), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5639) },
                    { new Guid("725ee0b2-e5c6-40c3-b300-dab95e7a1540"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5643), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5643) },
                    { new Guid("bc1c06e4-6fdd-439d-a1de-28d610405a10"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5645), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5646) },
                    { new Guid("e6c20e72-f4f7-44f8-9906-87e0e63362f9"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5647), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5648) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("23d4e861-b71b-4de0-96d0-502c31cab6fc"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5753), "Order Progression-4", new Guid("2c25195f-c68e-48cd-9668-3e8882750690"), "Delivered", "104", "Order is delivered", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5754) },
                    { new Guid("249b06a6-d956-435a-aeeb-844364dd9c31"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5767), "Financial Transaction-4", new Guid("725ee0b2-e5c6-40c3-b300-dab95e7a1540"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5768) },
                    { new Guid("28149072-36ef-435b-9a96-80d448777bac"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5750), "Order Progression-3", new Guid("2c25195f-c68e-48cd-9668-3e8882750690"), "Shipped", "103", "Order is shipped", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5751) },
                    { new Guid("35419ce8-1571-428a-aff6-04951dbc5dc5"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5739), "Order Progression-2", new Guid("2c25195f-c68e-48cd-9668-3e8882750690"), "Processing", "102", "Order is processing", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5740) },
                    { new Guid("3b885553-22ee-416f-b8e1-178fee465ac6"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5775), "Payment Status-1", new Guid("725ee0b2-e5c6-40c3-b300-dab95e7a1540"), "Paid", "401", "Order Paid", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5775) },
                    { new Guid("4463badf-c302-467e-b169-d0955e766c40"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5779), "Payment Status-3", new Guid("725ee0b2-e5c6-40c3-b300-dab95e7a1540"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5780) },
                    { new Guid("6ff177e3-8aea-4d80-9ab3-ee88d37794ed"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5756), "Order Progression-5", new Guid("2c25195f-c68e-48cd-9668-3e8882750690"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5756) },
                    { new Guid("7d867b79-437b-40bb-945c-5e6799890e91"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5760), "Financial Transaction-1", new Guid("725ee0b2-e5c6-40c3-b300-dab95e7a1540"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5760) },
                    { new Guid("bff26263-e090-4e69-92e8-d67fff5c4efc"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5771), "Authorization and Pay Mod-1", new Guid("bc1c06e4-6fdd-439d-a1de-28d610405a10"), "Verified", "301", "Payment method verified", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5771) },
                    { new Guid("c4e37d48-7c67-46b4-b7c8-ce3428bb3fae"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5735), "Order Progression-1", new Guid("2c25195f-c68e-48cd-9668-3e8882750690"), "Pending", "101", "Order is pending", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5736) },
                    { new Guid("c69edb1c-e687-4000-b809-30af669c280b"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5762), "Financial Transaction-2", new Guid("725ee0b2-e5c6-40c3-b300-dab95e7a1540"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5763) },
                    { new Guid("de3ccbfb-a136-4898-a1f7-5ec605107e1c"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5765), "Financial Transaction-3", new Guid("725ee0b2-e5c6-40c3-b300-dab95e7a1540"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5765) },
                    { new Guid("e3f873ad-cfb7-4370-abd4-7adf0e086bad"), new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5777), "Payment Status-2", new Guid("725ee0b2-e5c6-40c3-b300-dab95e7a1540"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 9, 29, 1, 17, 26, 81, DateTimeKind.Local).AddTicks(5777) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("0cce8285-f52b-4b16-b8f5-7bcc199c8bde"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("e6c20e72-f4f7-44f8-9906-87e0e63362f9"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("23d4e861-b71b-4de0-96d0-502c31cab6fc"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("249b06a6-d956-435a-aeeb-844364dd9c31"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("28149072-36ef-435b-9a96-80d448777bac"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("35419ce8-1571-428a-aff6-04951dbc5dc5"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("3b885553-22ee-416f-b8e1-178fee465ac6"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4463badf-c302-467e-b169-d0955e766c40"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6ff177e3-8aea-4d80-9ab3-ee88d37794ed"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7d867b79-437b-40bb-945c-5e6799890e91"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("bff26263-e090-4e69-92e8-d67fff5c4efc"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c4e37d48-7c67-46b4-b7c8-ce3428bb3fae"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c69edb1c-e687-4000-b809-30af669c280b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("de3ccbfb-a136-4898-a1f7-5ec605107e1c"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e3f873ad-cfb7-4370-abd4-7adf0e086bad"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("2c25195f-c68e-48cd-9668-3e8882750690"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("725ee0b2-e5c6-40c3-b300-dab95e7a1540"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc1c06e4-6fdd-439d-a1de-28d610405a10"));

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
    }
}
