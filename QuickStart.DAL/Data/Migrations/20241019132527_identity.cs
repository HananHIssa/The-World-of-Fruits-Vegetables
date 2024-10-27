using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuickStart.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f4e2218-58a7-4577-9f24-b0a5800bcfb7", "14929c8a-bc99-4464-8a82-b75f7e4f8cca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e43fe33-e43b-4ade-ae7b-5e2b5f70163e", "168304b6-0733-4c0e-b104-462c939babc1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9b0e7af3-0ee8-49ac-bd70-eb51a71c35a9", "72c2d26c-fde9-4540-9418-b29f5e8d2c81" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4e2218-58a7-4577-9f24-b0a5800bcfb7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b0e7af3-0ee8-49ac-bd70-eb51a71c35a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e43fe33-e43b-4ade-ae7b-5e2b5f70163e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14929c8a-bc99-4464-8a82-b75f7e4f8cca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168304b6-0733-4c0e-b104-462c939babc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72c2d26c-fde9-4540-9418-b29f5e8d2c81");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f4e2218-58a7-4577-9f24-b0a5800bcfb7", null, "Admin", "SUPERADMIN" },
                    { "9b0e7af3-0ee8-49ac-bd70-eb51a71c35a9", null, "Admin", "ADMIN" },
                    { "9e43fe33-e43b-4ade-ae7b-5e2b5f70163e", null, "Admin", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "14929c8a-bc99-4464-8a82-b75f7e4f8cca", 0, "b3b966f4-f658-4fd8-adcb-d850bc60d293", "user@comp.com", true, false, null, "USER@COMP.COM", "USER@COMP.COM", "AQAAAAIAAYagAAAAEDmjEkLuyrl8/eJNGWCy1Ylims2AQZFHKpxQwYISh22LzenEly+rHa+W9p+FVsLX7w==", null, false, "cfb8fa2f-08d9-45c5-be8c-9a00b50dcdd4", false, "user@comp.com" },
                    { "168304b6-0733-4c0e-b104-462c939babc1", 0, "85c9846d-7fea-4cc1-9c00-79b402d5d35d", "SuperAdmin@comp.com", true, false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", null, null, false, "ecfd03e1-3d63-4fb9-976d-2102b2b84c2a", false, "SuperAdmin@comp.com" },
                    { "72c2d26c-fde9-4540-9418-b29f5e8d2c81", 0, "a04862ec-b424-483f-9b02-b38581e29463", "Adminuser@comp.com", true, false, null, "ADMINEUSER@COMP.COM", "ADMINUSER@COMP.COM", "AQAAAAIAAYagAAAAEKHa8VHQwcAEfa691B00N1Z1BLeW2mlcZKLfTUDzrK2zk8rCsjdjEmKDlR7mnybwgQ==", null, false, "d10b63cb-9cb3-46e2-b900-20781ee5b16d", false, "Adminuser@comp.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3f4e2218-58a7-4577-9f24-b0a5800bcfb7", "14929c8a-bc99-4464-8a82-b75f7e4f8cca" },
                    { "9e43fe33-e43b-4ade-ae7b-5e2b5f70163e", "168304b6-0733-4c0e-b104-462c939babc1" },
                    { "9b0e7af3-0ee8-49ac-bd70-eb51a71c35a9", "72c2d26c-fde9-4540-9418-b29f5e8d2c81" }
                });
        }
    }
}
