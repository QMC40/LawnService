using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LawnService.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55d2aafa-1bd4-49cd-8ec5-c41ff43dde3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60e3d63f-534f-45a1-a6b1-ab4391ead6d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9389359f-78f8-468d-b0ad-b764a77e7bcf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c90a9366-9d32-40d6-8189-88a744073be0");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a3a6c13d-a293-4dbc-bc40-b6a69794fba2", 0, "Countryside", "529dc58e-def9-4d50-b158-27e23615d83b", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, null, null, null, "555-1212", false, 1, "000-00-0001", "cbb2cbea-b064-4b49-a93c-e46cb9ff68f8", false, null },
                    { "c4f703d9-6e4c-4d7b-aaf6-72712a381d24", 0, "southside", "6a8b935a-a277-495d-8622-724baa7d23d0", new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duke@yahoops.com", false, "John", "Wayne", false, null, null, null, null, "555-4242", false, 3, "123-45-6789", "7d9aeb42-9384-4708-9081-3f0837feed28", false, null },
                    { "c6aeea6b-0e82-4986-b066-488492efb372", 0, "Portland", "544c4b9c-24e5-4195-9121-d391bfd45f99", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, null, null, null, "555-3578", false, 2, "987-65-4321", "a16c18ec-5d98-4e9a-a9f6-a9efca4a8cb4", false, null },
                    { "a7cf52e2-cf15-4857-a052-398fb562134a", 0, "Annaville", "075fcbce-ae99-4d4e-888d-b8837ae033a5", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "wyrm@yahoops.com", false, "Larry", "Linville", false, null, null, null, null, "555-8946", false, 2, "556-28-1867", "0af4ba8d-3484-4e4d-b696-933e1ab9ebd4", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Location",
                value: "Holly");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3a6c13d-a293-4dbc-bc40-b6a69794fba2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cf52e2-cf15-4857-a052-398fb562134a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4f703d9-6e4c-4d7b-aaf6-72712a381d24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6aeea6b-0e82-4986-b066-488492efb372");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9389359f-78f8-468d-b0ad-b764a77e7bcf", 0, "Countryside", "323b037a-c70e-4232-b183-ff86bd9f3e39", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Trogdor", "Burninator", false, null, null, null, null, "555-1212", false, 1, "000-00-0001", "8773c144-1551-4b10-92d8-ce813f04475b", false, null },
                    { "c90a9366-9d32-40d6-8189-88a744073be0", 0, "southside", "c91e68b3-ab36-4ba0-a6fc-c0b5f91f33be", new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "John", "Wayne", false, null, null, null, null, "555-4242", false, 3, "123-45-6789", "aabf7c59-ced3-4854-a7e9-b7462c217244", false, null },
                    { "60e3d63f-534f-45a1-a6b1-ab4391ead6d3", 0, "Portland", "1ec3b7d4-39d2-4273-9900-c08acc74a624", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tammy", "Baker", false, null, null, null, null, "555-3578", false, 2, "987-65-4321", "b039b20f-73b9-473d-87af-32fe72628c4d", false, null },
                    { "55d2aafa-1bd4-49cd-8ec5-c41ff43dde3a", 0, "Annaville", "8947524e-cbb5-424d-b4b8-217422eacac0", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Larry", "Linville", false, null, null, null, null, "555-8946", false, 2, "556-28-1867", "c7ba06e9-4de6-4b81-89c9-a2766a9bc5a3", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Location",
                value: "Airline");
        }
    }
}
