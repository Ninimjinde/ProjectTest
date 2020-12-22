using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class AddEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TaskName = table.Column<string>(nullable: false),
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
                    Text = table.Column<string>(nullable: false),
                    TaskId = table.Column<Guid>(nullable: false),
                    SenderId = table.Column<string>(nullable: false),
                    ReceiverId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
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
                    UserId = table.Column<string>(nullable: false),
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
                        name: "FK_UserTasks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000008", 0, "8ca63a80-4212-413b-98a2-3d0e1b334b9a", "SnelnEddy@hotmail.com", false, "Guapo", false, null, "Edwardo", null, null, "TimeReg2020", null, null, false, "4ddd4441-a1f9-4707-98ef-b74ef5b28190", false, null },
                    { "00000000-0000-0000-0000-000000000010", 0, "3bb281b6-8da9-4d2f-8507-90c50144ed84", "IloveyouTomorrow@hotmail.com", false, "Demain", false, null, "Annie", null, null, "TimeReg2020", null, null, false, "739a2083-6df1-42ac-ad8c-b3628a6f340c", false, null },
                    { "00000000-0000-0000-0000-000000000011", 0, "6daa98a0-ca92-45ae-a24d-bc661f8ae5d9", "Satchel@steelpanther.com", false, "Parrish", false, null, "Russ", null, null, "TimeReg2020", null, null, false, "506eeb49-6813-4929-a27d-6adf86def9d3", false, null },
                    { "00000000-0000-0000-0000-000000000012", 0, "07002654-8119-4818-8080-6f9cd9d11f1d", "DePijpVanMaarten@gmail.com", false, "Pijpers", false, null, "Maarten", null, null, "TimeReg2020", null, null, false, "6110d4ca-ed04-4b96-aa32-23051df5aa33", false, null },
                    { "00000000-0000-0000-0000-000000000013", 0, "939860e6-7163-46b5-ba7c-b9d19faa87f3", "EdwardLeCanard@hotmail.com", false, "Vaneende", false, null, "Edward", null, null, "TimeReg2020", null, null, false, "e743937f-83ae-483a-a621-52c363cd8869", false, null },
                    { "00000000-0000-0000-0000-000000000014", 0, "daa56554-650b-400e-a734-6753a2a25ea6", "DeYoeri@gmail.com", false, "Declerk", false, null, "Yoeri", null, null, "TimeReg2020", null, null, false, "d01f7d66-ec4d-4719-9e93-e8daedc3cf01", false, null },
                    { "00000000-0000-0000-0000-000000000015", 0, "4b496f56-eea6-4272-8a42-3a58f5a6e9ff", "CalmingCamille@telenet.be", false, "Thee", false, null, "Camille", null, null, "TimeReg2020", null, null, false, "47efeea8-3986-4daf-8de5-1546f43e8ac4", false, null },
                    { "00000000-0000-0000-0000-000000000016", 0, "39718872-e197-4313-9d83-3f2e8707302d", "Thebestginger@qotsa.com", false, "Homme", false, null, "Josh", null, null, "TimeReg2020", null, null, false, "2f57180f-46be-4482-b325-eb3c5312bcf8", false, null },
                    { "00000000-0000-0000-0000-000000000017", 0, "e2ebf7cf-36c0-44ac-8e2c-92312156d1d5", "Zwaffelaere@gmail.com", false, "Uytebroeck", false, null, "Piet", null, null, "TimeReg2020", null, null, false, "cafc5b6d-78c6-4abc-abbf-55d809ef740b", false, null },
                    { "00000000-0000-0000-0000-000000000018", 0, "f43ec0fc-7fd2-4e86-b7a4-22529740db43", "SterkeJan33@pandora.be", false, "Lefort", false, null, "Jan", null, null, "TimeReg2020", null, null, false, "d28712a3-74cc-4eeb-8d38-0e819089f0f5", false, null },
                    { "00000000-0000-0000-0000-000000000019", 0, "92b22664-ca95-472b-975a-bdec4dc8cb96", "RietjeGessof@hotmail.com", false, "Gessof", false, null, "Rita", null, null, "TimeReg2020", null, null, false, "566ed7cf-6a35-406f-afbd-8539d4d62187", false, null },
                    { "00000000-0000-0000-0000-000000000020", 0, "6b7d43a3-bc72-4c7d-8694-d3f9ea1dac45", "willywilly@thescabs.be", false, "Lambregt", false, null, "Willy", null, null, "TimeReg2020", null, null, false, "4c9a2b7c-9a82-44f4-b18e-08196395c691", false, null },
                    { "00000000-0000-0000-0000-000000000021", 0, "e1547275-dd88-41d6-a7f5-0df0cfd351e0", "PescadoLover@skynet.be", false, "Vervis", false, null, "Kelly", null, null, "TimeReg2020", null, null, false, "90fe5367-adb0-4b91-954c-ac448924a234", false, null },
                    { "00000000-0000-0000-0000-000000000022", 0, "57d2a237-d333-4b3e-9f07-2c98a1044bc1", "TomVanmarcke@gmail.com", false, "Vantomme", false, null, "Marc", null, null, "TimeReg2020", null, null, false, "2519a553-9182-496a-96c9-454c816ce427", false, null },
                    { "00000000-0000-0000-0000-000000000023", 0, "dc9fb322-201b-40ea-af21-e450feeda94f", "Loewiloewie@hotmail.com", false, "Decruy", false, null, "Louis", null, null, "TimeReg2020", null, null, false, "b4ac387d-b190-46f2-b24b-7845c27e2756", false, null },
                    { "00000000-0000-0000-0000-000000000024", 0, "003b56e3-8d5a-449b-b32e-5017b522f1c0", "Giezijtem@skynet.be", false, "Emnie", false, null, "Ben", null, null, "TimeReg2020", null, null, false, "3d972679-da8b-43ec-b3b7-29fa17e07f4e", false, null },
                    { "00000000-0000-0000-0000-000000000025", 0, "64bec3c7-2d7e-4927-864e-7435bf7af49e", "ConnieBeter@gmail.com", false, "Moeleker", false, null, "Connie", null, null, "TimeReg2020", null, null, false, "0c586ef0-cbb4-4735-a86e-1324fa8d98ef", false, null },
                    { "00000000-0000-0000-0000-000000000026", 0, "2105ea36-3416-4574-b327-76f948065dc6", "GezondePeter@telenet.be", false, "Celie", false, null, "Peter", null, null, "TimeReg2020", null, null, false, "65343b0f-6074-4f8c-b8df-73a661562cb6", false, null },
                    { "00000000-0000-0000-0000-000000000027", 0, "f64c636b-99a1-4699-a32c-066d9c903884", "Bennernie@skynet.be", false, "Thuys", false, null, "Benny", null, null, "TimeReg2020", null, null, false, "a08331bf-7587-488f-8982-a5e891d0854e", false, null },
                    { "00000000-0000-0000-0000-000000000028", 0, "b8731784-c915-41db-88f8-546917f1140b", "Thebestbusker@london.com", false, "Cole", false, null, "Cam", null, null, "TimeReg2020", null, null, false, "57200627-a1cc-4683-b139-27f397d0aa56", false, null },
                    { "00000000-0000-0000-0000-000000000009", 0, "97cc35a9-fdeb-4e13-a82e-43ef3c78a582", "Andy123@gmail.com", false, "Degught", false, null, "Andy", null, null, "TimeReg2020", null, null, false, "08981b36-deac-422b-9224-09c4d97e4835", false, null },
                    { "00000000-0000-0000-0000-000000000029", 0, "9a72b148-44c6-45f4-b5b3-df515ac50f54", "CoronaTopper@gmail.com", false, "Root", false, null, "Claude", null, null, "TimeReg2020", null, null, false, "a1fe242b-06b4-4a6c-9796-07c2aea4581b", false, null },
                    { "00000000-0000-0000-0000-000000000030", 0, "b5e4dd5c-b543-428e-8098-9d39026c54fd", "rapgewoon@hotmail.com", false, "Wenne", false, null, "Eve", null, null, "TimeReg2020", null, null, false, "13ac17bf-1b97-4956-a8a0-fd5d641576b3", false, null },
                    { "00000000-0000-0000-0000-000000000006", 0, "5c0416a5-b190-4e57-92e9-c211d0235f54", "CharlesDurue@hotmail.com", false, "Verstraete", false, null, "Karel", null, null, "TimeReg2020", null, null, false, "69af7683-af34-406a-b5b4-9fa28d5085fa", false, null },
                    { "00000000-0000-0000-0000-000000000005", 0, "c50bd3e5-a65b-4a3a-8cb9-8a986ac09fad", "RogerDoeniemee@telenet.be", false, "Vangenechte", false, null, "Roger", null, null, "TimeReg2020", null, null, false, "6f560637-d19c-48d0-8efe-136c8741254c", false, null },
                    { "00000000-0000-0000-0000-000000000004", 0, "7935e405-b59b-4740-beb3-9379b962ae23", "ErnaVanvoren@hotmail.com", false, "Vanvoren", false, null, "Erna", null, null, "TimeReg2020", null, null, false, "7683ed26-1b1f-4844-89cd-175f2ff89b57", false, null },
                    { "00000000-0000-0000-0000-000000000003", 0, "53f7a6c5-9d37-4642-9271-3ff35d18ef48", "Ialwayswin@gmail.com", false, "Pot", false, null, "Jack", null, null, "TimeReg2020", null, null, false, "d1928128-4d0d-43c2-b2d3-9079c2b66ebe", false, null },
                    { "00000000-0000-0000-0000-000000000002", 0, "15b1f9e8-3362-4541-a0d7-f52ac2fa7491", "EchtElkeKant@hotmail.com", false, "Kant", false, null, "Elke", null, null, "TimeReg2020", null, null, false, "dc1b69c3-38c6-4595-bbdd-dcd4cc6503c7", false, null },
                    { "00000000-0000-0000-0000-000000000001", 0, "857c4624-941c-4127-ae74-1b67670b3792", "aboynamedsue@JCash.com", false, "Cash", false, null, "Johnny", null, null, "TimeReg2020", null, null, false, "8385a882-1c3a-40b2-b201-5b2717fd7b76", false, null },
                    { "00000000-0000-0000-0000-000000000007", 0, "ccfb8273-f578-4d24-bedb-d0c464235ed0", "Katringring@skynet.be", false, "Vanbelleghem", false, null, "Katleen", null, null, "TimeReg2020", null, null, false, "9a92d0f0-0b84-4f56-9dbd-27730fb09dc8", false, null }
                });

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
                    { new Guid("00000000-0000-0000-0000-000000000110"), "Proximus" },
                    { new Guid("00000000-0000-0000-0000-000000000108"), "ArcelorMittal Belgium" },
                    { new Guid("00000000-0000-0000-0000-000000000109"), "Mastercard Europe" },
                    { new Guid("00000000-0000-0000-0000-000000000111"), "AXA Belgium" },
                    { new Guid("00000000-0000-0000-0000-000000000112"), "Allianz Benelux" },
                    { new Guid("00000000-0000-0000-0000-000000000113"), "Daikin Europe" },
                    { new Guid("00000000-0000-0000-0000-000000000114"), "bpost" },
                    { new Guid("00000000-0000-0000-0000-000000000107"), "Volvo Car Belgium" },
                    { new Guid("00000000-0000-0000-0000-000000000100"), "Toyota Motor" }
                });

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

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ReceiverId", "SenderId", "TaskId", "Text" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000400"), "00000000-0000-0000-0000-000000000006", "00000000-0000-0000-0000-000000000001", new Guid("00000000-0000-0000-0000-000000000200"), "Please update your work asap." },
                    { new Guid("00000000-0000-0000-0000-000000000403"), "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000006", new Guid("00000000-0000-0000-0000-000000000200"), "What should I do when I finish?" },
                    { new Guid("00000000-0000-0000-0000-000000000402"), "00000000-0000-0000-0000-000000000007", "00000000-0000-0000-0000-000000000002", new Guid("00000000-0000-0000-0000-000000000202"), "Please do this asap." },
                    { new Guid("00000000-0000-0000-0000-000000000401"), "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000006", new Guid("00000000-0000-0000-0000-000000000201"), "Can I get more info about the task please?" }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "TaskId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000303"), new Guid("00000000-0000-0000-0000-000000000202") },
                    { new Guid("00000000-0000-0000-0000-000000000302"), new Guid("00000000-0000-0000-0000-000000000201") },
                    { new Guid("00000000-0000-0000-0000-000000000304"), new Guid("00000000-0000-0000-0000-000000000203") },
                    { new Guid("00000000-0000-0000-0000-000000000300"), new Guid("00000000-0000-0000-0000-000000000200") },
                    { new Guid("00000000-0000-0000-0000-000000000301"), new Guid("00000000-0000-0000-0000-000000000201") }
                });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "UserId", "TaskId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000029", new Guid("00000000-0000-0000-0000-000000000229") },
                    { "00000000-0000-0000-0000-000000000021", new Guid("00000000-0000-0000-0000-000000000217") },
                    { "00000000-0000-0000-0000-000000000022", new Guid("00000000-0000-0000-0000-000000000218") },
                    { "00000000-0000-0000-0000-000000000023", new Guid("00000000-0000-0000-0000-000000000219") },
                    { "00000000-0000-0000-0000-000000000024", new Guid("00000000-0000-0000-0000-000000000220") },
                    { "00000000-0000-0000-0000-000000000024", new Guid("00000000-0000-0000-0000-000000000221") },
                    { "00000000-0000-0000-0000-000000000025", new Guid("00000000-0000-0000-0000-000000000223") },
                    { "00000000-0000-0000-0000-000000000017", new Guid("00000000-0000-0000-0000-000000000224") },
                    { "00000000-0000-0000-0000-000000000026", new Guid("00000000-0000-0000-0000-000000000226") },
                    { "00000000-0000-0000-0000-000000000027", new Guid("00000000-0000-0000-0000-000000000227") },
                    { "00000000-0000-0000-0000-000000000021", new Guid("00000000-0000-0000-0000-000000000216") },
                    { "00000000-0000-0000-0000-000000000028", new Guid("00000000-0000-0000-0000-000000000228") },
                    { "00000000-0000-0000-0000-000000000030", new Guid("00000000-0000-0000-0000-000000000230") },
                    { "00000000-0000-0000-0000-000000000025", new Guid("00000000-0000-0000-0000-000000000225") },
                    { "00000000-0000-0000-0000-000000000021", new Guid("00000000-0000-0000-0000-000000000215") },
                    { "00000000-0000-0000-0000-000000000016", new Guid("00000000-0000-0000-0000-000000000211") },
                    { "00000000-0000-0000-0000-000000000020", new Guid("00000000-0000-0000-0000-000000000213") },
                    { "00000000-0000-0000-0000-000000000017", new Guid("00000000-0000-0000-0000-000000000212") },
                    { "00000000-0000-0000-0000-000000000015", new Guid("00000000-0000-0000-0000-000000000231") },
                    { "00000000-0000-0000-0000-000000000015", new Guid("00000000-0000-0000-0000-000000000210") },
                    { "00000000-0000-0000-0000-000000000011", new Guid("00000000-0000-0000-0000-000000000209") },
                    { "00000000-0000-0000-0000-000000000011", new Guid("00000000-0000-0000-0000-000000000208") },
                    { "00000000-0000-0000-0000-000000000011", new Guid("00000000-0000-0000-0000-000000000207") },
                    { "00000000-0000-0000-0000-000000000010", new Guid("00000000-0000-0000-0000-000000000206") },
                    { "00000000-0000-0000-0000-000000000009", new Guid("00000000-0000-0000-0000-000000000205") },
                    { "00000000-0000-0000-0000-000000000008", new Guid("00000000-0000-0000-0000-000000000204") },
                    { "00000000-0000-0000-0000-000000000008", new Guid("00000000-0000-0000-0000-000000000203") },
                    { "00000000-0000-0000-0000-000000000007", new Guid("00000000-0000-0000-0000-000000000202") },
                    { "00000000-0000-0000-0000-000000000006", new Guid("00000000-0000-0000-0000-000000000201") },
                    { "00000000-0000-0000-0000-000000000006", new Guid("00000000-0000-0000-0000-000000000200") },
                    { "00000000-0000-0000-0000-000000000020", new Guid("00000000-0000-0000-0000-000000000214") },
                    { "00000000-0000-0000-0000-000000000030", new Guid("00000000-0000-0000-0000-000000000232") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "UserTasks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
