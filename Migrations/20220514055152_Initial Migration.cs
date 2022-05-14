using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManager.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: true),
                    AcquiredOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CurrentUser = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    JoinedOn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AcquiredOn", "CurrentUser", "Manufacturer", "Name", "SerialNumber", "Type" },
                values: new object[] { 1, new DateTime(2022, 5, 14, 7, 51, 52, 165, DateTimeKind.Local).AddTicks(3213), 1, "Samsung", "Samsung Galaxy M11", "0094KC029M", "smartphone" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AcquiredOn", "CurrentUser", "Manufacturer", "Name", "SerialNumber", "Type" },
                values: new object[] { 2, new DateTime(2022, 5, 14, 7, 51, 52, 166, DateTimeKind.Local).AddTicks(9743), 2, "Samsung", "Samsung Galaxy Tab S4-A", "099393V54VT", "tablet" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AcquiredOn", "CurrentUser", "Manufacturer", "Name", "SerialNumber", "Type" },
                values: new object[] { 3, new DateTime(2022, 5, 14, 7, 51, 52, 166, DateTimeKind.Local).AddTicks(9774), 1, "Lenovo", "Lenovo Thinkpad T480s", "PC3029m4", "laptop" });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "AcquiredOn", "CurrentUser", "Manufacturer", "Name", "SerialNumber", "Type" },
                values: new object[] { 4, new DateTime(2022, 5, 14, 7, 51, 52, 166, DateTimeKind.Local).AddTicks(9778), 3, "Apple", "Mac Book Pro Express", "MC343302", "laptop" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Department", "JoinedOn", "UserId", "Username" },
                values: new object[] { 1, "infrastructure development", new DateTime(2022, 5, 14, 7, 51, 52, 458, DateTimeKind.Local).AddTicks(6478), new Guid("1ff70d72-526d-4ed1-8652-b6d5316d2cdc"), "Tinashe Chitakunye" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Department", "JoinedOn", "UserId", "Username" },
                values: new object[] { 2, "infrastructure development", new DateTime(2022, 5, 14, 7, 51, 52, 458, DateTimeKind.Local).AddTicks(6949), new Guid("607f7b3e-77dd-4232-aa5a-711b56fa3ae8"), "Kimberly Manyonga" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Department", "JoinedOn", "UserId", "Username" },
                values: new object[] { 3, "infrastructure development", new DateTime(2022, 5, 14, 7, 51, 52, 458, DateTimeKind.Local).AddTicks(6956), new Guid("0221a8af-de8b-497c-a8b0-e9960526a0bb"), "Richard Dzingai" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
