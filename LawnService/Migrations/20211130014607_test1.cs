using Microsoft.EntityFrameworkCore.Migrations;

namespace LawnService.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProdId", "CostPerUnit", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 50.0, "weedeat and edge by the hour", "Weed eating" },
                    { 2, 35.0, "Mow by the hour", "Mowing" },
                    { 3, 100.0, "Fertilize 100 sq ft of grass", "Fertilize" },
                    { 4, 55.0, "Gather and remove 100 cubic ft of leaves", "Leaf removal" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProdId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProdId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProdId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProdId",
                keyValue: 4);
        }
    }
}
