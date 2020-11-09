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
                    SenderId = table.Column<Guid>(nullable: false),
                    ReceiverId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    TaskId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => new { x.SenderId, x.ReceiverId });
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
                name: "UserProject",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    TaskId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProject", x => new { x.UserId, x.TaskId });
                    table.ForeignKey(
                        name: "FK_UserProject_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProject_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "TaskId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("84985336-8b0f-4fcc-883f-affa41175ef2") });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c9468ac7-468b-4ad2-ad2f-15f42364481a"), "Toyota Motor" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("a9ac8612-f8b7-4344-9042-875b1b916e1a"), "SterkeJan33@pandora.be", "Lefort", "Jan", "TimeReg2020" },
                    { new Guid("8bc19dd0-6829-49b6-b084-e742cc6403c0"), "RietjeGessof@hotmail.com", "Gessof", "Rita", "TimeReg2020" },
                    { new Guid("67859443-f004-4779-bfb0-3ad2cfa6a154"), "willywilly@thescabs.be", "Lambregt", "Willy", "TimeReg2020" },
                    { new Guid("1e62ec6c-0f76-4a30-b5c5-15690658930d"), "PescadoLover@skynet.be", "Vervis", "Kelly", "TimeReg2020" },
                    { new Guid("66d7e6a2-404e-4919-b032-abf64cfe691d"), "TomVanmarcke@gmail.com", "Vantomme", "Marc", "TimeReg2020" },
                    { new Guid("532d63b6-f0e2-42dd-a205-8daa5548562f"), "Loewiloewie@hotmail.com", "Decruy", "Louis", "TimeReg2020" },
                    { new Guid("6cac4bc5-293e-4b8a-836c-04f46a681b2f"), "Giezijtem@skynet.be", "Emnie", "Ben", "TimeReg2020" },
                    { new Guid("0d505c28-9d9a-4252-a212-e8184f1720e0"), "ConnieBeter@gmail.com", "Moeleker", "Connie", "TimeReg2020" },
                    { new Guid("88328685-37dc-45d7-aef0-a7095dbbf9e1"), "GezondePeter@telenet.be", "Celie", "Peter", "TimeReg2020" },
                    { new Guid("2d2168e4-f8ff-4809-a3cb-0cac07d05fb0"), "Bennernie@skynet.be", "Thuys", "Benny", "TimeReg2020" },
                    { new Guid("c3120458-e925-4701-a1c2-f96cd89e8780"), "Thebestbusker@london.com", "Cole", "Cam", "TimeReg2020" },
                    { new Guid("8ce255f7-bb90-4cfa-b088-7a1a9c22b1ef"), "CoronaTopper@gmail.com", "Root", "Claude", "TimeReg2020" },
                    { new Guid("131de448-db99-4b95-b14e-66b914db725e"), "rapgewoon@hotmail.com", "Wenne", "Eve", "TimeReg2020" },
                    { new Guid("30a49cd6-9144-40f0-816c-4b1d7a0a766a"), "Zwaffelaere@gmail.com", "Uytebroeck", "Piet", "TimeReg2020" },
                    { new Guid("00748570-86f3-42c3-a358-8ea38c706cb8"), "Thebestginger@qotsa.com", "Homme", "Josh", "TimeReg2020" },
                    { new Guid("66d7e6a2-404e-4919-b032-abf64cfe691f"), "CalmingCamille@telenet.be", "Thee", "Camille", "TimeReg2020" },
                    { new Guid("1e62ec6c-0f76-4a30-b5c5-15690658930f"), "DeYoeri@gmail.com", "Declerk", "Yoeri", "TimeReg2020" },
                    { new Guid("67859443-f004-4779-bfb0-3ad2cfa6a153"), "EdwardLeCanard@hotmail.com", "Vaneende", "Edward", "TimeReg2020" },
                    { new Guid("87395ea7-a64c-4878-8f09-c55564d4db12"), "DePijpVanMaarten@gmail.com", "Pijpers", "Maarten", "TimeReg2020" },
                    { new Guid("f84da3ff-9cc6-49c5-9904-15e431feffe6"), "Satchel@steelpanther.com", "Parrish", "Russ", "TimeReg2020" },
                    { new Guid("254def70-50a0-40de-a77a-ab2c2591bb89"), "IloveyouTomorrow@hotmail.com", "Demain", "Annie", "TimeReg2020" },
                    { new Guid("bb60dc0a-02dd-4357-9973-9cb54cb837ef"), "Andy123@gmail.com", "Degught", "Andy", "TimeReg2020" },
                    { new Guid("b3b83cb1-2b33-4629-95ea-e2a060f172c1"), "SnelnEddy@hotmail.com", "Guapo", "Edwardo", "TimeReg2020" },
                    { new Guid("9764704d-fbc8-4c4f-9e76-998e927d446e"), "Katringring@skynet.be", "Vanbelleghem", "Katleen", "TimeReg2020" },
                    { new Guid("cfe86e67-56e5-4dc6-9ff7-dca5b4b8343f"), "CharlesDurue@hotmail.com", "Verstraete", "Karel", "TimeReg2020" },
                    { new Guid("5f439b90-1504-470e-a403-b7d98fe5a819"), "RogerDoeniemee@telenet.be", "Vangenechte", "Roger", "TimeReg2020" },
                    { new Guid("a70ba158-7d24-4996-9729-c04645e4123c"), "ErnaVanvoren@hotmail.com", "Vanvoren", "Erna", "TimeReg2020" },
                    { new Guid("e0146a2e-cbec-42cf-8a3c-cfe63b4743e4"), "Ialwayswin@gmail.com", "Pot", "Jack", "TimeReg2020" },
                    { new Guid("b92e79e5-bde7-4c85-9d85-cbe405b599a9"), "EchtElkeKant@hotmail.com", "Kant", "Elke", "TimeReg2020" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "aboynamedsue@JCash.com", "Cash", "Johnny", "TimeReg2020" },
                    { new Guid("84985336-8b0f-4fcc-883f-affa41175ef2"), null, null, null, null },
                    { new Guid("83ce5bec-f859-4425-bb53-56de4502c2a9"), null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "SenderId", "ReceiverId", "Id", "TaskId", "Text" },
                values: new object[] { new Guid("b92e79e5-bde7-4c85-9d85-cbe405b599a9"), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000060"), new Guid("83ce5bec-f859-4425-bb53-56de4502c2a9"), "Please update your work asap." });

            migrationBuilder.InsertData(
                table: "UserProject",
                columns: new[] { "UserId", "TaskId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("84985336-8b0f-4fcc-883f-affa41175ef2") });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

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
                name: "IX_UserProject_TaskId",
                table: "UserProject",
                column: "TaskId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "UserProject");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
