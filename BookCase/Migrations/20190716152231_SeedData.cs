using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookCase.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "055bbcfe-d7df-4e4b-a245-8cbcf7919b98", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGX7LwjTOMJl4BY2sAogZropSqZhHFbzwmcj4X+ZoLB7pL9tQoddBKdt4iLTczWR4Q==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "Genre", "LastName", "PenName" },
                values: new object[] { 1, "Stephen", "Horror", "King", "Richard Bachman" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "Genre", "Isbn", "OwnerId", "PublishDate", "Title" },
                values: new object[] { 1, 1, null, "1234567899", "00000000-ffff-ffff-ffff-ffffffffffff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
