using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class AddProjectSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000100"), "Toyota Motor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"));
        }
    }
}
