using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateBalanceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "RemainBalance",
                table: "Balances",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "OrderStatuseTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06a0f7da-40cf-43d4-887d-4124edd78ca7"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6066), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6066) },
                    { new Guid("3fe4c83e-ef59-45ff-b000-d64d8bcb110b"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6068), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6069) },
                    { new Guid("7eb51278-826b-44b6-88a1-934b0d7e926d"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6073), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6074) },
                    { new Guid("8e9fa68a-f50b-4f86-8b3b-ad0ebf806637"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6071), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6071) },
                    { new Guid("9f2e9a06-cdfb-4341-a976-c0b7af13e0e2"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6048), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6061) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c3681c5-143f-42c2-9ff7-e63e3370f26a"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6169), "Financial Transaction-3", new Guid("06a0f7da-40cf-43d4-887d-4124edd78ca7"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6169) },
                    { new Guid("0d1c3a3c-6db1-4294-9368-d860dbd7936b"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6163), "Financial Transaction-1", new Guid("06a0f7da-40cf-43d4-887d-4124edd78ca7"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6163) },
                    { new Guid("0f198637-f438-4371-873b-911289a8b01d"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6178), "Payment Status-1", new Guid("06a0f7da-40cf-43d4-887d-4124edd78ca7"), "Paid", "401", "Order Paid", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6179) },
                    { new Guid("188d2da9-7fc1-4684-8b49-5c2ca61a44e4"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6142), "Order Progression-1", new Guid("9f2e9a06-cdfb-4341-a976-c0b7af13e0e2"), "Pending", "101", "Order is pending", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6143) },
                    { new Guid("2aa21a05-fcc3-4561-b12f-50cc28276ad1"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6155), "Order Progression-4", new Guid("9f2e9a06-cdfb-4341-a976-c0b7af13e0e2"), "Delivered", "104", "Order is delivered", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6156) },
                    { new Guid("331fea88-3658-4e60-bbe4-2edd25f6726b"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6146), "Order Progression-2", new Guid("9f2e9a06-cdfb-4341-a976-c0b7af13e0e2"), "Processing", "102", "Order is processing", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6147) },
                    { new Guid("3b76aa61-7f89-4364-9e9d-495c61610630"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6159), "Order Progression-5", new Guid("9f2e9a06-cdfb-4341-a976-c0b7af13e0e2"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6159) },
                    { new Guid("68e72767-0bf3-4180-9400-a8b24be1dd82"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6183), "Payment Status-2", new Guid("06a0f7da-40cf-43d4-887d-4124edd78ca7"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6184) },
                    { new Guid("7235012c-d1c1-40ea-86fb-0aaa3a1af4bc"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6175), "Authorization and Pay Mod-1", new Guid("3fe4c83e-ef59-45ff-b000-d64d8bcb110b"), "Verified", "301", "Payment method verified", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6176) },
                    { new Guid("a0f4cad5-0436-477c-96ce-452bbadc9df7"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6186), "Payment Status-3", new Guid("06a0f7da-40cf-43d4-887d-4124edd78ca7"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6186) },
                    { new Guid("a6283508-0c42-4bb4-9cd5-758dbaca3d19"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6150), "Order Progression-3", new Guid("9f2e9a06-cdfb-4341-a976-c0b7af13e0e2"), "Shipped", "103", "Order is shipped", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6150) },
                    { new Guid("c9f07fff-c588-411d-84fd-6c389ac4581b"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6172), "Financial Transaction-4", new Guid("06a0f7da-40cf-43d4-887d-4124edd78ca7"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6172) },
                    { new Guid("ce123e06-f12b-4b23-8246-e4310a84f54d"), new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6166), "Financial Transaction-2", new Guid("06a0f7da-40cf-43d4-887d-4124edd78ca7"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 10, 2, 16, 28, 46, 573, DateTimeKind.Local).AddTicks(6166) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("7eb51278-826b-44b6-88a1-934b0d7e926d"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("8e9fa68a-f50b-4f86-8b3b-ad0ebf806637"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("0c3681c5-143f-42c2-9ff7-e63e3370f26a"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("0d1c3a3c-6db1-4294-9368-d860dbd7936b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("0f198637-f438-4371-873b-911289a8b01d"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("188d2da9-7fc1-4684-8b49-5c2ca61a44e4"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2aa21a05-fcc3-4561-b12f-50cc28276ad1"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("331fea88-3658-4e60-bbe4-2edd25f6726b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("3b76aa61-7f89-4364-9e9d-495c61610630"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("68e72767-0bf3-4180-9400-a8b24be1dd82"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7235012c-d1c1-40ea-86fb-0aaa3a1af4bc"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a0f4cad5-0436-477c-96ce-452bbadc9df7"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a6283508-0c42-4bb4-9cd5-758dbaca3d19"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c9f07fff-c588-411d-84fd-6c389ac4581b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ce123e06-f12b-4b23-8246-e4310a84f54d"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("06a0f7da-40cf-43d4-887d-4124edd78ca7"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("3fe4c83e-ef59-45ff-b000-d64d8bcb110b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("9f2e9a06-cdfb-4341-a976-c0b7af13e0e2"));

            migrationBuilder.AlterColumn<double>(
                name: "RemainBalance",
                table: "Balances",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
    }
}
