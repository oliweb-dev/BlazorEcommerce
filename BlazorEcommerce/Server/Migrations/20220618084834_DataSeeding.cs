using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Le smartphone est devenu un objet indispensable car il nous permet de faire pleins de choses ! Mais quel système d’exploitation vous convient le mieux, vous prenez beaucoup de photos, vous regardez souvent des vidéos … ?", "https://www.vandenborre.be/WEB/images/products/300/xiaomi_redmi-9a-32gb-blue-2022_7923260_1.jpg", 208.99m, "SMARTPHONE XIAOMI REDMI 9AS BLUE" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Le smartphone est devenu un objet indispensable car il nous permet de faire pleins de choses ! Mais quel système d’exploitation vous convient le mieux, vous prenez beaucoup de photos, vous regardez souvent des vidéos … ?", "https://www.vandenborre.be/WEB/images/products/300/xiaomi_xiaomi-redmi-9a-32gb-grey_8187630_1.jpg", 214.99m, "SMARTPHONE XIAOMI REDMI 9A GREY" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Le smartphone est devenu un objet indispensable car il nous permet de faire pleins de choses ! Mais quel système d’exploitation vous convient le mieux, vous prenez beaucoup de photos, vous regardez souvent des vidéos … ?", "https://www.vandenborre.be/WEB/images/products/300/motorola_moto-e32-slate-grey_7914768_1.jpg", 199.99m, "SMARTPHONE MOTOROLA MOTO E32 SLATE GREY" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
