using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("21aa6fbc-f580-4e3d-bd9a-dd865d986aa1"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1412), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1413) },
                    { new Guid("61116d85-19ef-41ce-b6fb-96b2d342a364"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1407), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1408) },
                    { new Guid("a753fb5a-7347-4d0e-8e2e-ae797978e176"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1390), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1404) },
                    { new Guid("bcfed14f-f9e0-403a-8f0e-fb982ac0df1b"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1424), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1424) },
                    { new Guid("e6851342-0dc7-4008-ac3c-64f1cea2ba20"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1410), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1410) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01490292-e59f-48c2-ae0e-756d7b2142cc"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1526), "Financial Transaction-1", new Guid("61116d85-19ef-41ce-b6fb-96b2d342a364"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1527) },
                    { new Guid("03e127ef-a64e-41ce-bca7-fdef028cd7ae"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1537), "Financial Transaction-4", new Guid("61116d85-19ef-41ce-b6fb-96b2d342a364"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1537) },
                    { new Guid("15bcceed-5cb3-436d-872d-7a2585381b83"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1540), "Authorization and Pay Mod-1", new Guid("e6851342-0dc7-4008-ac3c-64f1cea2ba20"), "Verified", "301", "Payment method verified", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1541) },
                    { new Guid("323d91aa-6118-4164-a551-eb97af269eba"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1543), "Payment Status-1", new Guid("61116d85-19ef-41ce-b6fb-96b2d342a364"), "Paid", "401", "Order Paid", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1544) },
                    { new Guid("367c8952-d2cf-4737-9e39-dd030ae1cf24"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1516), "Order Progression-3", new Guid("a753fb5a-7347-4d0e-8e2e-ae797978e176"), "Shipped", "103", "Order is shipped", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1516) },
                    { new Guid("45b59dbc-be14-426c-83c2-04df389ce935"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1534), "Financial Transaction-3", new Guid("61116d85-19ef-41ce-b6fb-96b2d342a364"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1534) },
                    { new Guid("4663c553-479d-47ff-a9d5-28e98e028478"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1508), "Order Progression-1", new Guid("a753fb5a-7347-4d0e-8e2e-ae797978e176"), "Pending", "101", "Order is pending", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1509) },
                    { new Guid("806d3ac7-ce0a-4b8a-8ead-5b0038f7cac3"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1529), "Financial Transaction-2", new Guid("61116d85-19ef-41ce-b6fb-96b2d342a364"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1529) },
                    { new Guid("bd1a5c2d-891c-4214-bd1e-dcd844834b04"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1548), "Payment Status-3", new Guid("61116d85-19ef-41ce-b6fb-96b2d342a364"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1549) },
                    { new Guid("c34a5b80-7f36-45e7-853f-5044d603dfee"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1513), "Order Progression-2", new Guid("a753fb5a-7347-4d0e-8e2e-ae797978e176"), "Processing", "102", "Order is processing", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1514) },
                    { new Guid("c9d91ef0-46de-4a44-9944-29e6e05fccfb"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1546), "Payment Status-2", new Guid("61116d85-19ef-41ce-b6fb-96b2d342a364"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1546) },
                    { new Guid("d0e54f19-f75e-4358-9c87-659b08b25f83"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1521), "Order Progression-5", new Guid("a753fb5a-7347-4d0e-8e2e-ae797978e176"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1522) },
                    { new Guid("f725e535-c7f4-4da8-ba41-a96a48f19dcf"), new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1519), "Order Progression-4", new Guid("a753fb5a-7347-4d0e-8e2e-ae797978e176"), "Delivered", "104", "Order is delivered", new DateTime(2023, 9, 29, 14, 5, 36, 350, DateTimeKind.Local).AddTicks(1519) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("21aa6fbc-f580-4e3d-bd9a-dd865d986aa1"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("bcfed14f-f9e0-403a-8f0e-fb982ac0df1b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("01490292-e59f-48c2-ae0e-756d7b2142cc"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("03e127ef-a64e-41ce-bca7-fdef028cd7ae"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("15bcceed-5cb3-436d-872d-7a2585381b83"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("323d91aa-6118-4164-a551-eb97af269eba"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("367c8952-d2cf-4737-9e39-dd030ae1cf24"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("45b59dbc-be14-426c-83c2-04df389ce935"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4663c553-479d-47ff-a9d5-28e98e028478"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("806d3ac7-ce0a-4b8a-8ead-5b0038f7cac3"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("bd1a5c2d-891c-4214-bd1e-dcd844834b04"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c34a5b80-7f36-45e7-853f-5044d603dfee"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c9d91ef0-46de-4a44-9944-29e6e05fccfb"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d0e54f19-f75e-4358-9c87-659b08b25f83"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f725e535-c7f4-4da8-ba41-a96a48f19dcf"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("61116d85-19ef-41ce-b6fb-96b2d342a364"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("a753fb5a-7347-4d0e-8e2e-ae797978e176"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("e6851342-0dc7-4008-ac3c-64f1cea2ba20"));

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
    }
}
