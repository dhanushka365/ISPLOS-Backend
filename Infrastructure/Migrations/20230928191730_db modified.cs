using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dbmodified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "ProductBrands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "PaymentStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ProductBrands");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ProductBrands");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PaymentStatus");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "PaymentStatus");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Payments");

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
    }
}
