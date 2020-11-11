using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TaskName = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true),
                    WorkTime = table.Column<TimeSpan>(nullable: false),
                    UploadDate = table.Column<DateTime>(nullable: false),
                    ProjectId = table.Column<Guid>(nullable: false)
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
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    TaskId = table.Column<Guid>(nullable: false),
                    SenderId = table.Column<Guid>(nullable: false),
                    ReceiverId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Users_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TaskId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pictures_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTasks",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    TaskId = table.Column<Guid>(nullable: false)
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
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "aboynamedsue@JCash.com", "Cash", "Johnny", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000028"), "Thebestbusker@london.com", "Cole", "Cam", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000027"), "Bennernie@skynet.be", "Thuys", "Benny", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "GezondePeter@telenet.be", "Celie", "Peter", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "ConnieBeter@gmail.com", "Moeleker", "Connie", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "Giezijtem@skynet.be", "Emnie", "Ben", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "Loewiloewie@hotmail.com", "Decruy", "Louis", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "TomVanmarcke@gmail.com", "Vantomme", "Marc", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "PescadoLover@skynet.be", "Vervis", "Kelly", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "willywilly@thescabs.be", "Lambregt", "Willy", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "RietjeGessof@hotmail.com", "Gessof", "Rita", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "SterkeJan33@pandora.be", "Lefort", "Jan", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "Zwaffelaere@gmail.com", "Uytebroeck", "Piet", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "Thebestginger@qotsa.com", "Homme", "Josh", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "CalmingCamille@telenet.be", "Thee", "Camille", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "DeYoeri@gmail.com", "Declerk", "Yoeri", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "EdwardLeCanard@hotmail.com", "Vaneende", "Edward", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "DePijpVanMaarten@gmail.com", "Pijpers", "Maarten", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Satchel@steelpanther.com", "Parrish", "Russ", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "IloveyouTomorrow@hotmail.com", "Demain", "Annie", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Andy123@gmail.com", "Degught", "Andy", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "SnelnEddy@hotmail.com", "Guapo", "Edwardo", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Katringring@skynet.be", "Vanbelleghem", "Katleen", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "CharlesDurue@hotmail.com", "Verstraete", "Karel", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "RogerDoeniemee@telenet.be", "Vangenechte", "Roger", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "ErnaVanvoren@hotmail.com", "Vanvoren", "Erna", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Ialwayswin@gmail.com", "Pot", "Jack", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "EchtElkeKant@hotmail.com", "Kant", "Elke", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000029"), "CoronaTopper@gmail.com", "Root", "Claude", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000030"), "rapgewoon@hotmail.com", "Wenne", "Eve", "TimeReg2020" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_TaskId",
                table: "Messages",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_TaskId",
                table: "Pictures",
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
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Pictures");

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
