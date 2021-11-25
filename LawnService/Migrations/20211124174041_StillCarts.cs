using Microsoft.EntityFrameworkCore.Migrations;

namespace LawnService.Migrations
{
    public partial class StillCarts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Product_Id ",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "ShoppingCartItems",
                newName: "ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_Id ",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_Id ");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Product_Id ",
                table: "ShoppingCartItems",
                column: "Id ",
                principalTable: "Product",
                principalColumn: "Id ",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Product_Id ",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "CartItems");

            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "CartItems",
                newName: "CartId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_Id ",
                table: "CartItems",
                newName: "IX_CartItems_Id ");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Product_Id ",
                table: "CartItems",
                column: "Id ",
                principalTable: "Product",
                principalColumn: "Id ",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
