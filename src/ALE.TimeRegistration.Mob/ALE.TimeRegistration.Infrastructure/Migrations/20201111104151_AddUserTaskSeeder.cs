using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class AddUserTaskSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProject_Tasks_TaskId",
                table: "UserProject");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProject_Users_UserId",
                table: "UserProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProject",
                table: "UserProject");

            migrationBuilder.RenameTable(
                name: "UserProject",
                newName: "UserTasks");

            migrationBuilder.RenameIndex(
                name: "IX_UserProject_TaskId",
                table: "UserTasks",
                newName: "IX_UserTasks_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTasks",
                table: "UserTasks",
                columns: new[] { "UserId", "TaskId" });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "UserId", "TaskId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000200") });

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTasks_Tasks_TaskId",
                table: "UserTasks",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTasks_Users_UserId",
                table: "UserTasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTasks_Tasks_TaskId",
                table: "UserTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTasks_Users_UserId",
                table: "UserTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTasks",
                table: "UserTasks");

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000200") });

            migrationBuilder.RenameTable(
                name: "UserTasks",
                newName: "UserProject");

            migrationBuilder.RenameIndex(
                name: "IX_UserTasks_TaskId",
                table: "UserProject",
                newName: "IX_UserProject_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProject",
                table: "UserProject",
                columns: new[] { "UserId", "TaskId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProject_Tasks_TaskId",
                table: "UserProject",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProject_Users_UserId",
                table: "UserProject",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
