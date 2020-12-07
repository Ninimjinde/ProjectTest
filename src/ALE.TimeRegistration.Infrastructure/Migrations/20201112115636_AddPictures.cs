using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class AddPictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "TaskId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000300"), new Guid("00000000-0000-0000-0000-000000000200") },
                    { new Guid("00000000-0000-0000-0000-000000000301"), new Guid("00000000-0000-0000-0000-000000000201") },
                    { new Guid("00000000-0000-0000-0000-000000000302"), new Guid("00000000-0000-0000-0000-000000000201") },
                    { new Guid("00000000-0000-0000-0000-000000000303"), new Guid("00000000-0000-0000-0000-000000000202") },
                    { new Guid("00000000-0000-0000-0000-000000000304"), new Guid("00000000-0000-0000-0000-000000000203") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000300"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000301"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000302"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000303"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000304"));
        }
    }
}
