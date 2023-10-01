using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tablemodification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "remainBalance",
                table: "Balances",
                newName: "RemainBalance");

            migrationBuilder.InsertData(
                table: "OrderStatuseTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0ec11df3-ffa1-4c75-8671-43049d051d34"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(5967), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(5967) },
                    { new Guid("55f0487b-6c64-4528-a320-0583bdb71035"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(5962), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(5963) },
                    { new Guid("674d56ff-39d0-4163-9bea-b0afdae726d6"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(5969), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(5969) },
                    { new Guid("7d3e960c-b107-4afc-b51c-355ec20c9f02"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(5965), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(5965) },
                    { new Guid("d7e30b26-be5b-4556-8689-7a378c37b690"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(5941), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(5958) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0458d6bd-2bb5-48ef-90e1-a728fd20464e"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6084), "Payment Status-1", new Guid("55f0487b-6c64-4528-a320-0583bdb71035"), "Paid", "401", "Order Paid", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6085) },
                    { new Guid("22b30c96-f4a3-469c-a014-8c1730b78cce"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6046), "Financial Transaction-1", new Guid("55f0487b-6c64-4528-a320-0583bdb71035"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6046) },
                    { new Guid("2de8a435-05e9-4da4-94c2-5b37dc2d2e90"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6054), "Financial Transaction-4", new Guid("55f0487b-6c64-4528-a320-0583bdb71035"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6055) },
                    { new Guid("4d838fe2-e863-4725-8cc7-eaf9c20c90c3"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6042), "Order Progression-5", new Guid("d7e30b26-be5b-4556-8689-7a378c37b690"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6043) },
                    { new Guid("6230f3e0-55ba-483d-8de3-fb815c285f20"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6051), "Financial Transaction-3", new Guid("55f0487b-6c64-4528-a320-0583bdb71035"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6051) },
                    { new Guid("7f0122e5-190e-4d7a-bfd8-e85b3c3b4db8"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6035), "Order Progression-3", new Guid("d7e30b26-be5b-4556-8689-7a378c37b690"), "Shipped", "103", "Order is shipped", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6035) },
                    { new Guid("91969299-b60d-4ce8-839c-744d306a5ea5"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6082), "Authorization and Pay Mod-1", new Guid("7d3e960c-b107-4afc-b51c-355ec20c9f02"), "Verified", "301", "Payment method verified", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6082) },
                    { new Guid("9d04cef3-2af2-4d0f-bcbd-7e32ebf823e2"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6048), "Financial Transaction-2", new Guid("55f0487b-6c64-4528-a320-0583bdb71035"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6049) },
                    { new Guid("a9fbcc63-124f-4ea1-956d-6676db5899ea"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6088), "Payment Status-2", new Guid("55f0487b-6c64-4528-a320-0583bdb71035"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6089) },
                    { new Guid("b1eef7e9-fc13-48f2-9cb4-c524197233d5"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6028), "Order Progression-1", new Guid("d7e30b26-be5b-4556-8689-7a378c37b690"), "Pending", "101", "Order is pending", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6028) },
                    { new Guid("cd2ddfaf-47f9-47d6-9cac-33888c5bcac4"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6039), "Order Progression-4", new Guid("d7e30b26-be5b-4556-8689-7a378c37b690"), "Delivered", "104", "Order is delivered", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6040) },
                    { new Guid("f5f5ec78-14d9-4e7f-9578-df2298944691"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6032), "Order Progression-2", new Guid("d7e30b26-be5b-4556-8689-7a378c37b690"), "Processing", "102", "Order is processing", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6032) },
                    { new Guid("f6710551-d0af-4b54-8f62-88a45d874538"), new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6091), "Payment Status-3", new Guid("55f0487b-6c64-4528-a320-0583bdb71035"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 10, 1, 16, 36, 13, 260, DateTimeKind.Local).AddTicks(6091) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("0ec11df3-ffa1-4c75-8671-43049d051d34"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("674d56ff-39d0-4163-9bea-b0afdae726d6"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("0458d6bd-2bb5-48ef-90e1-a728fd20464e"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("22b30c96-f4a3-469c-a014-8c1730b78cce"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2de8a435-05e9-4da4-94c2-5b37dc2d2e90"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4d838fe2-e863-4725-8cc7-eaf9c20c90c3"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6230f3e0-55ba-483d-8de3-fb815c285f20"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7f0122e5-190e-4d7a-bfd8-e85b3c3b4db8"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("91969299-b60d-4ce8-839c-744d306a5ea5"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("9d04cef3-2af2-4d0f-bcbd-7e32ebf823e2"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a9fbcc63-124f-4ea1-956d-6676db5899ea"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b1eef7e9-fc13-48f2-9cb4-c524197233d5"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("cd2ddfaf-47f9-47d6-9cac-33888c5bcac4"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f5f5ec78-14d9-4e7f-9578-df2298944691"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f6710551-d0af-4b54-8f62-88a45d874538"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("55f0487b-6c64-4528-a320-0583bdb71035"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("7d3e960c-b107-4afc-b51c-355ec20c9f02"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("d7e30b26-be5b-4556-8689-7a378c37b690"));

            migrationBuilder.RenameColumn(
                name: "RemainBalance",
                table: "Balances",
                newName: "remainBalance");

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
    }
}
