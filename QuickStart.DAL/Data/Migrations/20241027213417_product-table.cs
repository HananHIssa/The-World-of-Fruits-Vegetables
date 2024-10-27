using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuickStart.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class producttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9bed7f4c-cf49-423a-bc6b-f5e1cd49ee2a", "0c48cff0-a76d-4d12-a21b-e6ce7a36782d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3312042d-9224-49c8-b23e-82b21220ffe1", "3886e5ee-ddea-450a-88f5-7edd0155141b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "68096b2c-3eda-4725-9443-4adee0cc110e", "90971a41-7304-462a-8a63-d1f95a3ea014" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3312042d-9224-49c8-b23e-82b21220ffe1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68096b2c-3eda-4725-9443-4adee0cc110e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bed7f4c-cf49-423a-bc6b-f5e1cd49ee2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c48cff0-a76d-4d12-a21b-e6ce7a36782d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3886e5ee-ddea-450a-88f5-7edd0155141b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90971a41-7304-462a-8a63-d1f95a3ea014");

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

            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatagoryProduct",
                columns: table => new
                {
                    CatagoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatagoryProduct", x => new { x.CatagoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CatagoryProduct_Catagories_CatagoriesId",
                        column: x => x.CatagoriesId,
                        principalTable: "Catagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatagoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "658c980d-f437-447a-81e4-b6ae5f264b26", null, "User", "USER" },
                    { "85b4e4ef-9cae-405c-a9cf-01a7f4d396c9", null, "Admin", "ADMIN" },
                    { "f2aec303-c5ad-413a-915e-2f3ee7660d6a", null, "SuperAdmin", "SUPERADMINE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3eab410c-438a-45e0-92fb-c93ef896afcf", 0, "05129b77-d827-4621-adbb-0c85a5234368", "SuperAdmin@comp.com", true, false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", null, null, false, "b1a38fe6-fdf9-45ca-863e-ae2dad56510f", false, "SuperAdmin@comp.com" },
                    { "3eee2948-07bd-4931-bcb7-5af218b55028", 0, "ed322598-2a45-4228-9a19-ba9a502914dc", "user@comp.com", true, false, null, "USER@COMP.COM", "USER@COMP.COM", "AQAAAAIAAYagAAAAEEgFSwas9PG28SnJqbNcSOD2DCls91ejWg7U4kS04euXvVyrSK3M0naAGHSt6v5zJg==", null, false, "2ab39f17-efe4-4e0b-a22b-58469dd8a5ee", false, "user@comp.com" },
                    { "74513f5e-cf9d-42cb-9adf-ccff9a402aad", 0, "73bc034a-9b32-4026-b93f-052c57322462", "Adminuser@comp.com", true, false, null, "ADMINEUSER@COMP.COM", "ADMINUSER@COMP.COM", "AQAAAAIAAYagAAAAEEEVHutg4UJL2ZC1Ej5cxmcSY4Z/0llovR8Xq5C/hwfUsZYSZG+sUo60LOug0OkR4A==", null, false, "b2dcf518-5486-41b4-9f58-9f39f059f817", false, "Adminuser@comp.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f2aec303-c5ad-413a-915e-2f3ee7660d6a", "3eab410c-438a-45e0-92fb-c93ef896afcf" },
                    { "658c980d-f437-447a-81e4-b6ae5f264b26", "3eee2948-07bd-4931-bcb7-5af218b55028" },
                    { "85b4e4ef-9cae-405c-a9cf-01a7f4d396c9", "74513f5e-cf9d-42cb-9adf-ccff9a402aad" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatagoryProduct_ProductsId",
                table: "CatagoryProduct",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatagoryProduct");

            migrationBuilder.DropTable(
                name: "Catagories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2aec303-c5ad-413a-915e-2f3ee7660d6a", "3eab410c-438a-45e0-92fb-c93ef896afcf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "658c980d-f437-447a-81e4-b6ae5f264b26", "3eee2948-07bd-4931-bcb7-5af218b55028" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "85b4e4ef-9cae-405c-a9cf-01a7f4d396c9", "74513f5e-cf9d-42cb-9adf-ccff9a402aad" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "658c980d-f437-447a-81e4-b6ae5f264b26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85b4e4ef-9cae-405c-a9cf-01a7f4d396c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2aec303-c5ad-413a-915e-2f3ee7660d6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3eab410c-438a-45e0-92fb-c93ef896afcf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3eee2948-07bd-4931-bcb7-5af218b55028");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74513f5e-cf9d-42cb-9adf-ccff9a402aad");

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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3312042d-9224-49c8-b23e-82b21220ffe1", null, "User", "USER" },
                    { "68096b2c-3eda-4725-9443-4adee0cc110e", null, "Admin", "ADMIN" },
                    { "9bed7f4c-cf49-423a-bc6b-f5e1cd49ee2a", null, "SuperAdmin", "SUPERADMINE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0c48cff0-a76d-4d12-a21b-e6ce7a36782d", 0, "6203e0cc-f6e4-4abd-8f33-c2dc1f835e38", "SuperAdmin@comp.com", true, false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", null, null, false, "93fd8230-1047-4b7d-85ca-3f744f5f9791", false, "SuperAdmin@comp.com" },
                    { "3886e5ee-ddea-450a-88f5-7edd0155141b", 0, "bed13421-a2cb-492e-8e79-dd16cc00bc9c", "user@comp.com", true, false, null, "USER@COMP.COM", "USER@COMP.COM", "AQAAAAIAAYagAAAAEEHPNm1GLq5D0Gp/iBcSQhdf/kn94BU4w9+7jlV4UIEfn5Y3B9xbZ+oALMaQhht8fA==", null, false, "eb00d3fa-3d00-4717-8c60-7abd76c40b9e", false, "user@comp.com" },
                    { "90971a41-7304-462a-8a63-d1f95a3ea014", 0, "7c88fd97-76c9-4f46-acf3-7ef566ccf94b", "Adminuser@comp.com", true, false, null, "ADMINEUSER@COMP.COM", "ADMINUSER@COMP.COM", "AQAAAAIAAYagAAAAEPhommGBcMf3ugCurTFeGS6K8pZY/4rY/Au3Uh9nQqFn+SYL2HOsIZnuX+k4b4iSeA==", null, false, "2ccb33dd-9522-4ded-aea0-eb28796004da", false, "Adminuser@comp.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9bed7f4c-cf49-423a-bc6b-f5e1cd49ee2a", "0c48cff0-a76d-4d12-a21b-e6ce7a36782d" },
                    { "3312042d-9224-49c8-b23e-82b21220ffe1", "3886e5ee-ddea-450a-88f5-7edd0155141b" },
                    { "68096b2c-3eda-4725-9443-4adee0cc110e", "90971a41-7304-462a-8a63-d1f95a3ea014" }
                });
        }
    }
}
