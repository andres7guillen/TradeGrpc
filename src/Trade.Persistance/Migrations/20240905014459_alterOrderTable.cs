using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Trade.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class alterOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ed08877-0edb-45ed-8e7a-f43e7d5801a7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("99b41f2e-cfb2-4457-abff-e6315e1d0763"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b97496be-9aec-4a06-847b-1529a410b1ca"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f29a98c5-41b0-42d2-96ef-d0d6ee2fe418"));

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Orders",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "USD");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Created", "CreatedBy", "Currency", "LastModified", "LastModifiedBy", "Price", "Quanty", "Side", "Symbol", "Text", "TransactTime", "Type" },
                values: new object[,]
                {
                    { new Guid("5df19077-8657-4e10-98ea-a0519587f6ea"), new DateTime(2024, 9, 4, 20, 44, 59, 50, DateTimeKind.Local).AddTicks(1671), "System", "USD", null, null, 0m, 800, 1, "TESLA", "", new DateTime(2024, 9, 4, 20, 44, 59, 50, DateTimeKind.Local).AddTicks(1671), 1 },
                    { new Guid("b896c9eb-1608-4a7e-976c-a03aff28d0f9"), new DateTime(2024, 9, 4, 20, 44, 59, 50, DateTimeKind.Local).AddTicks(1666), "System", "USD", null, null, 424.30m, 300, 0, "MICROSOFT", "", new DateTime(2024, 9, 4, 20, 44, 59, 50, DateTimeKind.Local).AddTicks(1665), 0 },
                    { new Guid("d613c5b5-71c4-48f5-bea7-bc8956993740"), new DateTime(2024, 9, 4, 20, 44, 59, 50, DateTimeKind.Local).AddTicks(1669), "System", "USD", null, null, 0m, 400, 1, "AMAZON", "", new DateTime(2024, 9, 4, 20, 44, 59, 50, DateTimeKind.Local).AddTicks(1669), 1 },
                    { new Guid("ef5f0f31-4a74-49fc-8d1d-1b0ced81aab9"), new DateTime(2024, 9, 4, 20, 44, 59, 50, DateTimeKind.Local).AddTicks(1641), "System", "USD", null, null, 522.99m, 1000, 0, "META", "", new DateTime(2024, 9, 4, 20, 44, 59, 50, DateTimeKind.Local).AddTicks(1629), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5df19077-8657-4e10-98ea-a0519587f6ea"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b896c9eb-1608-4a7e-976c-a03aff28d0f9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d613c5b5-71c4-48f5-bea7-bc8956993740"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ef5f0f31-4a74-49fc-8d1d-1b0ced81aab9"));

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "LastModifiedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Price", "Quanty", "Side", "Symbol", "TransactTime", "Type" },
                values: new object[,]
                {
                    { new Guid("8ed08877-0edb-45ed-8e7a-f43e7d5801a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 522.99m, 1000, 0, "META", new DateTime(2024, 9, 4, 20, 25, 4, 768, DateTimeKind.Local).AddTicks(7368), 0 },
                    { new Guid("99b41f2e-cfb2-4457-abff-e6315e1d0763"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 0m, 400, 1, "AMAZON", new DateTime(2024, 9, 4, 20, 25, 4, 768, DateTimeKind.Local).AddTicks(7395), 1 },
                    { new Guid("b97496be-9aec-4a06-847b-1529a410b1ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 424.30m, 300, 0, "MICROSOFT", new DateTime(2024, 9, 4, 20, 25, 4, 768, DateTimeKind.Local).AddTicks(7393), 0 },
                    { new Guid("f29a98c5-41b0-42d2-96ef-d0d6ee2fe418"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 0m, 800, 1, "TESLA", new DateTime(2024, 9, 4, 20, 25, 4, 768, DateTimeKind.Local).AddTicks(7397), 1 }
                });
        }
    }
}
