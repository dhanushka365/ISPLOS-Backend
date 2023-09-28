using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class orderstatustypenewdataadded1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("3d029224-42f3-4547-95ab-12b5cf45d024"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("5183c75a-b44c-4710-9b06-031404a188ed"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("5570a51e-4480-43d0-944d-563ac3cedeb5"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("a8734e3e-e945-4e3e-abdb-d888fbb2efcc"));

            migrationBuilder.DeleteData(
                table: "OrderStatuseTypes",
                keyColumn: "Id",
                keyValue: new Guid("e3bf88f2-92e8-4e7d-874b-33dae094b7ad"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("3d029224-42f3-4547-95ab-12b5cf45d024"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\"Review\" and \"Dispute\" are essential features that can enhance the user experience and address potential issues.", "Review and Dispute", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5183c75a-b44c-4710-9b06-031404a188ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A financial transaction refers to the exchange of funds or financial assets between two or more parties. These transactions are essential in the functioning of economies and businesses, enabling the flow of money, resources, and investments. Financial transactions can take many forms and serve various purposes, but they typically involve the transfer of money, securities, or other financial instruments.", "Financial Transaction", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5570a51e-4480-43d0-944d-563ac3cedeb5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Order progression refers to the series of steps or stages that an order goes through from the moment it is placed until it is fulfilled or completed. This process is commonly associated with e-commerce, retail, manufacturing, and various other industries where goods or services are exchanged between a customer and a business.", "Order Progression", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8734e3e-e945-4e3e-abdb-d888fbb2efcc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Payment status refers to the state or condition of a financial transaction at a specific point in time. It provides information about whether a payment has been successfully completed, is pending, or has encountered issues. Payment status is important for both the payer and the payee as it indicates the outcome of a financial transaction.", "Payment Status", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e3bf88f2-92e8-4e7d-874b-33dae094b7ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Authorization and the Payment Module work together to create a secure and user-friendly experience. Authorization ensures that users have proper access, while the Payment Module facilitates hassle-free and secure transactions, making it convenient for customers to order and pay for their lunch", "Authorization and Pay Mod", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
