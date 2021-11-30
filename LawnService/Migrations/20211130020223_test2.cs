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
                keyValue: "29118a36-517b-4304-886b-3d0fbc31cfe1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50514085-d0be-4d2f-8b62-ad0d2f2cbf25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ce70001-d822-4fe8-9d2e-742fc6b05623");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c6c5f0-8910-41cf-bace-a1d163cf9c39");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6c155d8a-103c-4e59-a336-d2e20b514a8f", 0, "Countryside", "324cc74f-a1a3-4eae-9802-455b9a8a6998", "User", "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, "HOTSTUFF@YAHOOPS.COM", null, null, "555-1212", false, "2b651fdc-d926-4395-93cf-7316c9c79464", false, "hotstuff@yahoops.com" },
                    { "4df36937-3ee3-4884-b014-77932925740a", 0, "southside", "8a5ea2fb-c295-4cde-af05-6f9e22ec3bc9", "User", "Duke@yahoops.com", false, "John", "Wayne", false, null, "DUKE@YAHOOPS.COM", null, null, "555-4242", false, "7cbb1bd7-7b1d-4a9f-8d14-f09aa89987f8", false, "Duke@yahoops.com" },
                    { "346987e6-5cca-4b32-8a87-27bad09f1ef4", 0, "Portland", "69a0ca43-bb3b-4059-b838-c294fd6ec782", "User", "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, "OMGAWD@YAHOOPS.COM", null, null, "555-3578", false, "9048cbc3-d65b-4ad2-afad-b5f8133878b2", false, "OMGawd@yahoops.com" },
                    { "37eea19a-3402-41fc-a2f6-5866b22bafc2", 0, "Annaville", "be8c02c3-b18d-4a67-b9b7-bd86ba0d0148", "User", "wyrm@yahoops.com", false, "Larry", "Linville", false, null, "WYRM@YAHOOPS.COM", null, null, "555-8946", false, "2f9aeb79-ee0a-4e99-8458-6ad773da5aaf", false, "wyrm@yahoops.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "346987e6-5cca-4b32-8a87-27bad09f1ef4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37eea19a-3402-41fc-a2f6-5866b22bafc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4df36937-3ee3-4884-b014-77932925740a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c155d8a-103c-4e59-a336-d2e20b514a8f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a0c6c5f0-8910-41cf-bace-a1d163cf9c39", 0, "Countryside", "c43ae5cc-aa5f-4b44-9342-c9ea8399d09e", "User", "hotstuff@yahoops.com", false, "Trogdor", "Burninator", false, null, "HOTSTUFF@YAHOOPS.COM", null, null, "555-1212", false, "727494b4-d95e-4eb5-9f63-eb2ef11dad48", false, "hotstuff@yahoops.com" },
                    { "29118a36-517b-4304-886b-3d0fbc31cfe1", 0, "southside", "c367c849-c9bb-4efa-95cc-6b7fab0cad8d", "User", "Duke@yahoops.com", false, "John", "Wayne", false, null, "DUKE@YAHOOPS.COM", null, null, "555-4242", false, "5fbb53ea-12c4-4318-8c3a-3e6fdf9aae50", false, "Duke@yahoops.com" },
                    { "50514085-d0be-4d2f-8b62-ad0d2f2cbf25", 0, "Portland", "85281736-1200-4bff-97d8-aa498f3170dc", "User", "OMGawd@yahoops.com", false, "Tammy", "Baker", false, null, "OMGAWD@YAHOOPS.COM", null, null, "555-3578", false, "2bb0e00c-1deb-4d8e-a708-82c6217aa785", false, "OMGawd@yahoops.com" },
                    { "8ce70001-d822-4fe8-9d2e-742fc6b05623", 0, "Annaville", "fe271a1e-1c33-4fbb-900e-14e9a2088604", "User", "wyrm@yahoops.com", false, "Larry", "Linville", false, null, "WYRM@YAHOOPS.COM", null, null, "555-8946", false, "21a9eb87-778a-41ed-a2ea-2665d21faa88", false, "wyrm@yahoops.com" }
                });
        }
    }
}
