using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class AddUsers : Migration
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
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    TaskId = table.Column<Guid>(nullable: false),
                    WorkTime = table.Column<TimeSpan>(nullable: false),
                    WorkDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTasks", x => x.Id);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", "211459f2-edec-4c10-b876-db6d89bca2f7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000029", 0, "50d8c368-d7f1-4e3f-8216-6ba5c5e3e76a", "CoronaTopper@gmail.com", true, "Root", false, null, "Claude", "CORONATOPPER@GMAIL.COM", "CORONATOPPER@GMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEFfG1lX4Pbhpd3k8TukVQJSBSlzZLAjv0gFo7dMKnG529oCNjiDz6rZP1jfArdC3uQ==", null, false, "W7IEDSQT3GEVZWUOTXG8CL1PI3K6MXU7", false, "CoronaTopper@gmail.com" },
                    { "00000000-0000-0000-0000-000000000028", 0, "b017e971-0a03-4aa0-86e5-b3d1c603d64b", "Thebestbusker@london.com", true, "Cole", false, null, "Cam", "THEBESTBUSKER@LONDON.COM", "THEBESTBUSKER@LONDON.COM", "TimeReg2020", "AQAAAAEAACcQAAAAENPIRKxyuNU2grH4C07Sd1Cw43Dvxd2pKFQbEKvMG/fKlHQgF5VYGMgdSEL/RQp7EA==", null, false, "VRVLNRMUMHA6IADTQ7CO9VCIMVX4OMO5", false, "Thebestbusker@london.com" },
                    { "00000000-0000-0000-0000-000000000027", 0, "1993d307-e257-4e29-8487-b230037199aa", "Bennernie@skynet.be", true, "Thuys", false, null, "Benny", "BENNERNIE@SKYNET.BE", "BENNERNIE@SKYNET.BE", "TimeReg2020", "AQAAAAEAACcQAAAAEKkL6y4DvSrptMEd51RhUWWcN+a/Dw1w0AYgx3QM18h90l03ZWGYKeNuyQNqK0PJdg==", null, false, "KXW8TS8VIEG0BL1OIA7U2PASSALDXMV3", false, "Bennernie@skynet.be" },
                    { "00000000-0000-0000-0000-000000000026", 0, "bc117b43-d867-4f86-8ac4-8d4efc2820c4", "GezondePeter@telenet.be", true, "Celie", false, null, "Peter", "GEZONDEPETER@TELENET.BE", "GEZONDEPETER@TELENET.BE", "TimeReg2020", "AQAAAAEAACcQAAAAENcIS7Bxp8FRjru7eYmge6e2kascpAx0MRr7Br6TUExuY/4qfBjP1srKBaa2sJhvdg==", null, false, "TJLKW00301EENWVWL2MCPLTCU18IT7XY", false, "GezondePeter@telenet.be" },
                    { "00000000-0000-0000-0000-000000000025", 0, "018aba24-a96f-44e9-a058-a047d0bd0b53", "ConnieBeter@gmail.com", true, "Moeleker", false, null, "Connie", "CONNIEBETER@GMAIL.COM", "CONNIEBETER@GMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEKZLKpoa0UOm3zOZNtoNiAlFLm/DfnSFLNwlVGKJ3T8EbKJswDBlISDGfaPj4YgIng==", null, false, "FWM36IDUG00055IF56RZWA2CR9OYCVB3", false, "ConnieBeter@gmail.com" },
                    { "00000000-0000-0000-0000-000000000024", 0, "b52a849c-4b01-4dda-ac2f-30f6b08fe075", "Giezijtem@skynet.be", true, "Emnie", false, null, "Ben", "GIEZIJTEM@SKYNET.BE", "GIEZIJTEM@SKYNET.BE", "TimeReg2020", "AQAAAAEAACcQAAAAECH+m8I8KMFPi2IjxiSnyx8fZvDt0VNul+aoixdPiPhRPQ3Sc5p1ZWIeO0bWe0qNIg==", null, false, "PHLIIUHLZLGB2UTDD2LHUFROZ7TDQAD7", false, "Giezijtem@skynet.be" },
                    { "00000000-0000-0000-0000-000000000023", 0, "8f42511c-f74f-442c-a8f2-28b10d2bc114", "Loewiloewie@hotmail.com", true, "Decruy", false, null, "Louis", "LOEWILOEWIE@HOTMAIL.COM", "LOEWILOEWIE@HOTMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEKiyo1MTjIGA0VwvBi3kisKkJSsjZo0hZRb3N+t/VW9ikNh8PU6xZvyt67OAL//ilA==", null, false, "F0SRUYTP4OF6TSFD3CNJBX5ECAJFPPFZ", false, "Loewiloewie@hotmail.com" },
                    { "00000000-0000-0000-0000-000000000022", 0, "0fc3e5d4-f6ce-4160-aa94-d2acc0be114d", "TomVanmarcke@gmail.com", true, "Vantomme", false, null, "Marc", "TOMVANMARCKE@GMAIL.COM", "TOMVANMARCKE@GMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEEUaZYCjqqvb87gaqZqG/6hvL+BinqCOF+cPKx/I+mvIEUXvMgzYILSKmPvjUsuM2Q==", null, false, "OIKDBFPAR5GJKJ91OUAOXNKR1CMLSTFC", false, "TomVanmarcke@gmail.com" },
                    { "00000000-0000-0000-0000-000000000021", 0, "d7280862-2341-462a-8fb5-1380edea1422", "PescadoLover@skynet.be", true, "Vervis", false, null, "Kelly", "PESCADOLOVER@SKYNET.BE", "PESCADOLOVER@SKYNET.BE", "TimeReg2020", "AQAAAAEAACcQAAAAEFoQiv89L4IMGVAqUm3NCe30KCVyQz+mZWWc+3g0HI8b0PRRlIT6mw+6xecmI3iUQw==", null, false, "WGLZXEZUI3NLP8ZWUYK5CFN8XWBT7ATX", false, "PescadoLover@skynet.be" },
                    { "00000000-0000-0000-0000-000000000020", 0, "86d42357-8dbc-48c9-886d-3a1b957f2075", "willywilly@thescabs.be", true, "Lambregt", false, null, "Willy", "WILLYWILLY@THESCABS.BE", "WILLYWILLY@THESCABS.BE", "TimeReg2020", "AQAAAAEAACcQAAAAEO2h+/svyq64E6PaXqGZ+bPjyCftqHT7S4I7vnwegZClCUTALoTqJHfL/AxdoqMLXw==", null, false, "7F7LSOHNMOKGFGQVMMGOX3SHM3PBNHQB", false, "willywilly@thescabs.be" },
                    { "00000000-0000-0000-0000-000000000019", 0, "b9e1dbac-e651-482a-98a4-8e24583f29c0", "RietjeGessof@hotmail.com", true, "Gessof", false, null, "Rita", "RIETJEGESSOF@HOTMAIL.COM", "RIETJEGESSOF@HOTMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEDSuydX6YapKJk1/8WagypIt/xLOFZYYJdDKRnvA021IZzUctfLBcFqxl6CmfYmnBQ==", null, false, "9H2QG7IPOUORADDNMF2ISIRSOGZJNXGZ", false, "RietjeGessof@hotmail.com" },
                    { "00000000-0000-0000-0000-000000000018", 0, "a1000963-395c-4507-83df-8f4b9e784db1", "SterkeJan33@pandora.be", true, "Lefort", false, null, "Jan", "STERKEJAN33@PANDORA.BE", "STERKEJAN33@PANDORA.BE", "TimeReg2020", "AQAAAAEAACcQAAAAEGhN/2QHCsaOt7GSsDKIDDw97g78I/nGbMlJMHQTm0PXBTygAnqp6MvjtOoZ19vTXg==", null, false, "WGY5YWIB4XK6LUI2TBROBMXVLQKNNWOV", false, "SterkeJan33@pandora.be" },
                    { "00000000-0000-0000-0000-000000000017", 0, "68e80c7b-4679-4fc7-8f8a-7dfcf165d726", "Zwaffelaere@gmail.com", true, "Uytebroeck", false, null, "Piet", "ZWAFFELAERE@GMAIL.COM", "ZWAFFELAERE@GMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEDW9XgLVIgOO7WzkG6A7TgP0yWDQDtTcx12/31bVwbU2bIs4144E1WCLqEivvs5zXw==", null, false, "HGIXXQPIK4FFBOOUNMFY7GN6GDHXEVV1", false, "Zwaffelaere@gmail.com" },
                    { "00000000-0000-0000-0000-000000000030", 0, "55690745-3bfd-43ad-abbe-af37f549182c", "rapgewoon@hotmail.com", true, "Wenne", false, null, "Eve", "RAPGEWOON@HOTMAIL.COM", "RAPGEWOON@HOTMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEMIU4gzVaGUlZ1J6tOHTGM4kCCDREbF7JbnQ3w1ZmZYQpzu5RHu3Nr+5ubYsIYj0dw==", null, false, "JF6GSUYRRSWNWXY9Z1HUJLK1GUQREXOO", false, "rapgewoon@hotmail.com" },
                    { "00000000-0000-0000-0000-000000000016", 0, "59cfeb05-2937-4806-8f27-accbc1ccfe91", "Thebestginger@qotsa.com", true, "Homme", false, null, "Josh", "THEBESTGINGER@QOTSA.COM", "THEBESTGINGER@QOTSA.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEGKO2R1hpEbhAUk7CQRyrHs33r/BpZwoVbeDs2/sRKnmx4OUVOtYMheUQW5h+Ssy3g==", null, false, "ZUYKIDLJWUZXNXN6BK6Z6QCZO5WXOYNR", false, "Thebestginger@qotsa.com" },
                    { "00000000-0000-0000-0000-000000000014", 0, "3205df9b-0609-478c-953a-3ebc1cbd3894", "DeYoeri@gmail.com", true, "Declerk", false, null, "Yoeri", "DEYOERI@GMAIL.COM", "DEYOERI@GMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEN6PxONlTF9oF+iiz6L4W23jEr+twtnbZtDIt+Icsls3olG4ZOgd6fRk2/dG9gO+7A==", null, false, "E9HTNSBN303BXB434HYORNEMWKFR9F0K", false, "DeYoeri@gmail.com" },
                    { "00000000-0000-0000-0000-000000000013", 0, "979b7fae-dee1-443f-89cd-cd5d7e075296", "EdwardLeCanard@hotmail.com", true, "Vaneende", false, null, "Edward", "EDWARDLECANARD@HOTMAIL.COM", "EDWARDLECANARD@HOTMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEMu1JDOu4oKrdGkRTX+FX+CDSNuknw/dZR312s3bPvRpN/cnfAdz9eRV8q9VOTIg1w==", null, false, "X50KHZXPUONAXCIOYAP1VN2KWJNQF8YF", false, "EdwardLeCanard@hotmail.com" },
                    { "00000000-0000-0000-0000-000000000012", 0, "727ea679-d671-4406-97cf-3a00468fd7e6", "DePijpVanMaarten@gmail.com", true, "Pijpers", false, null, "Maarten", "DEPIJPVANMAARTEN@GMAIL.COM", "DEPIJPVANMAARTEN@GMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEL43r5GkPyQcH54RZqNGI5IgeYK2gu//iO5nEQ5X80yTL360pE7OTRPT1MFv4jXLFw==", null, false, "NZVCLM9FJXG84V7AAF3WNV9UX88PSSAD", false, "DePijpVanMaarten@gmail.com" },
                    { "00000000-0000-0000-0000-000000000011", 0, "a01d31d2-66ce-40a5-9a38-f5a02d65cdae", "Satchel@steelpanther.com", true, "Parrish", false, null, "Russ", "SATCHEL@STEELPANTHER.COM", "SATCHEL@STEELPANTHER.COM", "TimeReg2020", "AQAAAAEAACcQAAAAELRMgmw9FpYDw1qV4ige2gJ7/YbrdGqDf8B0s2F99CO4XLk3QHObivyiFFpF+FfZyw==", null, false, "W7VNKA17XODMDCKG5JBXZQCLUQSRF32F", false, "Satchel@steelpanther.com" },
                    { "00000000-0000-0000-0000-000000000010", 0, "c6d41496-5440-4fb4-b12b-b36a66bd271c", "IloveyouTomorrow@hotmail.com", true, "Demain", false, null, "Annie", "ILOVEYOUTOMORROW@HOTMAIL.COM", "ILOVEYOUTOMORROW@HOTMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEBI6SCpXg5ltphB5jLnhC+PYDFwOlXDMr7T+U/nEAhNHV8RVJ2ySjm9OAkkxyKgCXw==", null, false, "OJUDGXCPUCPYDMIQTIWMSRTLXH4NMKDB", false, "IloveyouTomorrow@hotmail.com" },
                    { "00000000-0000-0000-0000-000000000009", 0, "00b46ecb-768e-4d9e-8168-c947145342aa", "Andy123@gmail.com", true, "Degught", false, null, "Andy", "ANDY123@GMAIL.COM", "ANDY123@GMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAELcRawJt6K49B4uA2nc+KesuiOsniRhgCVLBMT8U+/MGOlKXiwooWzigFNfmhJeTmg==", null, false, "AERAYD2O3KEIAGCLLIP7O8QNVSXU8PUD", false, "Andy123@gmail.com" },
                    { "00000000-0000-0000-0000-000000000008", 0, "71225b1c-93a9-4e98-9769-e2bac0cf8c81", "SnelnEddy@hotmail.com", true, "Guapo", false, null, "Edwardo", "SNELNEDDY@HOTMAIL.COM", "SNELNEDDY@HOTMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEPJWH5e5MpPdTcTG3jrPL1axo9K0nRNQZVGOnfTEyYQ8Wvp6elJ94SakSQIvATpKAg==", null, false, "AY8SBXVKA6Z6MXJXBYIIE9JIAOQV2DJO", false, "SnelnEddy@hotmail.com" },
                    { "00000000-0000-0000-0000-000000000007", 0, "b61bb5e0-6249-4017-8f66-c2e793cead19", "katringring@skynet.be", true, "Vanbelleghem", false, null, "Katleen", "KATRINGRING@SKYNET.BE", "KATRINGRING@SKYNET.BE", "TimeReg2020", "AQAAAAEAACcQAAAAEPt1COmtB8aZqMqV571p1U+kSd+FgnWpuXAlv/9o2aK2XYzwf/wQ58Bnnq5XARR/4w==", null, false, "TX2YKCJILNPIIAS7Y4XDXNU7ATXAMEXW", false, "katringring@skynet.be" },
                    { "00000000-0000-0000-0000-000000000006", 0, "d6089fee-e038-4e51-a688-efd386d13801", "CharlesDurue@hotmail.com", true, "Verstraete", false, null, "Karel", "CHARLESDURUE@HOTMAIL.COM", "CHARLESDURUE@HOTMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEKUbDlK7+IUmdoYo7SlhoZhEgAwYa6XUr5C0CF72kswsPunNa1IrGVtM43RjPC7zmw==", null, false, "GOHAS6DGS3TEFB8CKVA1O0YY7L7QOJGY", false, "CharlesDurue@hotmail.com" },
                    { "00000000-0000-0000-0000-000000000005", 0, "2fa68a7a-8187-440a-92d3-9332f602a90c", "RogerDoeniemee@telenet.be", true, "Vangenechte", false, null, "Roger", "ROGERDOENIEMEE@TELENET.BE", "ROGERDOENIEMEE@TELENET.BE", "TimeReg2020", "AQAAAAEAACcQAAAAECwpXgPz2azBfqeIRxDIVqkGDEtGx5Ygxk6+Ko5NaJo+HXVJsZ04CKPbj9HKeS8AYw==", null, false, "DMQ1MNFMDVWEMHCWA4TOPXZUCR97WIGJ", false, "RogerDoeniemee@telenet.be" },
                    { "00000000-0000-0000-0000-000000000004", 0, "7a9bb722-0187-44d6-ab37-35bd39a46abd", "ErnaVanvoren@hotmail.com", true, "Vanvoren", false, null, "Erna", "ERNAVANVOREN@HOTMAIL.COM", "ERNAVANVOREN@HOTMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEN6bckEB+sr0+nk6sl9f6mRkkZH06VhtrUP5BccmBq/O+bjTGhEt/muUau0wmSNnXA==", null, false, "KEVV7QQDZVPGXW0LIRHWRUBJDWV1BEOK", false, "ErnaVanvoren@hotmail.com" },
                    { "00000000-0000-0000-0000-000000000003", 0, "87512ca8-3082-41c9-a799-125a1724dfdb", "Ialwayswin@gmail.com", true, "Pot", false, null, "Jack", "IALWAYSWIN@GMAIL.COM", "IALWAYSWIN@GMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAELtnhq0xAPjHlTVUK7gfNWBBeticpTfa0OIZIaY68qIYC+ia9n1SFIaBS+qcoaIE8w==", null, false, "CGZLWFPLDP93ZCFWTQ19E9LGZAH3EDV4", false, "Ialwayswin@gmail.com" },
                    { "00000000-0000-0000-0000-000000000002", 0, "ea936088-7c16-4dae-8679-ccb63b4b6529", "EchtElkeKant@hotmail.com", true, "Kant", false, null, "Elke", "ECHTELKEKANT@HOTMAIL.COM", "ECHTELKEKANT@HOTMAIL.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEC4RqwbaUa2y11zbotKbN91j9INtaeYY2NYYJj/W3FySSya2wgyBIVH5UzSvnligXw==", null, false, "LPRQIVUHQZ9B9VK0RQPN9LLR2JUDMOKX", false, "EchtElkeKant@hotmail.com" },
                    { "00000000-0000-0000-0000-000000000015", 0, "b7d20267-f0ca-40b8-b5a9-82c6e1bbf7b6", "CalmingCamille@telenet.be", true, "Thee", false, null, "Camille", "CALMINGCAMILLE@TELENET.BE", "CALMINGCAMILLE@TELENET.BE", "TimeReg2020", "AQAAAAEAACcQAAAAEGNm2TLWsK3nnMmUpmDrI8e5svUqqJKs/Mi0QIpcGnHOScM/3OxUDfgsCwWHA9i3+g==", null, false, "NB8OXAMNMR8SWHOY6ACNDYQE4VAGFEEP", false, "CalmingCamille@telenet.be" },
                    { "00000000-0000-0000-0000-000000000001", 0, "c8554266-b401-4519-9aeb-a9283053fc58", "aboynamedsue@JCash.com", true, "Cash", false, null, "Johnny", "ABOYNAMEDSUE@JCASH.COM", "ABOYNAMEDSUE@JCASH.COM", "TimeReg2020", "AQAAAAEAACcQAAAAEE/zh8ThYTRv5brW0vvFJuiJumu06jkqM56nmlYyfiCCZlELXGLJRSUeipp5HQ3zlA==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", false, "aboynamedsue@JCash.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserTasks_UserId",
                table: "UserTasks",
                column: "UserId");
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
