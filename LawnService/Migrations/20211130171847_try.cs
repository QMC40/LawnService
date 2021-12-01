using Microsoft.EntityFrameworkCore.Migrations;

namespace LawnService.Migrations
{
    public partial class @try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "687a940c-96d1-403c-84ad-f4e691e4e9b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c794714-df09-49ad-ae25-37511e5e4849");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8023d45-36d7-47d2-a77b-7e5a0173bd5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e613e7c3-562e-410d-9cb4-ac394695e6b6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8883c747-c8b0-4976-a92a-d0b911e47b3b", 0, "Countryside", "f4406693-d6cc-4a08-9405-5003e7f1907a", "User", "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, "HOTSTUFF@YAHOOPS.COM", null, null, "555-1212", false, "4779cc5d-1b56-48f4-a8ee-3e2f74d95259", false, "hotstuff@yahoops.com" },
                    { "2d5d316b-57d2-463d-8c81-97f132a4e6d0", 0, "southside", "fbda1935-8a47-42c2-a3f3-ce66e9480720", "User", "Duke@yahoops.com", false, "John", "Wayne", false, null, "DUKE@YAHOOPS.COM", null, null, "555-4242", false, "0d1730fe-fb8b-4b48-85f8-de8489187741", false, "Duke@yahoops.com" },
                    { "953bdac0-dbfc-43b4-9602-8ddab4866202", 0, "Portland", "c87fbe99-6927-462c-96fc-84fe248d0b1f", "User", "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, "OMGAWD@YAHOOPS.COM", null, null, "555-3578", false, "c888b66f-e07d-456e-b206-35904a420d24", false, "OMGawd@yahoops.com" },
                    { "94fd03c0-beb8-4c6e-a9a2-321301a7d7e5", 0, "Annaville", "2296d3c2-4573-4ec3-b533-4c07390aae7d", "User", "wyrm@yahoops.com", false, "Larry", "Linville", false, null, "WYRM@YAHOOPS.COM", null, null, "555-8946", false, "6dfb1d2a-af35-449d-9275-eebe1e90d88e", false, "wyrm@yahoops.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d5d316b-57d2-463d-8c81-97f132a4e6d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8883c747-c8b0-4976-a92a-d0b911e47b3b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94fd03c0-beb8-4c6e-a9a2-321301a7d7e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "953bdac0-dbfc-43b4-9602-8ddab4866202");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7c794714-df09-49ad-ae25-37511e5e4849", 0, "Countryside", "d0bef730-8eaa-49f5-8cd7-88f0d52fc5de", "User", "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, "HOTSTUFF@YAHOOPS.COM", null, null, "555-1212", false, "d7a26d33-7003-45c5-ac79-209fea0515ed", false, "hotstuff@yahoops.com" },
                    { "e613e7c3-562e-410d-9cb4-ac394695e6b6", 0, "southside", "f9b562f9-9780-4d79-811f-0a776499f49c", "User", "Duke@yahoops.com", false, "John", "Wayne", false, null, "DUKE@YAHOOPS.COM", null, null, "555-4242", false, "8e8af471-6b9c-48f8-8d36-09192b6d9d31", false, "Duke@yahoops.com" },
                    { "687a940c-96d1-403c-84ad-f4e691e4e9b0", 0, "Portland", "9c0676ec-2fe5-4f8f-bd19-475ee313e035", "User", "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, "OMGAWD@YAHOOPS.COM", null, null, "555-3578", false, "21c1fb3c-8ac0-49b5-8beb-fb5840ed641a", false, "OMGawd@yahoops.com" },
                    { "d8023d45-36d7-47d2-a77b-7e5a0173bd5d", 0, "Annaville", "a6744181-ba6b-4829-9fb0-2d9c73d25576", "User", "wyrm@yahoops.com", false, "Larry", "Linville", false, null, "WYRM@YAHOOPS.COM", null, null, "555-8946", false, "7db0fb57-dea3-4f07-ac26-11c5c6e6b398", false, "wyrm@yahoops.com" }
                });
        }
    }
}
