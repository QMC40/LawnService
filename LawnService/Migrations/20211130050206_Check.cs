using Microsoft.EntityFrameworkCore.Migrations;

namespace LawnService.Migrations
{
    public partial class Check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e9c3dbb-cac0-4b0b-9bc6-a6830ba227b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54258a4c-2c69-4d26-bb8b-9fa6ff2dee63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b46b229c-53ba-43d1-9195-51ce5fac00cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c07a91b2-abd0-4c0d-8e02-7044e924a2f5");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "c07a91b2-abd0-4c0d-8e02-7044e924a2f5", 0, "Countryside", "6fef4c0a-2823-4273-b1ca-99c622ce33ed", "User", "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, "HOTSTUFF@YAHOOPS.COM", null, null, "555-1212", false, "8b5cbf20-a6a7-495a-9928-95796a017317", false, "hotstuff@yahoops.com" },
                    { "b46b229c-53ba-43d1-9195-51ce5fac00cf", 0, "southside", "2eee887b-3e26-40c4-982d-6e47ddbd660d", "User", "Duke@yahoops.com", false, "John", "Wayne", false, null, "DUKE@YAHOOPS.COM", null, null, "555-4242", false, "11d52631-d27a-4c81-878e-f292e4b5d40f", false, "Duke@yahoops.com" },
                    { "1e9c3dbb-cac0-4b0b-9bc6-a6830ba227b1", 0, "Portland", "b5ebe2a5-b531-4657-8584-df98a8f558db", "User", "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, "OMGAWD@YAHOOPS.COM", null, null, "555-3578", false, "9f5318dc-6465-4c6f-a656-e80bb3efd3f8", false, "OMGawd@yahoops.com" },
                    { "54258a4c-2c69-4d26-bb8b-9fa6ff2dee63", 0, "Annaville", "05f243a3-ed7f-4722-902a-a8fbaf8b7570", "User", "wyrm@yahoops.com", false, "Larry", "Linville", false, null, "WYRM@YAHOOPS.COM", null, null, "555-8946", false, "1789424d-96aa-42e0-ad60-8d20b4403626", false, "wyrm@yahoops.com" }
                });
        }
    }
}
