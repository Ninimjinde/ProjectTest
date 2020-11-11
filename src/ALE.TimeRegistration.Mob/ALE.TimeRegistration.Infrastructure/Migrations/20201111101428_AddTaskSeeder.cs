using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class AddTaskSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000200"), null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000200"));
        }
    }
}
