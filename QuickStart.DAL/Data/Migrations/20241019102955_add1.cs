using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuickStart.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class add1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Portfolios_PortfolioId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "imageName",
                table: "Items",
                newName: "ImageName");

            migrationBuilder.AlterColumn<int>(
                name: "PortfolioId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ac3dae3-dd89-4f9c-8ac9-b256533558f8", null, "Admin", "ADMIN" },
                    { "8b7dbf24-d539-4c9a-8243-adee433f9545", null, "Admin", "USER" },
                    { "d9ea30ad-21e1-4001-a7f9-d8793ced6c1d", null, "Admin", "SUPERADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Portfolios_PortfolioId",
                table: "Items",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Portfolios_PortfolioId",
                table: "Items");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ac3dae3-dd89-4f9c-8ac9-b256533558f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b7dbf24-d539-4c9a-8243-adee433f9545");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9ea30ad-21e1-4001-a7f9-d8793ced6c1d");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Items",
                newName: "imageName");

            migrationBuilder.AlterColumn<int>(
                name: "PortfolioId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Portfolios_PortfolioId",
                table: "Items",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
