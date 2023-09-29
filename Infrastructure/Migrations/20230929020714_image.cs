using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

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
    }
}
