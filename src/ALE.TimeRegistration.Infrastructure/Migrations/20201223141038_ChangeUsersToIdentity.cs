using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class ChangeUsersToIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "2b4dcc89-66f9-43be-8800-6a68ec1cdb9f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "LastName", "Name", "Password", "PasswordHash" },
                values: new object[] { "Cash", "Johnny", "TimeReg2020", "AQAAAAEAACcQAAAAEHdLbyLmQvSDZefO8y7B9gB3ZQQYpb2WTFgdXig+7iooyfxtbKLeBs9tcydQ8NZ/kA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ea936088-7c16-4dae-8679-ccb63b4b6529", true, "ECHTELKEKANT@HOTMAIL.COM", "ECHTELKEKANT@HOTMAIL.COM", "AQAAAAEAACcQAAAAEBKBXyepvdjo52oXiBH8qbvIuMrnQ9JWUa7+G6V22CI/8kgQQDH6Na8BReZrS4UUhw==", "LPRQIVUHQZ9B9VK0RQPN9LLR2JUDMOKX", "EchtElkeKant@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "87512ca8-3082-41c9-a799-125a1724dfdb", true, "IALWAYSWIN@GMAIL.COM", "IALWAYSWIN@GMAIL.COM", "AQAAAAEAACcQAAAAEFhI6snjG0Q6jCZR51M42jHY5phTaiaD5bN0BTGInCdrKLqqeaDh2agmWifHqB3DNA==", "CGZLWFPLDP93ZCFWTQ19E9LGZAH3EDV4", "Ialwayswin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7a9bb722-0187-44d6-ab37-35bd39a46abd", true, "ERNAVANVOREN@HOTMAIL.COM", "ERNAVANVOREN@HOTMAIL.COM", "AQAAAAEAACcQAAAAEHn5FuSBKRm3V13eUOxLDLbyAlUPROSj1cM/NQRk1v5dRPaI+NZ8LY1SSo/GBu2AxQ==", "KEVV7QQDZVPGXW0LIRHWRUBJDWV1BEOK", "ErnaVanvoren@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2fa68a7a-8187-440a-92d3-9332f602a90c", true, "ROGERDOENIEMEE@TELENET.BE", "ROGERDOENIEMEE@TELENET.BE", "AQAAAAEAACcQAAAAEDq57cpVbZ4rWD4Zf+klvMUvnSkuvfTJOQvL66a6z7sGgZ8SdA0aTgv92wBRqXP4EQ==", "DMQ1MNFMDVWEMHCWA4TOPXZUCR97WIGJ", "RogerDoeniemee@telenet.be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d6089fee-e038-4e51-a688-efd386d13801", true, "CHARLESDURUE@HOTMAIL.COM", "CHARLESDURUE@HOTMAIL.COM", "AQAAAAEAACcQAAAAEOya+nViZ/tb5e3KZMr9r7oIeD921D85F21hluLkasQxdxHzDn/aQifk9F2PpjNSJQ==", "GOHAS6DGS3TEFB8CKVA1O0YY7L7QOJGY", "CharlesDurue@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b61bb5e0-6249-4017-8f66-c2e793cead19", "katringring@skynet.be", true, "KATRINGRING@SKYNET.BE", "KATRINGRING@SKYNET.BE", "AQAAAAEAACcQAAAAEJcPApRpq28W1Yo2FZC3IWlbhvyaA00gNEpZe9CagPCDJxYfRLcxm6Ucw6qLFKd83g==", "TX2YKCJILNPIIAS7Y4XDXNU7ATXAMEXW", "katringring@skynet.be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "71225b1c-93a9-4e98-9769-e2bac0cf8c81", true, "SNELNEDDY@HOTMAIL.COM", "SNELNEDDY@HOTMAIL.COM", "AQAAAAEAACcQAAAAENblPw1sCIWIfyfqLAkOFKwTSLmzs2XJXnCNXP9EUWyvxovivKCZHUV9dT9dGJgdJQ==", "AY8SBXVKA6Z6MXJXBYIIE9JIAOQV2DJO", "SnelnEddy@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "00b46ecb-768e-4d9e-8168-c947145342aa", true, "ANDY123@GMAIL.COM", "ANDY123@GMAIL.COM", "AQAAAAEAACcQAAAAEJj4jSqJ444fd5QvPNMTtuQcKZ2HaKxhtaz18KIeYfrBLyDtM90iznILUEzc3ZAYxQ==", "AERAYD2O3KEIAGCLLIP7O8QNVSXU8PUD", "Andy123@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c6d41496-5440-4fb4-b12b-b36a66bd271c", true, "ILOVEYOUTOMORROW@HOTMAIL.COM", "ILOVEYOUTOMORROW@HOTMAIL.COM", "AQAAAAEAACcQAAAAEJ/JR7HSH70SUV2RzaX+hg5rfcA6slCWppCmNFkCP7jKPxdEgZwy5rdHgTruracQRQ==", "OJUDGXCPUCPYDMIQTIWMSRTLXH4NMKDB", "IloveyouTomorrow@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a01d31d2-66ce-40a5-9a38-f5a02d65cdae", true, "SATCHEL@STEELPANTHER.COM", "SATCHEL@STEELPANTHER.COM", "AQAAAAEAACcQAAAAECUyFOtJfbOEVL9lPr2wf/4m+J37bm7tYBipUsnP3pJG4ej1W0qoCNbCWxJq7uHfmA==", "W7VNKA17XODMDCKG5JBXZQCLUQSRF32F", "Satchel@steelpanther.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "727ea679-d671-4406-97cf-3a00468fd7e6", true, "DEPIJPVANMAARTEN@GMAIL.COM", "DEPIJPVANMAARTEN@GMAIL.COM", "AQAAAAEAACcQAAAAEBZWejCZ1ErENPDgNu0sLkNBpSct4n9B1pBaSTo888pPRThGKkNTBzjHv/08ybqRXQ==", "NZVCLM9FJXG84V7AAF3WNV9UX88PSSAD", "DePijpVanMaarten@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "979b7fae-dee1-443f-89cd-cd5d7e075296", true, "EDWARDLECANARD@HOTMAIL.COM", "EDWARDLECANARD@HOTMAIL.COM", "AQAAAAEAACcQAAAAEH4kQWqqvAPvE17aZY0jpST+QsuxPXH4zAX2lczN4NYluxDW7X/rQYivBqmVMhymGA==", "X50KHZXPUONAXCIOYAP1VN2KWJNQF8YF", "EdwardLeCanard@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3205df9b-0609-478c-953a-3ebc1cbd3894", true, "DEYOERI@GMAIL.COM", "DEYOERI@GMAIL.COM", "AQAAAAEAACcQAAAAEKtlQ3MFD4y1iORjMipS6uWEGU3YhttDVI9g3JSVLip+R/PYZXqNBlcSTrctOKoYLw==", "E9HTNSBN303BXB434HYORNEMWKFR9F0K", "DeYoeri@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b7d20267-f0ca-40b8-b5a9-82c6e1bbf7b6", true, "CALMINGCAMILLE@TELENET.BE", "CALMINGCAMILLE@TELENET.BE", "AQAAAAEAACcQAAAAECbW8bH6dYJ78UufY+vXtt+GSWff7i1MFaO+zP4DExsxnYM52C07b1zV07G1xxOBUQ==", "NB8OXAMNMR8SWHOY6ACNDYQE4VAGFEEP", "CalmingCamille@telenet.be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "59cfeb05-2937-4806-8f27-accbc1ccfe91", true, "THEBESTGINGER@QOTSA.COM", "THEBESTGINGER@QOTSA.COM", "AQAAAAEAACcQAAAAEGVBg4d/qpVNwilT6UQU51znkgSg8ux8jTOWy7dEKraIyMMoR+RgjkNbyCxefmQQnQ==", "ZUYKIDLJWUZXNXN6BK6Z6QCZO5WXOYNR", "Thebestginger@qotsa.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "68e80c7b-4679-4fc7-8f8a-7dfcf165d726", true, "ZWAFFELAERE@GMAIL.COM", "ZWAFFELAERE@GMAIL.COM", "AQAAAAEAACcQAAAAEIPaJs0VgCIUg+Rt0Vcdg99Pxi7WOx3ioCUEiDSDQ8vcRcAF098+0TdnuFSX9byNwQ==", "HGIXXQPIK4FFBOOUNMFY7GN6GDHXEVV1", "Zwaffelaere@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a1000963-395c-4507-83df-8f4b9e784db1", true, "STERKEJAN33@PANDORA.BE", "STERKEJAN33@PANDORA.BE", "AQAAAAEAACcQAAAAEKA9K3EQuCJmvkSNYjn8ZbAa5nymZHCT9oijP3V47v6wHFU+w3QsJ/1ezwucKICUpw==", "WGY5YWIB4XK6LUI2TBROBMXVLQKNNWOV", "SterkeJan33@pandora.be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b9e1dbac-e651-482a-98a4-8e24583f29c0", true, "RIETJEGESSOF@HOTMAIL.COM", "RIETJEGESSOF@HOTMAIL.COM", "AQAAAAEAACcQAAAAED5KvLqwcjIrFWxCPl3YbJGaTIQimiB3D65qKP6U1NiPmTfDXdND+sqGwoV/NtbblA==", "9H2QG7IPOUORADDNMF2ISIRSOGZJNXGZ", "RietjeGessof@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "86d42357-8dbc-48c9-886d-3a1b957f2075", true, "WILLYWILLY@THESCABS.BE", "WILLYWILLY@THESCABS.BE", "AQAAAAEAACcQAAAAEFUn35T5nhYEieFi5tIFKnVP+1WTMhnnYGnbcuINo7TSO5/lEGddF/4i5rY88iY8ig==", "7F7LSOHNMOKGFGQVMMGOX3SHM3PBNHQB", "willywilly@thescabs.be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d7280862-2341-462a-8fb5-1380edea1422", true, "PESCADOLOVER@SKYNET.BE", "PESCADOLOVER@SKYNET.BE", "AQAAAAEAACcQAAAAEJTsGCUrYHS0FLfxw0NgzNlJlmyI4umTE4ljIT1wjt8G0F5QamwWJYffIbymnoLchg==", "WGLZXEZUI3NLP8ZWUYK5CFN8XWBT7ATX", "PescadoLover@skynet.be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0fc3e5d4-f6ce-4160-aa94-d2acc0be114d", true, "TOMVANMARCKE@GMAIL.COM", "TOMVANMARCKE@GMAIL.COM", "AQAAAAEAACcQAAAAEKJsGALGC5glhXtCo4Wsrs8DU0Jt8rSZkAVd74BFTpbI3FfpulgYTyp+ZhFGkz34dw==", "OIKDBFPAR5GJKJ91OUAOXNKR1CMLSTFC", "TomVanmarcke@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8f42511c-f74f-442c-a8f2-28b10d2bc114", true, "LOEWILOEWIE@HOTMAIL.COM", "LOEWILOEWIE@HOTMAIL.COM", "AQAAAAEAACcQAAAAEN9NYpNPuV1sRe1S28XmCnqyc9ODwnhjHChH0Uv/jf056taO34AFoNb1jgqQKTD2Gw==", "F0SRUYTP4OF6TSFD3CNJBX5ECAJFPPFZ", "Loewiloewie@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b52a849c-4b01-4dda-ac2f-30f6b08fe075", true, "GIEZIJTEM@SKYNET.BE", "GIEZIJTEM@SKYNET.BE", "AQAAAAEAACcQAAAAEIsV7jfV1pT602PLqJtXXxuMe0auojIGzzP0aVZBO/PvuglJnXjTx0NmGm0umFNktA==", "PHLIIUHLZLGB2UTDD2LHUFROZ7TDQAD7", "Giezijtem@skynet.be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "018aba24-a96f-44e9-a058-a047d0bd0b53", true, "CONNIEBETER@GMAIL.COM", "CONNIEBETER@GMAIL.COM", "AQAAAAEAACcQAAAAENY6iNEdUnTbwooujwsJ/mMoTkhc3ILbnRaVsnkDSawC5vrN7et6ZJVZ3nvSbcp7HA==", "FWM36IDUG00055IF56RZWA2CR9OYCVB3", "ConnieBeter@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc117b43-d867-4f86-8ac4-8d4efc2820c4", true, "GEZONDEPETER@TELENET.BE", "GEZONDEPETER@TELENET.BE", "AQAAAAEAACcQAAAAEOl3ryDXP9p7PIU88RnpuGg8c3xHzPyU3lm7QUZJeK0SJpEFENiBTwlhovsRP+rzEQ==", "TJLKW00301EENWVWL2MCPLTCU18IT7XY", "GezondePeter@telenet.be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1993d307-e257-4e29-8487-b230037199aa", true, "BENNERNIE@SKYNET.BE", "BENNERNIE@SKYNET.BE", "AQAAAAEAACcQAAAAEPeQUAEsOLkDP8fUwjypvUVDxX5fCe9QBnf7nYkR5TZVauzWqMFjQpDLmOf03uAUPA==", "KXW8TS8VIEG0BL1OIA7U2PASSALDXMV3", "Bennernie@skynet.be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b017e971-0a03-4aa0-86e5-b3d1c603d64b", true, "THEBESTBUSKER@LONDON.COM", "THEBESTBUSKER@LONDON.COM", "AQAAAAEAACcQAAAAEH0Hag0S9uel3BgivMgrCCk1mDSA0ed75v5Uw+nIPCJqyjYe8bJgudDMEqaSikjF2w==", "VRVLNRMUMHA6IADTQ7CO9VCIMVX4OMO5", "Thebestbusker@london.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "50d8c368-d7f1-4e3f-8216-6ba5c5e3e76a", true, "CORONATOPPER@GMAIL.COM", "CORONATOPPER@GMAIL.COM", "AQAAAAEAACcQAAAAEMKd/gZ816PPnFVO652f2+RsUqQALcisKsuIXem9ufa1ek26T1rj6/m7AA5FaGrDEg==", "W7IEDSQT3GEVZWUOTXG8CL1PI3K6MXU7", "CoronaTopper@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "55690745-3bfd-43ad-abbe-af37f549182c", true, "RAPGEWOON@HOTMAIL.COM", "RAPGEWOON@HOTMAIL.COM", "AQAAAAEAACcQAAAAEDQL5UoijyoiB442J/iy3i28FXg3jdJgrGG8zjXEQP2tSco89kn74MOzUxKDyiUnbg==", "JF6GSUYRRSWNWXY9Z1HUJLK1GUQREXOO", "rapgewoon@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000402"),
                column: "SenderId",
                value: "00000000-0000-0000-0000-000000000001");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "ConcurrencyStamp",
                value: "6617ed95-a00f-484d-905c-19522d37aeac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "LastName", "Name", "Password", "PasswordHash" },
                values: new object[] { null, null, null, "AQAAAAEAACcQAAAAELDp6qhlaOUyZiTq++0WhNe/FynURZTVs6Qhejl/Jd0MShmlRkmE1SrCnq8JfKChNA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a7eaa428-d59b-49fc-bdeb-f2b37b4048c6", false, null, null, null, "08997253-9e6d-4130-9e02-fabefe47872b", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0daedb8a-803b-47d6-a0d6-c6dddd118527", false, null, null, null, "c7b2dab7-eeec-428d-a052-6e1209931a45", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "60a067cc-7cf5-425a-9df5-c504f1d9f6de", false, null, null, null, "7b535b76-f807-400c-8254-b0c6d6a786bb", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "46351018-442d-4bee-8abf-fd9df8aa0d6a", false, null, null, null, "3b1057cc-7dc6-4df9-9ce2-e9090c8b412d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3b5eb76a-8a22-401d-a488-81ea902d0fd2", false, null, null, null, "dbecbb53-102e-4003-925f-a8f32d025c47", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2b375dbb-11c3-47df-bea2-3472bb5332e2", "Katringring@skynet.be", false, null, null, null, "d6049ed7-a29e-42a3-8825-0f6e7e38b65c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ce525691-fb58-49a0-8f12-a131ae80d046", false, null, null, null, "c5728fc9-ae61-472c-9e5a-72e411bbe6c3", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "64fbc69b-0703-4ded-9f87-7d2cb727d9f9", false, null, null, null, "d25b2f58-cc29-4d48-bea1-fbbf77d9b6de", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7d70a35e-3487-4f8e-8b93-b772a3657fea", false, null, null, null, "3e872442-7bda-4d19-82e3-78980e27cc6b", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a9c742f9-4c9b-46be-a656-299927616261", false, null, null, null, "46ae68dd-d884-4447-bc14-73678e44ecfe", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "06fa017b-eddb-41b9-ac41-22adbef7f2df", false, null, null, null, "82b15a48-d56c-42e6-add3-356a34dcf916", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "040f32ed-a766-4644-a256-6f76b296cb85", false, null, null, null, "e6f918b1-c12d-4bc1-92b5-90ae6df0d7b2", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5e866b04-1380-423e-ba0b-3b0c5b275d7d", false, null, null, null, "2fbe2356-91aa-4832-b9af-45a9e44fb221", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d71f1009-9636-4ead-a51d-421c611f550e", false, null, null, null, "a15d7c31-742b-4c22-842a-45ddf5062a0d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cbd0df08-eb4b-4627-ad6d-45068fb8c4c2", false, null, null, null, "b60ca086-73c2-41a5-8dd3-f826fd9eaddb", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "979d251d-b82d-4b2a-816a-3bf322e1895d", false, null, null, null, "014ef737-e148-4fb3-bb46-d874e5f477f8", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "12e710eb-7f22-485e-b014-5e5ba4445afe", false, null, null, null, "f055c671-2f6e-424d-832e-0734517949cb", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2e1681ee-84bf-4d6d-8d86-77db8990497d", false, null, null, null, "b6f62a05-c9a0-4432-9b95-314426dcc119", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f9a332d0-6acf-4a17-8bd5-a12346ec4bd5", false, null, null, null, "fe08bc31-36cc-4b13-a8fa-f02e583cf196", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e28c898b-8b5c-4254-8d84-2584672e1fa8", false, null, null, null, "f2b14b5a-4e93-45d0-a4ca-74688b01d6fd", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1f94aa69-69c3-45b2-8635-e952e0a559cb", false, null, null, null, "0b9c410a-8a3a-4320-9538-a72733e06d6b", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dd5a958c-7269-4d78-9960-8d82d3288cd5", false, null, null, null, "0a6bf07d-a5be-4f12-b732-77983a2cab7d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a8d72bfa-12e2-4e7a-86d4-c29f198992b3", false, null, null, null, "fe4ccde3-da2e-4285-a2cd-ddfdbb985d37", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "da84a928-f085-4b43-9ab5-4f9bfc9295de", false, null, null, null, "e9d3d5e2-0e5d-40b2-b5e9-db76e999e2a9", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a872a1cf-c31e-4b08-aefd-fa37f083cc5e", false, null, null, null, "e37d4e05-037c-4f94-b881-0d6e38fffd76", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "19ad1cc0-5321-43bc-a594-71267a89069b", false, null, null, null, "45179a9f-52ea-4f37-b2cd-3ab9c2ecfc46", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9ecc5683-1619-4ddc-a05b-569f0ce0d26d", false, null, null, null, "3286f182-fd6a-4f30-a6f5-bd158ec87c07", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "493d7269-00c4-47ab-a812-4a0e7ccf5efa", false, null, null, null, "a61ba6b0-570f-432c-b369-45565bba4f7f", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3f7a599f-0b7e-4c9a-9a30-4614972ae74f", false, null, null, null, "aaec2e5d-f0df-4828-8ffd-b40d60b737c0", null });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000402"),
                column: "SenderId",
                value: "00000000-0000-0000-0000-000000000002");
        }
    }
}
