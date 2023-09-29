using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("7709f50f-ede0-4817-b1ac-0287a5cd948f"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("a81cbadc-d9a8-4ac7-a89d-c768bb023705"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("0c93f5ef-b503-48d6-b23d-ae9b7a38a593"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2535209f-bdf3-4034-9546-a72aa1280a59"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2cab5edd-ee72-499a-9af8-0e8911d9a833"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("59e43a17-4bb9-4299-9227-4219752cd559"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("9237f40c-bb10-45c9-b160-191c2fd08eea"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b124bc32-2f69-4c48-8618-3a42af401be1"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b6a5014c-7475-4bcb-8f37-9568be9e2240"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c320c184-6468-4274-982d-50975aef5493"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("de44c81b-6e66-412a-9731-5e5c7a207680"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e087db20-9de9-4123-b298-44d7ad4dd9c0"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f0ef2e64-e836-46f9-b5bc-dd39e19c9fe8"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f1985903-8953-4a3b-847f-e37300d8c7d2"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f4f238b8-5212-4c65-8ea3-62488a703464"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("9552c944-c401-4879-99f3-18496844bbc9"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("b7117f24-59f8-4c75-acb1-b718b90496a2"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("f61ea3ac-4933-43a5-a94a-3e692ac416e9"));

            migrationBuilder.InsertData(
                table: "OrderStatuseTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0d25d270-9770-4b5e-8861-f7f5e1ce7f50"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(1972), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(1973) },
                    { new Guid("1bb00eb6-28c3-478a-a649-899c0c213b69"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(1942), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(1958) },
                    { new Guid("96dc8da0-332a-4595-98a8-d425baa68ae8"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(1987), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(1988) },
                    { new Guid("9d5de1d3-2311-41b1-baf0-c91f519edd60"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(1965), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(1965) },
                    { new Guid("cf6b846c-2e87-4003-90d8-7d7f302d87c2"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(1969), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(1969) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06865ac6-6626-403f-85ae-bc723bccbcca"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2163), "Order Progression-1", new Guid("1bb00eb6-28c3-478a-a649-899c0c213b69"), "Pending", "101", "Order is pending", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2163) },
                    { new Guid("1159280e-772b-490d-b58c-dcf96ea1774e"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2202), "Financial Transaction-3", new Guid("9d5de1d3-2311-41b1-baf0-c91f519edd60"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2203) },
                    { new Guid("1160a99b-42f4-4129-b47b-0d5f5996977a"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2175), "Order Progression-3", new Guid("1bb00eb6-28c3-478a-a649-899c0c213b69"), "Shipped", "103", "Order is shipped", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2176) },
                    { new Guid("160a23d3-2177-4bbd-9d80-ade1e0192d8b"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2219), "Payment Status-2", new Guid("9d5de1d3-2311-41b1-baf0-c91f519edd60"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2220) },
                    { new Guid("6659248d-62fe-49e4-aa62-72d8fe77a53c"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2216), "Payment Status-1", new Guid("9d5de1d3-2311-41b1-baf0-c91f519edd60"), "Paid", "401", "Order Paid", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2216) },
                    { new Guid("78fe775c-bdd5-49df-b70f-0ea904657fd9"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2190), "Financial Transaction-1", new Guid("9d5de1d3-2311-41b1-baf0-c91f519edd60"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2191) },
                    { new Guid("7d032f8b-0cb7-4c0f-bb68-fcbe0b3bc11f"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2212), "Authorization and Pay Mod-1", new Guid("cf6b846c-2e87-4003-90d8-7d7f302d87c2"), "Verified", "301", "Payment method verified", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2213) },
                    { new Guid("87a2b7d7-b331-4f93-8cdd-a688acd8b5eb"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2206), "Financial Transaction-4", new Guid("9d5de1d3-2311-41b1-baf0-c91f519edd60"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2207) },
                    { new Guid("aba7d488-cafd-415c-b2ce-e7627db74322"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2171), "Order Progression-2", new Guid("1bb00eb6-28c3-478a-a649-899c0c213b69"), "Processing", "102", "Order is processing", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2172) },
                    { new Guid("ba482740-269d-4dda-8290-360a3f0dd4ae"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2223), "Payment Status-3", new Guid("9d5de1d3-2311-41b1-baf0-c91f519edd60"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2223) },
                    { new Guid("d2258c19-f470-47d0-8645-fc05e608f0a3"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2194), "Financial Transaction-2", new Guid("9d5de1d3-2311-41b1-baf0-c91f519edd60"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2195) },
                    { new Guid("da7aaf2f-c379-4ce7-9266-c728a48ef8f7"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2180), "Order Progression-4", new Guid("1bb00eb6-28c3-478a-a649-899c0c213b69"), "Delivered", "104", "Order is delivered", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2180) },
                    { new Guid("e2752bdd-6c9f-47e8-bd5a-5b8e6b432803"), new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2184), "Order Progression-5", new Guid("1bb00eb6-28c3-478a-a649-899c0c213b69"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 9, 29, 10, 24, 55, 36, DateTimeKind.Local).AddTicks(2185) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("0d25d270-9770-4b5e-8861-f7f5e1ce7f50"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("96dc8da0-332a-4595-98a8-d425baa68ae8"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("06865ac6-6626-403f-85ae-bc723bccbcca"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1159280e-772b-490d-b58c-dcf96ea1774e"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1160a99b-42f4-4129-b47b-0d5f5996977a"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("160a23d3-2177-4bbd-9d80-ade1e0192d8b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6659248d-62fe-49e4-aa62-72d8fe77a53c"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("78fe775c-bdd5-49df-b70f-0ea904657fd9"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7d032f8b-0cb7-4c0f-bb68-fcbe0b3bc11f"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("87a2b7d7-b331-4f93-8cdd-a688acd8b5eb"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("aba7d488-cafd-415c-b2ce-e7627db74322"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ba482740-269d-4dda-8290-360a3f0dd4ae"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d2258c19-f470-47d0-8645-fc05e608f0a3"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("da7aaf2f-c379-4ce7-9266-c728a48ef8f7"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e2752bdd-6c9f-47e8-bd5a-5b8e6b432803"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("1bb00eb6-28c3-478a-a649-899c0c213b69"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("9d5de1d3-2311-41b1-baf0-c91f519edd60"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("cf6b846c-2e87-4003-90d8-7d7f302d87c2"));

            migrationBuilder.InsertData(
                table: "OrderStatuseTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7709f50f-ede0-4817-b1ac-0287a5cd948f"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(4976), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(4977) },
                    { new Guid("9552c944-c401-4879-99f3-18496844bbc9"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(4975), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(4975) },
                    { new Guid("a81cbadc-d9a8-4ac7-a89d-c768bb023705"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(4978), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(4978) },
                    { new Guid("b7117f24-59f8-4c75-acb1-b718b90496a2"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(4973), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(4973) },
                    { new Guid("f61ea3ac-4933-43a5-a94a-3e692ac416e9"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(4960), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(4970) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c93f5ef-b503-48d6-b23d-ae9b7a38a593"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5034), "Financial Transaction-1", new Guid("b7117f24-59f8-4c75-acb1-b718b90496a2"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5034) },
                    { new Guid("2535209f-bdf3-4034-9546-a72aa1280a59"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5026), "Order Progression-3", new Guid("f61ea3ac-4933-43a5-a94a-3e692ac416e9"), "Shipped", "103", "Order is shipped", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5027) },
                    { new Guid("2cab5edd-ee72-499a-9af8-0e8911d9a833"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5024), "Order Progression-2", new Guid("f61ea3ac-4933-43a5-a94a-3e692ac416e9"), "Processing", "102", "Order is processing", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5024) },
                    { new Guid("59e43a17-4bb9-4299-9227-4219752cd559"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5031), "Order Progression-5", new Guid("f61ea3ac-4933-43a5-a94a-3e692ac416e9"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5031) },
                    { new Guid("9237f40c-bb10-45c9-b160-191c2fd08eea"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5029), "Order Progression-4", new Guid("f61ea3ac-4933-43a5-a94a-3e692ac416e9"), "Delivered", "104", "Order is delivered", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5029) },
                    { new Guid("b124bc32-2f69-4c48-8618-3a42af401be1"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5014), "Order Progression-1", new Guid("f61ea3ac-4933-43a5-a94a-3e692ac416e9"), "Pending", "101", "Order is pending", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5014) },
                    { new Guid("b6a5014c-7475-4bcb-8f37-9568be9e2240"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5050), "Payment Status-2", new Guid("b7117f24-59f8-4c75-acb1-b718b90496a2"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5050) },
                    { new Guid("c320c184-6468-4274-982d-50975aef5493"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5038), "Financial Transaction-3", new Guid("b7117f24-59f8-4c75-acb1-b718b90496a2"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5039) },
                    { new Guid("de44c81b-6e66-412a-9731-5e5c7a207680"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5048), "Payment Status-1", new Guid("b7117f24-59f8-4c75-acb1-b718b90496a2"), "Paid", "401", "Order Paid", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5048) },
                    { new Guid("e087db20-9de9-4123-b298-44d7ad4dd9c0"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5036), "Financial Transaction-2", new Guid("b7117f24-59f8-4c75-acb1-b718b90496a2"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5037) },
                    { new Guid("f0ef2e64-e836-46f9-b5bc-dd39e19c9fe8"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5041), "Financial Transaction-4", new Guid("b7117f24-59f8-4c75-acb1-b718b90496a2"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5042) },
                    { new Guid("f1985903-8953-4a3b-847f-e37300d8c7d2"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5045), "Authorization and Pay Mod-1", new Guid("9552c944-c401-4879-99f3-18496844bbc9"), "Verified", "301", "Payment method verified", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5046) },
                    { new Guid("f4f238b8-5212-4c65-8ea3-62488a703464"), new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5052), "Payment Status-3", new Guid("b7117f24-59f8-4c75-acb1-b718b90496a2"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 9, 29, 7, 37, 13, 909, DateTimeKind.Local).AddTicks(5052) }
                });
        }
    }
}
