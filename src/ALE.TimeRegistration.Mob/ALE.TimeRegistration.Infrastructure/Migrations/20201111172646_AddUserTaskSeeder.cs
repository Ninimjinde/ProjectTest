using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class AddUserTaskSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProject_Tasks_TaskId",
                table: "UserProject");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProject_Users_UserId",
                table: "UserProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

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
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTasks",
                table: "UserTasks",
                columns: new[] { "UserId", "TaskId" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
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

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "UserId", "TaskId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000200") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000201") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000004"), "ErnaVanvoren@hotmail.com", "Vanvoren", "Erna", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000207"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000208"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000209"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000210"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000211"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000212"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000213"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000214"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000215"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000216"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000217"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000218"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000206"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000219"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000221"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000222"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000223"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000224"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000225"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000226"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000227"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000228"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000229"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000230"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000231"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000232"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000220"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000205"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000204"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000203"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "RogerDoeniemee@telenet.be", "Vangenechte", "Roger", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Katringring@skynet.be", "Vanbelleghem", "Katleen", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "SnelnEddy@hotmail.com", "Guapo", "Edwardo", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Andy123@gmail.com", "Degught", "Andy", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "IloveyouTomorrow@hotmail.com", "Demain", "Annie", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Satchel@steelpanther.com", "Parrish", "Russ", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "DePijpVanMaarten@gmail.com", "Pijpers", "Maarten", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "EdwardLeCanard@hotmail.com", "Vaneende", "Edward", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "DeYoeri@gmail.com", "Declerk", "Yoeri", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "CalmingCamille@telenet.be", "Thee", "Camille", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "Thebestginger@qotsa.com", "Homme", "Josh", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "Zwaffelaere@gmail.com", "Uytebroeck", "Piet", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "SterkeJan33@pandora.be", "Lefort", "Jan", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "RietjeGessof@hotmail.com", "Gessof", "Rita", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "willywilly@thescabs.be", "Lambregt", "Willy", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "PescadoLover@skynet.be", "Vervis", "Kelly", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "TomVanmarcke@gmail.com", "Vantomme", "Marc", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "Loewiloewie@hotmail.com", "Decruy", "Louis", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "Giezijtem@skynet.be", "Emnie", "Ben", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "ConnieBeter@gmail.com", "Moeleker", "Connie", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "EchtElkeKant@hotmail.com", "Kant", "Elke", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000027"), "Bennernie@skynet.be", "Thuys", "Benny", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000028"), "Thebestbusker@london.com", "Cole", "Cam", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000029"), "CoronaTopper@gmail.com", "Root", "Claude", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000030"), "rapgewoon@hotmail.com", "Wenne", "Eve", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000201"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000202"), null, null, null, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Ialwayswin@gmail.com", "Pot", "Jack", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "GezondePeter@telenet.be", "Celie", "Peter", "TimeReg2020" }
                });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "UserId", "TaskId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000202") },
                    { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000230") },
                    { new Guid("00000000-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000229") },
                    { new Guid("00000000-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000228") },
                    { new Guid("00000000-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000227") },
                    { new Guid("00000000-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000226") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000225") },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000223") },
                    { new Guid("00000000-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000221") },
                    { new Guid("00000000-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000220") },
                    { new Guid("00000000-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000219") },
                    { new Guid("00000000-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000218") },
                    { new Guid("00000000-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000217") },
                    { new Guid("00000000-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000216") },
                    { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000232") },
                    { new Guid("00000000-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000215") },
                    { new Guid("00000000-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000213") },
                    { new Guid("00000000-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000224") },
                    { new Guid("00000000-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000212") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000211") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000231") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000210") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000209") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000208") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000207") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000206") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000205") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000204") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000203") },
                    { new Guid("00000000-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000214") },
                    { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000233") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTasks_Tasks_TaskId",
                table: "UserTasks",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTasks_Users_UserId",
                table: "UserTasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTasks_Tasks_TaskId",
                table: "UserTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTasks_Users_UserId",
                table: "UserTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTasks",
                table: "UserTasks");

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

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000200") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000201") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000202") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000203") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000204") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000205") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000206") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000207") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000208") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000209") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000210") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000231") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000211") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000212") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000224") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000213") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000214") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000215") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000216") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000217") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000218") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000219") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000220") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000221") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000223") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000225") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000226") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000227") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000228") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000229") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000230") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000232") });

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumns: new[] { "UserId", "TaskId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000233") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000201"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000202"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000203"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000204"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000205"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000206"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000207"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000208"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000209"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000210"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000211"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000212"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000213"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000214"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000215"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000216"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000217"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000218"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000219"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000220"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000221"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000222"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000223"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000224"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000225"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000226"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000227"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000228"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000229"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000230"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000231"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000232"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.RenameTable(
                name: "UserTasks",
                newName: "UserProject");

            migrationBuilder.RenameIndex(
                name: "IX_UserTasks_TaskId",
                table: "UserProject",
                newName: "IX_UserProject_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                columns: new[] { "SenderId", "ReceiverId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProject",
                table: "UserProject",
                columns: new[] { "UserId", "TaskId" });

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
