using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class AddPictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "f22e228a-9bf7-4629-9c87-740938bea662");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFvc5xFQS6xOKyVqrBpgp25tTeoLacW3L16EwQRx/A4oSF1MLTBGQ4NcoE1ZJ3BLKA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEK3hArgCjT1K7gdk5ObxTas8N8//g44hxHSVXTKmamT4kZvvBOrZYS85/ZvRnsMUqw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGb+EGH2/CZFB7psEOcHSDDuQlVt4NI6IBS2Ub/jNTL8OmbqyvSrNhmG90e+Xi6Vrg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEC74j5RY6PEzdWEvvSd3vn2E64ERwJcyNu6dcQoEeyNOcJhyBVYZHNqlrj7D1lIK1w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEN+818QBa4a+J4nLNqcCxxCSp0BiVpdBEkkGwYE7kSJDd8U33B24Ny45z1o7FswJIg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHTqOdf4lyoadttvhHmNYFTKblRyDyqXFcJqd/5qYn4Q/2SlhhRbz51kKeD9/jRpuw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKkodsk+0nxFHiXCuFiEhzTw9DItc5RGIYgAhViup1blSOQw/dYMIX8AYm1TAyGnqQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECCPJ0rCvHBu6TngER4d0r1D8qksSFVK38MMzidBERNK5KDHLXTWgyWcPjlKZWKrEA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJxqaoHVtwF9gMpsDfD13znV+lktKHSpTpKcivelsWdy8S/NHCKCJHtskp1gUpL1zA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGCJqf4c8Y0oeiYsrz9FEGb7Ya2kUS1MFubctwZ0bgwFeAUWrXQ3FFZP3+U2wlGpMw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKbbie0YuyWS7/8+Hrd+ZQQUwgYmz1j1F+oJn5Y7FFc+3ZBsDkEX0DK/kUJZ24G6Lw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPdoJgzQx86B5OjbOIBu7sjljBPyW8PAtfaHVKOSCGB9n41rjG93YUnWuW2i94ZPcw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFtPFbXEjSst++fJlAT8LP6dgHghsDNlHkwyLPH8dyXNVJt/EMAHRLuRBnU6GuBg4w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKVdYXgZpGbBbHG5HywYh28/B935HxJFX6oglIyERPsB0R8VgUjMhkRMXg+Fc1CHNQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEI9vV8qeSoU2j/iJx2/RJkZUywrdWTrA1dgzCStkiegwqj0P6k6b2KG9UJUlRTQQzA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEj4sglvTzeTLfkJ3S9Z5ckiM1YDSzb0pxppoZKIQRRKj8t2g5pk797rRujDvedCwA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEivJupEYf+xSDaXdSIuci3Xr9iRZZax9piXN/85KiVdWdTlPqtLKdh06onD+GlMew==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHhs/1GzhwM39J5IbDv2dkkvIfU3Jg/0eD2DGoYZnX7XW3YOG3fRTtNK7l9iOGTPsA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEESf8opq5Anz5OF0ZQpGYCgB6pRcgJu0jAeZw2KyPGcHyeObw6iOOnJZiujjQFkg9A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPgN36qfF8HjkG/RLfBsoj6lZWavb/c07G/kK0HL2ffbicVGcI1sDbgbAG2EAIbWVw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEA08KTZ5ygCnL1fn/axnVjS2T+IGyryZyw9aDf2jFUFGapJuxCsGHdWhfaBILmmxZw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDKmU7ocP8JUUMDarB2DEK7ZTNcJMr3D/V+qo3IjOhpiayaYtDhvW2O45ts24rO0sg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECTRpBNcSdrzyGga0rmGjmw0JXPXvnDOAS1518hXz+RLDE5rmCg6a8wrxxtpbyvYuA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKTLQFpJN5Ohsd3ztP5OEi31f2R59V8Q8wwvZX+73eF8Csl15siF7I92olnk5dOGKA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFJoPooJ7QRyav7Hi8V9rSICqhkQUChvsaoeIVZnLQX1jKRWc256WQwm5tNEPS+Ldg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEO4IMviQhGYKkvs2Up8KEpKFpz3bbQCni2koyyMcJxMwhvGVt5SmrD96Zc+bZfhC4Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKDObV5V/8vaChv8gREbDKur79birWYqYJCbdvi0kFKxRQCUsnMWaaA9iH5qQejdTQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKOWcZwfZI1LhHPdj8dczmZxIblJlUGbA8ICl8TeAOvgSj/1xhsLsIQes7yFTx2zxQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPWidicQ666FHZLeaBJJhBoWQh7u2gQy4AEi5Pni4C4uIJEOXk9Ps1gGck2BgXUlow==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAWJNH8ZzrHaV2HkL1uvtA0mX/NrcGjFmG1srdWavNBHBBaOXT149zgDcrw0NVEQ6g==");

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ReceiverId", "SenderId", "TaskId", "Text" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000400"), "00000000-0000-0000-0000-000000000006", "00000000-0000-0000-0000-000000000001", new Guid("00000000-0000-0000-0000-000000000200"), "Please update your work asap." },
                    { new Guid("00000000-0000-0000-0000-000000000401"), "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000006", new Guid("00000000-0000-0000-0000-000000000201"), "Can I get more info about the task please?" },
                    { new Guid("00000000-0000-0000-0000-000000000402"), "00000000-0000-0000-0000-000000000007", "00000000-0000-0000-0000-000000000001", new Guid("00000000-0000-0000-0000-000000000202"), "Please do this asap." },
                    { new Guid("00000000-0000-0000-0000-000000000403"), "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000006", new Guid("00000000-0000-0000-0000-000000000200"), "What should I do when I finish?" }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "TaskId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000300"), new Guid("00000000-0000-0000-0000-000000000200") },
                    { new Guid("00000000-0000-0000-0000-000000000301"), new Guid("00000000-0000-0000-0000-000000000201") },
                    { new Guid("00000000-0000-0000-0000-000000000302"), new Guid("00000000-0000-0000-0000-000000000201") },
                    { new Guid("00000000-0000-0000-0000-000000000303"), new Guid("00000000-0000-0000-0000-000000000202") },
                    { new Guid("00000000-0000-0000-0000-000000000304"), new Guid("00000000-0000-0000-0000-000000000203") }
                });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "Id", "TaskId", "UserId", "WorkDateTime", "WorkTime" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000024"), new Guid("00000000-0000-0000-0000-000000000223"), "00000000-0000-0000-0000-000000000025", new DateTime(2020, 10, 16, 17, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 51, 42, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000207"), "00000000-0000-0000-0000-000000000011", new DateTime(2019, 10, 4, 6, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 5, 0, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000206"), "00000000-0000-0000-0000-000000000010", new DateTime(2019, 9, 23, 15, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 18, 10, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000206"), "00000000-0000-0000-0000-000000000010", new DateTime(2019, 9, 20, 15, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 44, 30, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000205"), "00000000-0000-0000-0000-000000000009", new DateTime(2019, 8, 15, 10, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 30, 20, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000200"), "00000000-0000-0000-0000-000000000006", new DateTime(2018, 10, 14, 10, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 18, 20, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000203"), "00000000-0000-0000-0000-000000000008", new DateTime(2018, 10, 19, 11, 35, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 8, 40, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000202"), "00000000-0000-0000-0000-000000000007", new DateTime(2018, 10, 18, 11, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 28, 30, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000201"), "00000000-0000-0000-0000-000000000006", new DateTime(2018, 10, 15, 12, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 19, 28, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000208"), "00000000-0000-0000-0000-000000000011", new DateTime(2020, 2, 20, 10, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 31, 50, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000204"), "00000000-0000-0000-0000-000000000008", new DateTime(2019, 8, 14, 11, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 35, 50, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000023"), new Guid("00000000-0000-0000-0000-000000000221"), "00000000-0000-0000-0000-000000000024", new DateTime(2020, 10, 15, 16, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 45, 10, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000209"), "00000000-0000-0000-0000-000000000011", new DateTime(2020, 2, 21, 10, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 8, 41, 30, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000211"), "00000000-0000-0000-0000-000000000016", new DateTime(2020, 5, 15, 13, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 7, 40, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new Guid("00000000-0000-0000-0000-000000000224"), "00000000-0000-0000-0000-000000000017", new DateTime(2019, 11, 5, 10, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 8, 42, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000026"), new Guid("00000000-0000-0000-0000-000000000225"), "00000000-0000-0000-0000-000000000025", new DateTime(2019, 11, 6, 10, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 6, 5, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000027"), new Guid("00000000-0000-0000-0000-000000000226"), "00000000-0000-0000-0000-000000000026", new DateTime(2019, 11, 8, 11, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 19, 8, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000220"), "00000000-0000-0000-0000-000000000024", new DateTime(2020, 10, 13, 15, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 26, 45, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000029"), new Guid("00000000-0000-0000-0000-000000000228"), "00000000-0000-0000-0000-000000000028", new DateTime(2020, 2, 10, 12, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 24, 6, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000229"), "00000000-0000-0000-0000-000000000029", new DateTime(2019, 4, 8, 11, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 35, 41, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-000000000230"), "00000000-0000-0000-0000-000000000030", new DateTime(2020, 6, 20, 11, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 7, 41, 20, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000032"), new Guid("00000000-0000-0000-0000-000000000231"), "00000000-0000-0000-0000-000000000015", new DateTime(2019, 11, 15, 14, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 35, 41, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000033"), new Guid("00000000-0000-0000-0000-000000000232"), "00000000-0000-0000-0000-000000000030", new DateTime(2018, 10, 10, 10, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 31, 50, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000021"), new Guid("00000000-0000-0000-0000-000000000219"), "00000000-0000-0000-0000-000000000023", new DateTime(2020, 7, 13, 14, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 35, 38, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000020"), new Guid("00000000-0000-0000-0000-000000000218"), "00000000-0000-0000-0000-000000000022", new DateTime(2020, 7, 12, 10, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 47, 8, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new Guid("00000000-0000-0000-0000-000000000217"), "00000000-0000-0000-0000-000000000021", new DateTime(2018, 8, 14, 11, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 12, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000018"), new Guid("00000000-0000-0000-0000-000000000216"), "00000000-0000-0000-0000-000000000021", new DateTime(2018, 3, 26, 16, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 1, 35, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000017"), new Guid("00000000-0000-0000-0000-000000000215"), "00000000-0000-0000-0000-000000000021", new DateTime(2018, 3, 25, 15, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 8, 41, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000214"), "00000000-0000-0000-0000-000000000020", new DateTime(2018, 3, 20, 14, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 22, 10, 25, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000213"), "00000000-0000-0000-0000-000000000020", new DateTime(2020, 5, 18, 13, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 4, 55, 10, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000212"), "00000000-0000-0000-0000-000000000017", new DateTime(2020, 5, 17, 12, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 6, 39, 50, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000210"), "00000000-0000-0000-0000-000000000015", new DateTime(2020, 5, 13, 16, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 15, 30, 0) },
                    { new Guid("00000000-0000-0000-0000-000000000028"), new Guid("00000000-0000-0000-0000-000000000227"), "00000000-0000-0000-0000-000000000027", new DateTime(2019, 11, 10, 13, 30, 12, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 20, 45, 0) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000300"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000301"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000302"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000303"));

            migrationBuilder.DeleteData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000304"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "35f36485-8c55-4e63-93c6-74d17e82e4c3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEFSPq8g25KCoiMB35sdk5sn64lGlSmnErUW7AJobL10WZpvE7xL4w6HBeoWS7jzYZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAECvj/7TkuNOfulVcGJpt4pZuhz0XX+3KV3jhq4mBFzF6x8iF/Ey4d57jXRVAJeu/HA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEOonpqnOgfnjMQFuZ4CsqV1Uxgs52bgomtwdRbqDHrss1YnyOwNjBh6j6o2YVqOC5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEJBPqLbEbJNgqUzf1oYxtdGF+y+L2EyEw2weeqD1X4Tlk/MhHv35IySrV3fysUhqQA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEGVh3HfYzwXgTKOyrESqBaUjWP2CbVBDi1hU/7zfcHG9v7Jemu340CxKJgbbzPLceA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEDuKXnpkqgjHcZD75OAvZg90v53G+Y0ceAOkx5IPMFu+CM9etKQg5OvsPNoMxhClIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEC5fgzKFAym9XZjOmNlD5EVPHShoHqjOAIDzhJChFDWrmuZUWNi07n71xbtUJbqG9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAENJQOS8vjLu2o4ebetj5DssHHATVQcMc1vPnKWiNqdiqxiWrD5ypF5heT2Mr79mF0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEKxWI/Ol0adKJcbNjZumtSuyxxDndf6nBQqkll7N5xwJB2YN0jK5a+/mae91MGcHVw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEEDKJXiwQNCCgpF/C7CcgBebdXXMUhgxRz47HdcIOHN5GbLgK8yqX5jqF4DhnRiKwQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEImsC6XJzQSjVbcZlfjSP4asvfZ+ckgH0sCKQ/YTgw/j4zmrMK0kzSTlTUXB0PVCnw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEBSgU0T2fGpwki+jx3yyr/9qIJ5/XqzXMlOOjm+sXKJL7dSf4uRV1g0b06FYiLSu3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEAweX5sweZ7Auu4o4KwGLIdzZjlolRpb/QaW7RMEn42K7Fk2NX1GecNqvl0PXhQIvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEKmjEdGXTa7gbIrWxnHsTs8z2BMpNvkjexPo+lfXXHQMYuj8UIf2eHlEBsX5ZkKJNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEPZvO/Bdn67We0EtY0PEMnunizUVNYXVvc8k478D2YoaWhX35Q7pJNheHyVsiThiOQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEHVe2pRsJB+mjdzlGKf2UondhBKBrWhwuIJWo1eFQeDs9uuOY6v4uW3JmzpSS2TEbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAENGIr5oRpkpVGcrTtFjtDgkMCqjQuoqH5oZ5vFy/kaWNFzvC8yPBQmih9pfX5THenQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEMcW+LEF8duL417fbliJBprqXZyRurMCl3Ix/AXhl5TQOqq0fb1Fe38rDazWIIIfBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEGCtqXXywYX8har0rjk2db7bOb1Fy0t4EJn2kmXLs2A5tHR1nGamrBsue0UTU2xLrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEFjl8gH+6cSKWEF8hCNFyiCONXcbS2jGPibfKqhXrreO3s3XDq5tzlP+frqLhShs8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEGPy1r17IzxARWhe/ex9AFy+hhF+USvYe83Yl1arqWrpy9C3lIIw5Qs+0O710hr5bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEPAv5NwFsBG6pqVJIF1wYFgHliTrIOrNAaUAhNY4LNZxEmMcf9xEiFjh0dt/icaF1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEE4+0Z+np+QoSpgMI5MF0r9hnH1EH4JjS2+d8tLak35J++O8MScsbjZ8l3oIiS1Dyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEEEaA2FUScVG6gzyH16DH67i1q4aaDaq5yHL4M3lcOTgL2FOQm29vfcP/oIN+Fij5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEDQAEzQwaPsdodCGArszfjMGMW0lFpvm44OGxo3AE4mjKqysh16dwfqfWdnj3kGq7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEJCYvQnW/Z5t7z5A9cWVSVm9WQQ4sjdTlY6TVAofBTdcg21T9eh1s3gImzTzU3ZLSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAENCXY6jdS/twLJiIealPV6qVSAIyDDt+MGcuWtj+YQz5n3PQ/vArgNNkDacMFbBSZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEEh3MUdwSw80GF3Vlqa6Z9hbqXxJ5tCDl1ZYUhpsdjkJ/BkEVwHFxKs62xedtTJMNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAEApTaZNW4nB+wwfEApux5Tbt/sZRcbRDK1uDCn9/0zCRJy7hsHmCifLE/6mxUDmVgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "Password", "PasswordHash" },
                values: new object[] { "TimeReg2020", "AQAAAAEAACcQAAAAED3oM4LBHL9FacQooSA6lLxV6nIl7340Yk2msOKBKxVxICMQ0hYbfpHWAN41vp1MrQ==" });
        }
    }
}
