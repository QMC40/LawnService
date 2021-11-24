using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LawnService.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SSN", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c2e53c75-b9c6-4527-9119-75b8eed39a89", 0, "Countryside", "d9ba79cf-d016-4ec2-8cdb-cfb15085948b", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, null, null, null, "555-1212", false, 1, "000-00-0001", "06ac9c81-91a0-4698-8b9a-399bdf1411d8", false, "hotstuff@yahoops.com" },
                    { "20cf3259-fd92-4671-9160-743eaf017141", 0, "southside", "d48325e8-65fd-4cc5-8a9b-4b61697b3ed7", new DateTime(1934, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duke@yahoops.com", false, "John", "Wayne", false, null, null, null, null, "555-4242", false, 3, "123-45-6789", "94ddb38b-12f9-4c56-b938-c034993b80a2", false, "Duke@yahoops.com" },
                    { "3957ec9c-c4bc-49b6-8c8e-2105217fead5", 0, "Portland", "57ca8d01-c7d1-4009-8a48-a670e4138ce5", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, null, null, null, "555-3578", false, 2, "987-65-4321", "7cb63150-ca0b-46fa-9968-273750af33de", false, "OMGawd@yahoops.com" },
                    { "701b0641-0b2e-4fb0-90e4-8a0eca959010", 0, "Annaville", "c56606a8-2721-4fc3-a82f-3d593d1b7e95", new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "wyrm@yahoops.com", false, "Larry", "Linville", false, null, null, null, null, "555-8946", false, 2, "556-28-1867", "c0bad2bd-9a43-4ee6-a9a7-7bf35b9e54bd", false, "wyrm@yahoops.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20cf3259-fd92-4671-9160-743eaf017141");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3957ec9c-c4bc-49b6-8c8e-2105217fead5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "701b0641-0b2e-4fb0-90e4-8a0eca959010");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2e53c75-b9c6-4527-9119-75b8eed39a89");

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
        }
    }
}
