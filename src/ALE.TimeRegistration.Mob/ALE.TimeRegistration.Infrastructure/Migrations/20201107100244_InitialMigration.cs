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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_Users_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Image = table.Column<string>(nullable: true),
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
                columns: new[] { "Id", "Image", "TaskId" },
                values: new object[,]
                {
                    { new Guid("856b1fd5-44f6-4dd5-96b8-4e6c72b1c0df"), null, new Guid("84985336-8b0f-4fcc-883f-affa41175ef2") },
                    { new Guid("981bb07b-ffb9-4901-ab4d-bf84fa279297"), null, new Guid("84985336-8b0f-4fcc-883f-affa41175ef2") },
                    { new Guid("a6a8c0ef-66ae-4b0a-8dcf-c323db0bab32"), null, new Guid("bdf71f7a-24e4-4332-8f56-650b089fa1f0") },
                    { new Guid("bb7413e9-f087-4550-bc5b-9594f79281c8"), null, new Guid("b5edeb11-3a16-4f1e-8820-94aeb21ba0d7") },
                    { new Guid("70da31cc-8b9e-44fe-9722-c03aa91dee9f"), null, new Guid("3e3a9323-2f38-4e69-80fe-053f5d2f8c35") }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("62600880-5959-40f1-902c-9d9f8accc795"), "bpost" },
                    { new Guid("1ff6ecc8-faa6-4128-bfe2-28a44455fd73"), "Daikin Europe" },
                    { new Guid("b89508f1-2935-44b0-aea3-3282850d3814"), "Allianz Benelux" },
                    { new Guid("11f97681-bb21-4622-a034-c3ef282dc78e"), "Proximus" },
                    { new Guid("998ebe9e-c536-4d27-8592-1056a6515fbe"), "Mastercard Europe" },
                    { new Guid("e641caa7-ab53-42b6-a433-6a1c46ce4f8f"), "ArcelorMittal Belgium" },
                    { new Guid("8aaf9a52-cbc9-41e9-b6d6-56b975b26bb8"), "Volvo Car Belgium" },
                    { new Guid("0b5b0699-2d15-46a5-a60a-9f4dd0f9e8b0"), "AXA Belgium" },
                    { new Guid("8893fc60-83c0-4c1f-ad20-7cd3da784d75"), "BASF Antwerpen" },
                    { new Guid("aa5448a9-6e7b-4561-9203-af1037428da7"), "Total Belgium" },
                    { new Guid("dd8f7a03-9e88-4333-8aa2-0e227a718c40"), "Janssen Pharmaceutica" },
                    { new Guid("557e26b7-e891-476d-9501-b37da557564c"), "Engie Electrabel" },
                    { new Guid("e8a33c03-0ecf-41ef-8ec6-88cf7773564e"), "Colruyt" },
                    { new Guid("c9468ac7-468b-4ad2-ad2f-15f42364481a"), "Toyota Motor" },
                    { new Guid("f8cb37ec-0150-4ee5-ae91-bab50b2c7b55"), "Delhaize De Leeuw" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastName", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("bcb78b11-7487-451f-a781-622b1f594b14"), null, null, null, null },
                    { new Guid("3a601f89-5c5a-456a-80c2-50c337cf9af9"), null, null, null, null },
                    { new Guid("947837ce-ae4b-4f83-88d4-17ef7b0e92f4"), null, null, null, null },
                    { new Guid("9b9e16f8-f9f2-48ac-a0b7-42575a011e85"), null, null, null, null },
                    { new Guid("97ea799b-2366-4896-b334-cde128c11934"), null, null, null, null },
                    { new Guid("e157259c-1324-478c-8e8b-aa7c5672b056"), null, null, null, null },
                    { new Guid("c1a7d6ae-08ba-4860-9537-484ae3459ddc"), null, null, null, null },
                    { new Guid("f8c4bb72-210a-4e30-b24c-4157f1b0f9e2"), null, null, null, null },
                    { new Guid("1fd57179-6a38-43ee-ace3-edbce12f7bb0"), null, null, null, null },
                    { new Guid("33567ab4-f1e7-48a1-b5e8-b3e4eeecd6a4"), null, null, null, null },
                    { new Guid("3e3a9323-2f38-4e69-80fe-053f5d2f8c35"), null, null, null, null },
                    { new Guid("f35ba869-1cb2-426e-be51-bb3a1b173220"), null, null, null, null },
                    { new Guid("d2dbab93-70b7-4ba6-8738-a03c3d1505ee"), null, null, null, null },
                    { new Guid("83ce5bec-f859-4425-bb53-56de4502c2a9"), null, null, null, null },
                    { new Guid("3545b234-ebd1-490f-87be-e2ffaf27f21b"), null, null, null, null },
                    { new Guid("08f00eea-d345-4574-be4e-73f86c56726b"), null, null, null, null },
                    { new Guid("6cfd027b-2af2-4424-8a5d-8235d216f1a8"), null, null, null, null },
                    { new Guid("12e02aac-6a7a-49a9-bf18-6e41ecf4075c"), null, null, null, null },
                    { new Guid("a9d58347-2def-479f-8653-bb765d158308"), null, null, null, null },
                    { new Guid("49745c24-227e-4385-bcba-ed491b62f922"), null, null, null, null },
                    { new Guid("06868a16-f909-4160-9924-982a08287083"), null, null, null, null },
                    { new Guid("bc26bd93-775d-4ac0-aba2-339d0575f8c4"), null, null, null, null },
                    { new Guid("1e5f5b46-21c4-4ce6-a488-c1d9256dccbf"), null, null, null, null },
                    { new Guid("b5edeb11-3a16-4f1e-8820-94aeb21ba0d7"), null, null, null, null },
                    { new Guid("783f92cc-1371-4b1a-9546-ea8286ee3f76"), null, null, null, null },
                    { new Guid("bcec176c-6e42-4d4f-a64b-02b1d3d9388f"), null, null, null, null },
                    { new Guid("60ff61ee-4b99-4903-8b97-946ce65582a1"), null, null, null, null },
                    { new Guid("2e831816-ff96-4d8b-ac00-3a812d043a51"), null, null, null, null },
                    { new Guid("a1b3615f-a8c6-49a2-bb7b-121305615782"), null, null, null, null },
                    { new Guid("bdf71f7a-24e4-4332-8f56-650b089fa1f0"), null, null, null, null },
                    { new Guid("66d7e6a2-404e-4919-b032-abf64cfe691d"), "TomVanmarcke@gmail.com", "Vantomme", "Marc", "TimeReg2020" },
                    { new Guid("131de448-db99-4b95-b14e-66b914db725e"), "rapgewoon@hotmail.com", "Wenne", "Eve", "TimeReg2020" },
                    { new Guid("12ba3def-f041-45dd-bb6c-492749f49d89"), "aboynamedsue@JCash.com", "Cash", "Johnny", "TimeReg2020" },
                    { new Guid("b92e79e5-bde7-4c85-9d85-cbe405b599a9"), "EchtElkeKant@hotmail.com", "Kant", "Elke", "TimeReg2020" },
                    { new Guid("e0146a2e-cbec-42cf-8a3c-cfe63b4743e4"), "Ialwayswin@gmail.com", "Pot", "Jack", "TimeReg2020" },
                    { new Guid("a70ba158-7d24-4996-9729-c04645e4123c"), "ErnaVanvoren@hotmail.com", "Vanvoren", "Erna", "TimeReg2020" },
                    { new Guid("5f439b90-1504-470e-a403-b7d98fe5a819"), "RogerDoeniemee@telenet.be", "Vangenechte", "Roger", "TimeReg2020" },
                    { new Guid("cfe86e67-56e5-4dc6-9ff7-dca5b4b8343f"), "CharlesDurue@hotmail.com", "Verstraete", "Karel", "TimeReg2020" },
                    { new Guid("9764704d-fbc8-4c4f-9e76-998e927d446e"), "Katringring@skynet.be", "Vanbelleghem", "Katleen", "TimeReg2020" },
                    { new Guid("b3b83cb1-2b33-4629-95ea-e2a060f172c1"), "SnelnEddy@hotmail.com", "Guapo", "Edwardo", "TimeReg2020" },
                    { new Guid("bb60dc0a-02dd-4357-9973-9cb54cb837ef"), "Andy123@gmail.com", "Degught", "Andy", "TimeReg2020" },
                    { new Guid("254def70-50a0-40de-a77a-ab2c2591bb89"), "IloveyouTomorrow@hotmail.com", "Demain", "Annie", "TimeReg2020" },
                    { new Guid("f84da3ff-9cc6-49c5-9904-15e431feffe6"), "Satchel@steelpanther.com", "Parrish", "Russ", "TimeReg2020" },
                    { new Guid("87395ea7-a64c-4878-8f09-c55564d4db12"), "DePijpVanMaarten@gmail.com", "Pijpers", "Maarten", "TimeReg2020" },
                    { new Guid("67859443-f004-4779-bfb0-3ad2cfa6a153"), "EdwardLeCanard@hotmail.com", "Vaneende", "Edward", "TimeReg2020" },
                    { new Guid("1e62ec6c-0f76-4a30-b5c5-15690658930f"), "DeYoeri@gmail.com", "Declerk", "Yoeri", "TimeReg2020" },
                    { new Guid("66d7e6a2-404e-4919-b032-abf64cfe691f"), "CalmingCamille@telenet.be", "Thee", "Camille", "TimeReg2020" },
                    { new Guid("00748570-86f3-42c3-a358-8ea38c706cb8"), "Thebestginger@qotsa.com", "Homme", "Josh", "TimeReg2020" },
                    { new Guid("30a49cd6-9144-40f0-816c-4b1d7a0a766a"), "Zwaffelaere@gmail.com", "Uytebroeck", "Piet", "TimeReg2020" },
                    { new Guid("a9ac8612-f8b7-4344-9042-875b1b916e1a"), "SterkeJan33@pandora.be", "Lefort", "Jan", "TimeReg2020" },
                    { new Guid("8bc19dd0-6829-49b6-b084-e742cc6403c0"), "RietjeGessof@hotmail.com", "Gessof", "Rita", "TimeReg2020" },
                    { new Guid("67859443-f004-4779-bfb0-3ad2cfa6a154"), "willywilly@thescabs.be", "Lambregt", "Willy", "TimeReg2020" },
                    { new Guid("1e62ec6c-0f76-4a30-b5c5-15690658930d"), "PescadoLover@skynet.be", "Vervis", "Kelly", "TimeReg2020" },
                    { new Guid("66bc3260-e00c-435d-aa5f-c36a43e315c2"), null, null, null, null },
                    { new Guid("532d63b6-f0e2-42dd-a205-8daa5548562f"), "Loewiloewie@hotmail.com", "Decruy", "Louis", "TimeReg2020" },
                    { new Guid("6cac4bc5-293e-4b8a-836c-04f46a681b2f"), "Giezijtem@skynet.be", "Emnie", "Ben", "TimeReg2020" },
                    { new Guid("0d505c28-9d9a-4252-a212-e8184f1720e0"), "ConnieBeter@gmail.com", "Moeleker", "Connie", "TimeReg2020" },
                    { new Guid("88328685-37dc-45d7-aef0-a7095dbbf9e1"), "GezondePeter@telenet.be", "Celie", "Peter", "TimeReg2020" },
                    { new Guid("2d2168e4-f8ff-4809-a3cb-0cac07d05fb0"), "Bennernie@skynet.be", "Thuys", "Benny", "TimeReg2020" },
                    { new Guid("c3120458-e925-4701-a1c2-f96cd89e8780"), "Thebestbusker@london.com", "Cole", "Cam", "TimeReg2020" },
                    { new Guid("8ce255f7-bb90-4cfa-b088-7a1a9c22b1ef"), "CoronaTopper@gmail.com", "Root", "Claude", "TimeReg2020" },
                    { new Guid("84985336-8b0f-4fcc-883f-affa41175ef2"), null, null, null, null },
                    { new Guid("ffd59629-c4a5-4c88-afd2-ece82607095c"), null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "SenderId", "ReceiverId", "Id", "TaskId", "Text" },
                values: new object[,]
                {
                    { new Guid("e0146a2e-cbec-42cf-8a3c-cfe63b4743e4"), new Guid("8bc19dd0-6829-49b6-b084-e742cc6403c0"), new Guid("a3a43583-c25f-4ca1-9314-aefca950369f"), new Guid("12e02aac-6a7a-49a9-bf18-6e41ecf4075c"), "Please do this asap." },
                    { new Guid("30a49cd6-9144-40f0-816c-4b1d7a0a766a"), new Guid("b92e79e5-bde7-4c85-9d85-cbe405b599a9"), new Guid("17cf3d08-f7fc-414b-97e2-3068f22572d9"), new Guid("08f00eea-d345-4574-be4e-73f86c56726b"), "Can I get more info about the task please?" },
                    { new Guid("c3120458-e925-4701-a1c2-f96cd89e8780"), new Guid("12ba3def-f041-45dd-bb6c-492749f49d89"), new Guid("032fc49c-e8ca-40c4-9940-58bfdeb3712e"), new Guid("49745c24-227e-4385-bcba-ed491b62f922"), "What should I do when I finish?" },
                    { new Guid("66d7e6a2-404e-4919-b032-abf64cfe691d"), new Guid("12ba3def-f041-45dd-bb6c-492749f49d89"), new Guid("2be15cc7-817d-4f64-914d-1b0e87be70db"), new Guid("83ce5bec-f859-4425-bb53-56de4502c2a9"), "Please update your work asap." }
                });

            migrationBuilder.InsertData(
                table: "UserProject",
                columns: new[] { "UserId", "TaskId" },
                values: new object[,]
                {
                    { new Guid("67859443-f004-4779-bfb0-3ad2cfa6a154"), new Guid("f8c4bb72-210a-4e30-b24c-4157f1b0f9e2") },
                    { new Guid("67859443-f004-4779-bfb0-3ad2cfa6a154"), new Guid("bcb78b11-7487-451f-a781-622b1f594b14") },
                    { new Guid("1e62ec6c-0f76-4a30-b5c5-15690658930d"), new Guid("d2dbab93-70b7-4ba6-8738-a03c3d1505ee") },
                    { new Guid("1e62ec6c-0f76-4a30-b5c5-15690658930d"), new Guid("f35ba869-1cb2-426e-be51-bb3a1b173220") },
                    { new Guid("66d7e6a2-404e-4919-b032-abf64cfe691d"), new Guid("e157259c-1324-478c-8e8b-aa7c5672b056") },
                    { new Guid("66d7e6a2-404e-4919-b032-abf64cfe691d"), new Guid("83ce5bec-f859-4425-bb53-56de4502c2a9") },
                    { new Guid("532d63b6-f0e2-42dd-a205-8daa5548562f"), new Guid("97ea799b-2366-4896-b334-cde128c11934") },
                    { new Guid("532d63b6-f0e2-42dd-a205-8daa5548562f"), new Guid("a1b3615f-a8c6-49a2-bb7b-121305615782") },
                    { new Guid("0d505c28-9d9a-4252-a212-e8184f1720e0"), new Guid("947837ce-ae4b-4f83-88d4-17ef7b0e92f4") },
                    { new Guid("0d505c28-9d9a-4252-a212-e8184f1720e0"), new Guid("6cfd027b-2af2-4424-8a5d-8235d216f1a8") },
                    { new Guid("2d2168e4-f8ff-4809-a3cb-0cac07d05fb0"), new Guid("a9d58347-2def-479f-8653-bb765d158308") },
                    { new Guid("c3120458-e925-4701-a1c2-f96cd89e8780"), new Guid("49745c24-227e-4385-bcba-ed491b62f922") },
                    { new Guid("8bc19dd0-6829-49b6-b084-e742cc6403c0"), new Guid("12e02aac-6a7a-49a9-bf18-6e41ecf4075c") },
                    { new Guid("8bc19dd0-6829-49b6-b084-e742cc6403c0"), new Guid("3a601f89-5c5a-456a-80c2-50c337cf9af9") },
                    { new Guid("cfe86e67-56e5-4dc6-9ff7-dca5b4b8343f"), new Guid("84985336-8b0f-4fcc-883f-affa41175ef2") },
                    { new Guid("30a49cd6-9144-40f0-816c-4b1d7a0a766a"), new Guid("08f00eea-d345-4574-be4e-73f86c56726b") },
                    { new Guid("cfe86e67-56e5-4dc6-9ff7-dca5b4b8343f"), new Guid("1e5f5b46-21c4-4ce6-a488-c1d9256dccbf") },
                    { new Guid("cfe86e67-56e5-4dc6-9ff7-dca5b4b8343f"), new Guid("3545b234-ebd1-490f-87be-e2ffaf27f21b") },
                    { new Guid("9764704d-fbc8-4c4f-9e76-998e927d446e"), new Guid("bdf71f7a-24e4-4332-8f56-650b089fa1f0") },
                    { new Guid("9764704d-fbc8-4c4f-9e76-998e927d446e"), new Guid("783f92cc-1371-4b1a-9546-ea8286ee3f76") },
                    { new Guid("9764704d-fbc8-4c4f-9e76-998e927d446e"), new Guid("bcec176c-6e42-4d4f-a64b-02b1d3d9388f") },
                    { new Guid("9764704d-fbc8-4c4f-9e76-998e927d446e"), new Guid("60ff61ee-4b99-4903-8b97-946ce65582a1") },
                    { new Guid("b3b83cb1-2b33-4629-95ea-e2a060f172c1"), new Guid("b5edeb11-3a16-4f1e-8820-94aeb21ba0d7") },
                    { new Guid("b3b83cb1-2b33-4629-95ea-e2a060f172c1"), new Guid("2e831816-ff96-4d8b-ac00-3a812d043a51") },
                    { new Guid("b3b83cb1-2b33-4629-95ea-e2a060f172c1"), new Guid("66bc3260-e00c-435d-aa5f-c36a43e315c2") },
                    { new Guid("b3b83cb1-2b33-4629-95ea-e2a060f172c1"), new Guid("ffd59629-c4a5-4c88-afd2-ece82607095c") },
                    { new Guid("bb60dc0a-02dd-4357-9973-9cb54cb837ef"), new Guid("3e3a9323-2f38-4e69-80fe-053f5d2f8c35") },
                    { new Guid("254def70-50a0-40de-a77a-ab2c2591bb89"), new Guid("33567ab4-f1e7-48a1-b5e8-b3e4eeecd6a4") },
                    { new Guid("f84da3ff-9cc6-49c5-9904-15e431feffe6"), new Guid("1fd57179-6a38-43ee-ace3-edbce12f7bb0") },
                    { new Guid("87395ea7-a64c-4878-8f09-c55564d4db12"), new Guid("c1a7d6ae-08ba-4860-9537-484ae3459ddc") },
                    { new Guid("30a49cd6-9144-40f0-816c-4b1d7a0a766a"), new Guid("9b9e16f8-f9f2-48ac-a0b7-42575a011e85") },
                    { new Guid("8ce255f7-bb90-4cfa-b088-7a1a9c22b1ef"), new Guid("06868a16-f909-4160-9924-982a08287083") },
                    { new Guid("131de448-db99-4b95-b14e-66b914db725e"), new Guid("bc26bd93-775d-4ac0-aba2-339d0575f8c4") }
                });

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
