using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderTableOrderDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "OrderDate",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
