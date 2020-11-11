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
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000100"), "Toyota Motor" },
                    { new Guid("00000000-0000-0000-0000-000000000101"), "Colruyt" },
                    { new Guid("00000000-0000-0000-0000-000000000102"), "Engie Electrabel" },
                    { new Guid("00000000-0000-0000-0000-000000000103"), "Janssen Pharmaceutica" },
                    { new Guid("00000000-0000-0000-0000-000000000104"), "Total Belgium" },
                    { new Guid("00000000-0000-0000-0000-000000000105"), "BASF Antwerpen" },
                    { new Guid("00000000-0000-0000-0000-000000000106"), "Delhaize De Leeuw" },
                    { new Guid("00000000-0000-0000-0000-000000000107"), "Volvo Car Belgium" },
                    { new Guid("00000000-0000-0000-0000-000000000108"), "ArcelorMittal Belgium" },
                    { new Guid("00000000-0000-0000-0000-000000000109"), "Mastercard Europe" },
                    { new Guid("00000000-0000-0000-0000-000000000110"), "Proximus" },
                    { new Guid("00000000-0000-0000-0000-000000000111"), "AXA Belgium" },
                    { new Guid("00000000-0000-0000-0000-000000000112"), "Allianz Benelux" },
                    { new Guid("00000000-0000-0000-0000-000000000113"), "Daikin Europe" },
                    { new Guid("00000000-0000-0000-0000-000000000114"), "bpost" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000106"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000107"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000108"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000109"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000110"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000111"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000112"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000113"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000114"));
        }
    }
}
