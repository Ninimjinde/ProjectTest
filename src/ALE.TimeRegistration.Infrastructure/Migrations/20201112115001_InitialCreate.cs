using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Message_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Message_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Picture_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTasks",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTasks", x => new { x.UserId, x.TaskId });
                    table.ForeignKey(
                        name: "FK_UserTasks_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000100"), "Toyota Motor" },
                    { new Guid("00000000-0000-0000-0000-000000000113"), "Daikin Europe" },
                    { new Guid("00000000-0000-0000-0000-000000000112"), "Allianz Benelux" },
                    { new Guid("00000000-0000-0000-0000-000000000111"), "AXA Belgium" },
                    { new Guid("00000000-0000-0000-0000-000000000110"), "Proximus" },
                    { new Guid("00000000-0000-0000-0000-000000000109"), "Mastercard Europe" },
                    { new Guid("00000000-0000-0000-0000-000000000108"), "ArcelorMittal Belgium" },
                    { new Guid("00000000-0000-0000-0000-000000000114"), "bpost" },
                    { new Guid("00000000-0000-0000-0000-000000000106"), "Delhaize De Leeuw" },
                    { new Guid("00000000-0000-0000-0000-000000000105"), "BASF Antwerpen" },
                    { new Guid("00000000-0000-0000-0000-000000000104"), "Total Belgium" },
                    { new Guid("00000000-0000-0000-0000-000000000103"), "Janssen Pharmaceutica" },
                    { new Guid("00000000-0000-0000-0000-000000000102"), "Engie Electrabel" },
                    { new Guid("00000000-0000-0000-0000-000000000101"), "Colruyt" },
                    { new Guid("00000000-0000-0000-0000-000000000107"), "Volvo Car Belgium" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000017"), "Zwaffelaere@gmail.com", "Uytebroeck", "Piet", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "SterkeJan33@pandora.be", "Lefort", "Jan", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "RietjeGessof@hotmail.com", "Gessof", "Rita", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "willywilly@thescabs.be", "Lambregt", "Willy", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "PescadoLover@skynet.be", "Vervis", "Kelly", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "TomVanmarcke@gmail.com", "Vantomme", "Marc", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "ConnieBeter@gmail.com", "Moeleker", "Connie", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "Giezijtem@skynet.be", "Emnie", "Ben", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "GezondePeter@telenet.be", "Celie", "Peter", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000027"), "Bennernie@skynet.be", "Thuys", "Benny", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000028"), "Thebestbusker@london.com", "Cole", "Cam", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "Thebestginger@qotsa.com", "Homme", "Josh", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "Loewiloewie@hotmail.com", "Decruy", "Louis", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "CalmingCamille@telenet.be", "Thee", "Camille", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "SnelnEddy@hotmail.com", "Guapo", "Edwardo", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "EdwardLeCanard@hotmail.com", "Vaneende", "Edward", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "DePijpVanMaarten@gmail.com", "Pijpers", "Maarten", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Satchel@steelpanther.com", "Parrish", "Russ", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "IloveyouTomorrow@hotmail.com", "Demain", "Annie", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Andy123@gmail.com", "Degught", "Andy", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000029"), "CoronaTopper@gmail.com", "Root", "Claude", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Katringring@skynet.be", "Vanbelleghem", "Katleen", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "CharlesDurue@hotmail.com", "Verstraete", "Karel", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "RogerDoeniemee@telenet.be", "Vangenechte", "Roger", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "ErnaVanvoren@hotmail.com", "Vanvoren", "Erna", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Ialwayswin@gmail.com", "Pot", "Jack", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "EchtElkeKant@hotmail.com", "Kant", "Elke", "TimeReg2020" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), "aboynamedsue@JCash.com", "Cash", "Johnny", "TimeReg2020" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000014"), "DeYoeri@gmail.com", "Declerk", "Yoeri", "TimeReg2020" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000030"), "rapgewoon@hotmail.com", "Wenne", "Eve", "TimeReg2020" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Info", "ProjectId", "TaskName", "UploadDate", "WorkTime" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000200"), "Create API Items", new Guid("00000000-0000-0000-0000-000000000100"), "Create API", new DateTime(2018, 10, 14, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 18, 20, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000230"), "Create full working website", new Guid("00000000-0000-0000-0000-000000000111"), "Website", new DateTime(2020, 6, 20, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 41, 20, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000229"), "Fix app issues for customer login page", new Guid("00000000-0000-0000-0000-000000000110"), "app issues", new DateTime(2019, 4, 8, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 35, 41, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000228"), "Create API Items and link to database", new Guid("00000000-0000-0000-0000-000000000110"), "API items", new DateTime(2020, 2, 10, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 24, 6, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000227"), "Fix issues customer portal", new Guid("00000000-0000-0000-0000-000000000109"), "issues customer portal", new DateTime(2019, 11, 10, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 20, 45, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000226"), "Create new page for customer portal", new Guid("00000000-0000-0000-0000-000000000109"), "customer portal", new DateTime(2019, 11, 8, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 19, 8, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000225"), "Create API for database to link with order page", new Guid("00000000-0000-0000-0000-000000000108"), "API orderpage", new DateTime(2019, 11, 6, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 6, 5, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000224"), "Create new order page for customers Europe", new Guid("00000000-0000-0000-0000-000000000108"), "order page", new DateTime(2019, 11, 5, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 8, 42, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000223"), "Fix issue billing page", new Guid("00000000-0000-0000-0000-000000000107"), "issue billing", new DateTime(2020, 10, 16, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 51, 42, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000222"), "Create link order page and new billing page customer and automate proces", new Guid("00000000-0000-0000-0000-000000000107"), "link order page", new DateTime(2020, 10, 15, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 45, 10, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000221"), "Fix issues with order page on website", new Guid("00000000-0000-0000-0000-000000000107"), "order page", new DateTime(2020, 10, 13, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 26, 45, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000220"), "Link API's to new database", new Guid("00000000-0000-0000-0000-000000000106"), "link API's", new DateTime(2020, 7, 13, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 35, 38, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000219"), "Upload data and create database", new Guid("00000000-0000-0000-0000-000000000106"), "upload data", new DateTime(2020, 7, 12, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 47, 8, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000218"), "Upload data and create database", new Guid("00000000-0000-0000-0000-000000000105"), "upload data", new DateTime(2018, 8, 14, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 12, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000217"), "Automate promo's and guid for admin", new Guid("00000000-0000-0000-0000-000000000104"), "promo's", new DateTime(2018, 3, 26, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 1, 35, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000231"), "Create full working website", new Guid("00000000-0000-0000-0000-000000000112"), "Website", new DateTime(2019, 11, 15, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 35, 41, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000216"), "Update al items in database", new Guid("00000000-0000-0000-0000-000000000104"), "update items", new DateTime(2018, 3, 25, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 8, 41, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000214"), "Finish all processes and link to website", new Guid("00000000-0000-0000-0000-000000000103"), "finish automation", new DateTime(2020, 5, 18, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 55, 10, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000213"), "Automate selling process and work with new API's", new Guid("00000000-0000-0000-0000-000000000103"), "automation", new DateTime(2020, 5, 17, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 39, 50, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000212"), "Rebuild itempage website and link new products", new Guid("00000000-0000-0000-0000-000000000103"), "itempage", new DateTime(2020, 5, 15, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 7, 40, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000211"), "Fix issues website selling page", new Guid("00000000-0000-0000-0000-000000000103"), "fix website issues", new DateTime(2020, 5, 13, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 15, 30, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000210"), "Migrate data Electrabel to database", new Guid("00000000-0000-0000-0000-000000000102"), "migrate data", new DateTime(2020, 2, 21, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 41, 30, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000209"), "Upload data for demo", new Guid("00000000-0000-0000-0000-000000000102"), "demodata", new DateTime(2020, 2, 20, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 31, 50, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000208"), "Automate pricing and promo", new Guid("00000000-0000-0000-0000-000000000101"), "automate", new DateTime(2019, 10, 2, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 5, 0, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000207"), "Finish website", new Guid("00000000-0000-0000-0000-000000000101"), "finish website", new DateTime(2019, 9, 23, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 18, 10, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000206"), "Create full working website", new Guid("00000000-0000-0000-0000-000000000101"), "Website", new DateTime(2019, 9, 20, 10, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 44, 30, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000205"), "Create all API's for website", new Guid("00000000-0000-0000-0000-000000000101"), "create API's", new DateTime(2019, 8, 15, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 30, 20, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000204"), "Migrate objects to database", new Guid("00000000-0000-0000-0000-000000000101"), "migrate objects", new DateTime(2019, 8, 14, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 35, 50, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000203"), "Link Item to new API vendor", new Guid("00000000-0000-0000-0000-000000000100"), "API vendor link", new DateTime(2018, 10, 19, 8, 35, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 8, 40, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000202"), "Create new properties Item object", new Guid("00000000-0000-0000-0000-000000000100"), "Create properties", new DateTime(2018, 10, 18, 9, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 28, 30, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000201"), "Fix issues Items API", new Guid("00000000-0000-0000-0000-000000000100"), "API issues", new DateTime(2018, 10, 15, 11, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 19, 28, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000215"), "Create new website and link to database", new Guid("00000000-0000-0000-0000-000000000104"), "create website", new DateTime(2018, 3, 20, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 22, 10, 25, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000232"), "Create full working website", new Guid("00000000-0000-0000-0000-000000000113"), "Website", new DateTime(2018, 10, 10, 8, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 31, 50, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message_ReceiverId",
                table: "Message",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_SenderId",
                table: "Message",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_TaskId",
                table: "Message",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Picture_TaskId",
                table: "Picture",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTasks_TaskId",
                table: "UserTasks",
                column: "TaskId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropTable(
                name: "UserTasks");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
