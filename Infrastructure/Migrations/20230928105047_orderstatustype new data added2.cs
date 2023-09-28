using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class orderstatustypenewdataadded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("381a6496-198f-44aa-a066-42dbf74cc9b7"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("7be3c1c9-b8f0-4978-8f78-f58ccd5b078a"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("85c2c4cd-59d6-4834-8ea7-16c6acda1642"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("a570ef0d-0416-4add-9534-c8b1d0dd9d4d"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("cef6d5e6-8236-4fcc-a9f8-2983cc32da1e"));

            migrationBuilder.InsertData(
                table: "OrderStatuseTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3c83e8ed-f232-4dd8-9016-202d19980730"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7345), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7345) },
                    { new Guid("4e19f88a-6bdd-4ba6-b1f6-6d7eadd642eb"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7343), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7344) },
                    { new Guid("7cf7fb0a-d050-49c8-8e35-889baeddeffb"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7341), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7342) },
                    { new Guid("89d2b335-fbfc-4f2d-8691-29bab3179c32"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7320), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7328) },
                    { new Guid("990396cf-831e-4a14-8e8e-718ad8795ec4"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7339), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7339) }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "OrderStatusTypeId", "Status", "StatusCode", "StatusMessage", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04ae0430-6636-4627-aa1a-0fa22e0d88e4"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7424), "Payment Status-3", new Guid("990396cf-831e-4a14-8e8e-718ad8795ec4"), "unPaid", "403", "Order is UnPaid", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7424) },
                    { new Guid("06272cdc-11e2-4fdf-aaec-40cfd72068ea"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7401), "Order Progression-4", new Guid("89d2b335-fbfc-4f2d-8691-29bab3179c32"), "Delivered", "104", "Order is delivered", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7401) },
                    { new Guid("18d1ef55-2d48-4b3f-91b7-599a2395213b"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7420), "Payment Status-2", new Guid("990396cf-831e-4a14-8e8e-718ad8795ec4"), "partially Paid", "402", "Order Partially Paid", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7421) },
                    { new Guid("3015b8cc-5f05-4d68-a879-262ab8d469dd"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7416), "Authorization and Pay Mod-1", new Guid("7cf7fb0a-d050-49c8-8e35-889baeddeffb"), "Verified", "301", "Payment method verified", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7417) },
                    { new Guid("675d2246-8b1e-49ab-ae8b-f2e061cb9781"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7418), "Payment Status-1", new Guid("990396cf-831e-4a14-8e8e-718ad8795ec4"), "Paid", "401", "Order Paid", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7419) },
                    { new Guid("6ad5807b-56be-4864-93ec-d61b8e0570d2"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7396), "Order Progression-2", new Guid("89d2b335-fbfc-4f2d-8691-29bab3179c32"), "Processing", "102", "Order is processing", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7397) },
                    { new Guid("7ef31a36-94e5-4198-acbc-389576f98f36"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7414), "Financial Transaction-4", new Guid("990396cf-831e-4a14-8e8e-718ad8795ec4"), "Cancelled", "204", "Financial transaction is cancelled", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7414) },
                    { new Guid("89e5640e-d353-4948-9535-d888bf079de4"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7410), "Financial Transaction-2", new Guid("990396cf-831e-4a14-8e8e-718ad8795ec4"), "Processing", "202", "Financial transaction is processing", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7410) },
                    { new Guid("b1c90065-c92d-458a-8728-acf0ac1beee7"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7393), "Order Progression-1", new Guid("89d2b335-fbfc-4f2d-8691-29bab3179c32"), "Pending", "101", "Order is pending", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7393) },
                    { new Guid("c2fb1b26-1530-4882-abbf-7247aa62c2a3"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7412), "Financial Transaction-3", new Guid("990396cf-831e-4a14-8e8e-718ad8795ec4"), "Completed", "203", "Financial transaction is completed", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7412) },
                    { new Guid("e8172abe-04be-4568-a088-2bc1331d7189"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7405), "Order Progression-5", new Guid("89d2b335-fbfc-4f2d-8691-29bab3179c32"), "Cancelled", "105", "Order is cancelled", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7405) },
                    { new Guid("ef53ff4d-31e1-4507-a92a-1bcf8ac0b3df"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7399), "Order Progression-3", new Guid("89d2b335-fbfc-4f2d-8691-29bab3179c32"), "Shipped", "103", "Order is shipped", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7399) },
                    { new Guid("f2ae19db-1265-4213-b229-0c04c9a64c3e"), new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7408), "Financial Transaction-1", new Guid("990396cf-831e-4a14-8e8e-718ad8795ec4"), "Pending", "201", "Financial transaction is pending", new DateTime(2023, 9, 28, 16, 20, 47, 482, DateTimeKind.Local).AddTicks(7408) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("3c83e8ed-f232-4dd8-9016-202d19980730"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("4e19f88a-6bdd-4ba6-b1f6-6d7eadd642eb"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("04ae0430-6636-4627-aa1a-0fa22e0d88e4"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("06272cdc-11e2-4fdf-aaec-40cfd72068ea"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("18d1ef55-2d48-4b3f-91b7-599a2395213b"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("3015b8cc-5f05-4d68-a879-262ab8d469dd"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("675d2246-8b1e-49ab-ae8b-f2e061cb9781"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6ad5807b-56be-4864-93ec-d61b8e0570d2"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7ef31a36-94e5-4198-acbc-389576f98f36"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("89e5640e-d353-4948-9535-d888bf079de4"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b1c90065-c92d-458a-8728-acf0ac1beee7"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c2fb1b26-1530-4882-abbf-7247aa62c2a3"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e8172abe-04be-4568-a088-2bc1331d7189"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("ef53ff4d-31e1-4507-a92a-1bcf8ac0b3df"));

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f2ae19db-1265-4213-b229-0c04c9a64c3e"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("7cf7fb0a-d050-49c8-8e35-889baeddeffb"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("89d2b335-fbfc-4f2d-8691-29bab3179c32"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("990396cf-831e-4a14-8e8e-718ad8795ec4"));

            migrationBuilder.InsertData(
                table: "OrderStatuseTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("381a6496-198f-44aa-a066-42dbf74cc9b7"), new DateTime(2023, 9, 28, 16, 1, 32, 715, DateTimeKind.Local).AddTicks(6453), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(2023, 9, 28, 16, 1, 32, 715, DateTimeKind.Local).AddTicks(6453) },
                    { new Guid("7be3c1c9-b8f0-4978-8f78-f58ccd5b078a"), new DateTime(2023, 9, 28, 16, 1, 32, 715, DateTimeKind.Local).AddTicks(6421), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(2023, 9, 28, 16, 1, 32, 715, DateTimeKind.Local).AddTicks(6429) },
                    { new Guid("85c2c4cd-59d6-4834-8ea7-16c6acda1642"), new DateTime(2023, 9, 28, 16, 1, 32, 715, DateTimeKind.Local).AddTicks(6449), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(2023, 9, 28, 16, 1, 32, 715, DateTimeKind.Local).AddTicks(6450) },
                    { new Guid("a570ef0d-0416-4add-9534-c8b1d0dd9d4d"), new DateTime(2023, 9, 28, 16, 1, 32, 715, DateTimeKind.Local).AddTicks(6435), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(2023, 9, 28, 16, 1, 32, 715, DateTimeKind.Local).AddTicks(6436) },
                    { new Guid("cef6d5e6-8236-4fcc-a9f8-2983cc32da1e"), new DateTime(2023, 9, 28, 16, 1, 32, 715, DateTimeKind.Local).AddTicks(6451), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(2023, 9, 28, 16, 1, 32, 715, DateTimeKind.Local).AddTicks(6452) }
                });
        }
    }
}
