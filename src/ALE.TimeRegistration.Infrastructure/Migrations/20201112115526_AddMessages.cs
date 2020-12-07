using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class AddMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Tasks_TaskId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Users_ReceiverId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Users_SenderId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Picture_Tasks_TaskId",
                table: "Picture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Picture",
                table: "Picture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.RenameTable(
                name: "Picture",
                newName: "Pictures");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameIndex(
                name: "IX_Picture_TaskId",
                table: "Pictures",
                newName: "IX_Pictures_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_TaskId",
                table: "Messages",
                newName: "IX_Messages_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_SenderId",
                table: "Messages",
                newName: "IX_Messages_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_ReceiverId",
                table: "Messages",
                newName: "IX_Messages_ReceiverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ReceiverId", "SenderId", "TaskId", "Text" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000400"), new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000200"), "Please update your work asap." },
                    { new Guid("00000000-0000-0000-0000-000000000401"), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000201"), "Can I get more info about the task please?" },
                    { new Guid("00000000-0000-0000-0000-000000000402"), new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000202"), "Please do this asap." },
                    { new Guid("00000000-0000-0000-0000-000000000403"), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000200"), "What should I do when I finish?" }
                });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "TaskId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000217"), new Guid("00000000-0000-0000-0000-000000000021") },
                    { new Guid("00000000-0000-0000-0000-000000000218"), new Guid("00000000-0000-0000-0000-000000000022") },
                    { new Guid("00000000-0000-0000-0000-000000000219"), new Guid("00000000-0000-0000-0000-000000000023") },
                    { new Guid("00000000-0000-0000-0000-000000000220"), new Guid("00000000-0000-0000-0000-000000000024") },
                    { new Guid("00000000-0000-0000-0000-000000000221"), new Guid("00000000-0000-0000-0000-000000000024") },
                    { new Guid("00000000-0000-0000-0000-000000000223"), new Guid("00000000-0000-0000-0000-000000000025") },
                    { new Guid("00000000-0000-0000-0000-000000000225"), new Guid("00000000-0000-0000-0000-000000000025") },
                    { new Guid("00000000-0000-0000-0000-000000000216"), new Guid("00000000-0000-0000-0000-000000000021") },
                    { new Guid("00000000-0000-0000-0000-000000000226"), new Guid("00000000-0000-0000-0000-000000000026") },
                    { new Guid("00000000-0000-0000-0000-000000000227"), new Guid("00000000-0000-0000-0000-000000000027") },
                    { new Guid("00000000-0000-0000-0000-000000000228"), new Guid("00000000-0000-0000-0000-000000000028") },
                    { new Guid("00000000-0000-0000-0000-000000000229"), new Guid("00000000-0000-0000-0000-000000000029") },
                    { new Guid("00000000-0000-0000-0000-000000000230"), new Guid("00000000-0000-0000-0000-000000000030") },
                    { new Guid("00000000-0000-0000-0000-000000000224"), new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0000-000000000215"), new Guid("00000000-0000-0000-0000-000000000021") },
                    { new Guid("00000000-0000-0000-0000-000000000213"), new Guid("00000000-0000-0000-0000-000000000020") },
                    { new Guid("00000000-0000-0000-0000-000000000231"), new Guid("00000000-0000-0000-0000-000000000015") },
                    { new Guid("00000000-0000-0000-0000-000000000212"), new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0000-000000000211"), new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("00000000-0000-0000-0000-000000000210"), new Guid("00000000-0000-0000-0000-000000000015") },
                    { new Guid("00000000-0000-0000-0000-000000000209"), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000208"), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000207"), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000206"), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000000-0000-0000-0000-000000000205"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000204"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000203"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000202"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000201"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000200"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000214"), new Guid("00000000-0000-0000-0000-000000000020") },
                    { new Guid("00000000-0000-0000-0000-000000000232"), new Guid("00000000-0000-0000-0000-000000000030") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Tasks_TaskId",
                table: "Messages",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ReceiverId",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_SenderId",
                table: "Messages",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Tasks_TaskId",
                table: "Pictures",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Tasks_TaskId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_SenderId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Tasks_TaskId",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000400"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000401"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000402"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000403"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000200"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000201"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000202"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000203"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000204"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000205"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000206"), new Guid("00000000-0000-0000-0000-000000000010") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000207"), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000208"), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000209"), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000210"), new Guid("00000000-0000-0000-0000-000000000015") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000231"), new Guid("00000000-0000-0000-0000-000000000015") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000211"), new Guid("00000000-0000-0000-0000-000000000016") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000212"), new Guid("00000000-0000-0000-0000-000000000017") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000224"), new Guid("00000000-0000-0000-0000-000000000017") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000213"), new Guid("00000000-0000-0000-0000-000000000020") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000214"), new Guid("00000000-0000-0000-0000-000000000020") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000215"), new Guid("00000000-0000-0000-0000-000000000021") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000216"), new Guid("00000000-0000-0000-0000-000000000021") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000217"), new Guid("00000000-0000-0000-0000-000000000021") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000218"), new Guid("00000000-0000-0000-0000-000000000022") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000219"), new Guid("00000000-0000-0000-0000-000000000023") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000220"), new Guid("00000000-0000-0000-0000-000000000024") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000221"), new Guid("00000000-0000-0000-0000-000000000024") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000223"), new Guid("00000000-0000-0000-0000-000000000025") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000225"), new Guid("00000000-0000-0000-0000-000000000025") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000226"), new Guid("00000000-0000-0000-0000-000000000026") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000227"), new Guid("00000000-0000-0000-0000-000000000027") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000228"), new Guid("00000000-0000-0000-0000-000000000028") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000229"), new Guid("00000000-0000-0000-0000-000000000029") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000230"), new Guid("00000000-0000-0000-0000-000000000030") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "TaskId", "UserId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000232"), new Guid("00000000-0000-0000-0000-000000000030") });

            migrationBuilder.RenameTable(
                name: "Pictures",
                newName: "Picture");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_TaskId",
                table: "Picture",
                newName: "IX_Picture_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_TaskId",
                table: "Message",
                newName: "IX_Message_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_SenderId",
                table: "Message",
                newName: "IX_Message_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_ReceiverId",
                table: "Message",
                newName: "IX_Message_ReceiverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Picture",
                table: "Picture",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Tasks_TaskId",
                table: "Message",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Users_ReceiverId",
                table: "Message",
                column: "ReceiverId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Users_SenderId",
                table: "Message",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_Tasks_TaskId",
                table: "Picture",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
