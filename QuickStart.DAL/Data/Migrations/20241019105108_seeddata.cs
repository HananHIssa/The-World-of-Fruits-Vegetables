using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuickStart.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "3ac3dae3-dd89-4f9c-8ac9-b256533558f8", null, "Admin", "ADMIN" },
                    { "8b7dbf24-d539-4c9a-8243-adee433f9545", null, "Admin", "USER" },
                    { "d9ea30ad-21e1-4001-a7f9-d8793ced6c1d", null, "Admin", "SUPERADMIN" }
                });
        }
    }
}
