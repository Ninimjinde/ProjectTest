using ALE.TimeRegistration.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class UserSeeder
    {
        const string UserPassword = "TimeReg2020";


        public static void Seed(ModelBuilder modelBuilder)
        {
            var Users = new List<User>
            {
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000001",
                    UserName = "aboynamedsue@JCash.com",
                    NormalizedUserName = "ABOYNAMEDSUE@JCASH.COM",
                    Email = "aboynamedsue@JCash.com",
                    NormalizedEmail = "ABOYNAMEDSUE@JCASH.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", //Random string
                    ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58", //Random guid string
                    Name = "Johnny",
                    LastName = "Cash",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000002",
                    UserName = "EchtElkeKant@hotmail.com",
                    NormalizedUserName = "ECHTELKEKANT@HOTMAIL.COM",
                    Email = "EchtElkeKant@hotmail.com",
                    NormalizedEmail = "ECHTELKEKANT@HOTMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "LPRQIVUHQZ9B9VK0RQPN9LLR2JUDMOKX", //Random string
                    ConcurrencyStamp = "ea936088-7c16-4dae-8679-ccb63b4b6529", //Random guid string
                    Name = "Elke",
                    LastName = "Kant",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000003",
                    UserName = "Ialwayswin@gmail.com",
                    NormalizedUserName = "IALWAYSWIN@GMAIL.COM",
                    Email = "Ialwayswin@gmail.com",
                    NormalizedEmail = "IALWAYSWIN@GMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "CGZLWFPLDP93ZCFWTQ19E9LGZAH3EDV4", //Random string
                    ConcurrencyStamp = "87512ca8-3082-41c9-a799-125a1724dfdb", //Random guid string
                    Name = "Jack",
                    LastName = "Pot",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000004",
                    UserName = "ErnaVanvoren@hotmail.com",
                    NormalizedUserName = "ERNAVANVOREN@HOTMAIL.COM",
                    Email = "ErnaVanvoren@hotmail.com",
                    NormalizedEmail = "ERNAVANVOREN@HOTMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "KEVV7QQDZVPGXW0LIRHWRUBJDWV1BEOK", //Random string
                    ConcurrencyStamp = "7a9bb722-0187-44d6-ab37-35bd39a46abd", //Random guid string
                    Name = "Erna",
                    LastName = "Vanvoren",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000005",
                    UserName = "RogerDoeniemee@telenet.be",
                    NormalizedUserName = "ROGERDOENIEMEE@TELENET.BE",
                    Email = "RogerDoeniemee@telenet.be",
                    NormalizedEmail = "ROGERDOENIEMEE@TELENET.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "DMQ1MNFMDVWEMHCWA4TOPXZUCR97WIGJ", //Random string
                    ConcurrencyStamp = "2fa68a7a-8187-440a-92d3-9332f602a90c", //Random guid string
                    Name = "Roger",
                    LastName = "Vangenechte",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000006",
                    UserName = "CharlesDurue@hotmail.com",
                    NormalizedUserName = "CHARLESDURUE@HOTMAIL.COM",
                    Email = "CharlesDurue@hotmail.com",
                    NormalizedEmail = "CHARLESDURUE@HOTMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "GOHAS6DGS3TEFB8CKVA1O0YY7L7QOJGY", //Random string
                    ConcurrencyStamp = "d6089fee-e038-4e51-a688-efd386d13801", //Random guid string
                    Name = "Karel",
                    LastName = "Verstraete",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000007",
                    UserName = "katringring@skynet.be",
                    NormalizedUserName = "KATRINGRING@SKYNET.BE",
                    Email = "katringring@skynet.be",
                    NormalizedEmail = "KATRINGRING@SKYNET.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "TX2YKCJILNPIIAS7Y4XDXNU7ATXAMEXW", //Random string
                    ConcurrencyStamp = "b61bb5e0-6249-4017-8f66-c2e793cead19", //Random guid string
                    Name = "Katleen",
                    LastName = "Vanbelleghem",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000008",
                    UserName = "SnelnEddy@hotmail.com",
                    NormalizedUserName = "SNELNEDDY@HOTMAIL.COM",
                    Email = "SnelnEddy@hotmail.com",
                    NormalizedEmail = "SNELNEDDY@HOTMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "AY8SBXVKA6Z6MXJXBYIIE9JIAOQV2DJO", //Random string
                    ConcurrencyStamp = "71225b1c-93a9-4e98-9769-e2bac0cf8c81", //Random guid string
                    Name = "Edwardo",
                    LastName = "Guapo",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000009",
                    UserName = "Andy123@gmail.com",
                    NormalizedUserName = "ANDY123@GMAIL.COM",
                    Email = "Andy123@gmail.com",
                    NormalizedEmail = "ANDY123@GMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "AERAYD2O3KEIAGCLLIP7O8QNVSXU8PUD", //Random string
                    ConcurrencyStamp = "00b46ecb-768e-4d9e-8168-c947145342aa", //Random guid string
                    Name = "Andy",
                    LastName = "Degught",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000010",
                    UserName = "IloveyouTomorrow@hotmail.com",
                    NormalizedUserName = "ILOVEYOUTOMORROW@HOTMAIL.COM",
                    Email = "IloveyouTomorrow@hotmail.com",
                    NormalizedEmail = "ILOVEYOUTOMORROW@HOTMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "OJUDGXCPUCPYDMIQTIWMSRTLXH4NMKDB", //Random string
                    ConcurrencyStamp = "c6d41496-5440-4fb4-b12b-b36a66bd271c", //Random guid string
                    Name = "Annie",
                    LastName = "Demain",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000011",
                    UserName = "Satchel@steelpanther.com",
                    NormalizedUserName = "SATCHEL@STEELPANTHER.COM",
                    Email = "Satchel@steelpanther.com",
                    NormalizedEmail = "SATCHEL@STEELPANTHER.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "W7VNKA17XODMDCKG5JBXZQCLUQSRF32F", //Random string
                    ConcurrencyStamp = "a01d31d2-66ce-40a5-9a38-f5a02d65cdae", //Random guid string
                    Name = "Russ",
                    LastName = "Parrish",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000012",
                    UserName = "DePijpVanMaarten@gmail.com",
                    NormalizedUserName = "DEPIJPVANMAARTEN@GMAIL.COM",
                    Email = "DePijpVanMaarten@gmail.com",
                    NormalizedEmail = "DEPIJPVANMAARTEN@GMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "NZVCLM9FJXG84V7AAF3WNV9UX88PSSAD", //Random string
                    ConcurrencyStamp = "727ea679-d671-4406-97cf-3a00468fd7e6", //Random guid string
                    Name = "Maarten",
                    LastName = "Pijpers",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000013",
                    UserName = "EdwardLeCanard@hotmail.com",
                    NormalizedUserName = "EDWARDLECANARD@HOTMAIL.COM",
                    Email = "EdwardLeCanard@hotmail.com",
                    NormalizedEmail = "EDWARDLECANARD@HOTMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "X50KHZXPUONAXCIOYAP1VN2KWJNQF8YF", //Random string
                    ConcurrencyStamp = "979b7fae-dee1-443f-89cd-cd5d7e075296", //Random guid string
                    Name = "Edward",
                    LastName = "Vaneende",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000014",
                    UserName = "DeYoeri@gmail.com",
                    NormalizedUserName = "DEYOERI@GMAIL.COM",
                    Email = "DeYoeri@gmail.com",
                    NormalizedEmail = "DEYOERI@GMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "E9HTNSBN303BXB434HYORNEMWKFR9F0K", //Random string
                    ConcurrencyStamp = "3205df9b-0609-478c-953a-3ebc1cbd3894", //Random guid string
                    Name = "Yoeri",
                    LastName = "Declerk",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000015",
                    UserName = "CalmingCamille@telenet.be",
                    NormalizedUserName = "CALMINGCAMILLE@TELENET.BE",
                    Email = "CalmingCamille@telenet.be",
                    NormalizedEmail = "CALMINGCAMILLE@TELENET.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "NB8OXAMNMR8SWHOY6ACNDYQE4VAGFEEP", //Random string
                    ConcurrencyStamp = "b7d20267-f0ca-40b8-b5a9-82c6e1bbf7b6", //Random guid string
                    Name = "Camille",
                    LastName = "Thee",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000016",
                    UserName = "Thebestginger@qotsa.com",
                    NormalizedUserName = "THEBESTGINGER@QOTSA.COM",
                    Email = "Thebestginger@qotsa.com",
                    NormalizedEmail = "THEBESTGINGER@QOTSA.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "ZUYKIDLJWUZXNXN6BK6Z6QCZO5WXOYNR", //Random string
                    ConcurrencyStamp = "59cfeb05-2937-4806-8f27-accbc1ccfe91", //Random guid string
                    Name = "Josh",
                    LastName = "Homme",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000017",
                    UserName = "Zwaffelaere@gmail.com",
                    NormalizedUserName = "ZWAFFELAERE@GMAIL.COM",
                    Email = "Zwaffelaere@gmail.com",
                    NormalizedEmail = "ZWAFFELAERE@GMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "HGIXXQPIK4FFBOOUNMFY7GN6GDHXEVV1", //Random string
                    ConcurrencyStamp = "68e80c7b-4679-4fc7-8f8a-7dfcf165d726", //Random guid string
                    Name = "Piet",
                    LastName = "Uytebroeck",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000018",
                    UserName = "SterkeJan33@pandora.be",
                    NormalizedUserName = "STERKEJAN33@PANDORA.BE",
                    Email = "SterkeJan33@pandora.be",
                    NormalizedEmail = "STERKEJAN33@PANDORA.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "WGY5YWIB4XK6LUI2TBROBMXVLQKNNWOV", //Random string
                    ConcurrencyStamp = "a1000963-395c-4507-83df-8f4b9e784db1", //Random guid string
                    Name = "Jan",
                    LastName = "Lefort",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000019",
                    UserName = "RietjeGessof@hotmail.com",
                    NormalizedUserName = "RIETJEGESSOF@HOTMAIL.COM",
                    Email = "RietjeGessof@hotmail.com",
                    NormalizedEmail = "RIETJEGESSOF@HOTMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "9H2QG7IPOUORADDNMF2ISIRSOGZJNXGZ", //Random string
                    ConcurrencyStamp = "b9e1dbac-e651-482a-98a4-8e24583f29c0", //Random guid string
                    Name = "Rita",
                    LastName = "Gessof",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000020",
                    UserName = "willywilly@thescabs.be",
                    NormalizedUserName = "WILLYWILLY@THESCABS.BE",
                    Email = "willywilly@thescabs.be",
                    NormalizedEmail = "WILLYWILLY@THESCABS.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "7F7LSOHNMOKGFGQVMMGOX3SHM3PBNHQB", //Random string
                    ConcurrencyStamp = "86d42357-8dbc-48c9-886d-3a1b957f2075", //Random guid string
                    Name = "Willy",
                    LastName = "Lambregt",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000021",
                    UserName = "PescadoLover@skynet.be",
                    NormalizedUserName = "PESCADOLOVER@SKYNET.BE",
                    Email = "PescadoLover@skynet.be",
                    NormalizedEmail = "PESCADOLOVER@SKYNET.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "WGLZXEZUI3NLP8ZWUYK5CFN8XWBT7ATX", //Random string
                    ConcurrencyStamp = "d7280862-2341-462a-8fb5-1380edea1422", //Random guid string
                    Name = "Kelly",
                    LastName = "Vervis",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000022",
                    UserName = "TomVanmarcke@gmail.com",
                    NormalizedUserName = "TOMVANMARCKE@GMAIL.COM",
                    Email = "TomVanmarcke@gmail.com",
                    NormalizedEmail = "TOMVANMARCKE@GMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "OIKDBFPAR5GJKJ91OUAOXNKR1CMLSTFC", //Random string
                    ConcurrencyStamp = "0fc3e5d4-f6ce-4160-aa94-d2acc0be114d", //Random guid string
                    Name = "Marc",
                    LastName = "Vantomme",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000023",
                    UserName = "Loewiloewie@hotmail.com",
                    NormalizedUserName = "LOEWILOEWIE@HOTMAIL.COM",
                    Email = "Loewiloewie@hotmail.com",
                    NormalizedEmail = "LOEWILOEWIE@HOTMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "F0SRUYTP4OF6TSFD3CNJBX5ECAJFPPFZ", //Random string
                    ConcurrencyStamp = "8f42511c-f74f-442c-a8f2-28b10d2bc114", //Random guid string
                    Name = "Louis",
                    LastName = "Decruy",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000024",
                    UserName = "Giezijtem@skynet.be",
                    NormalizedUserName = "GIEZIJTEM@SKYNET.BE",
                    Email = "Giezijtem@skynet.be",
                    NormalizedEmail = "GIEZIJTEM@SKYNET.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "PHLIIUHLZLGB2UTDD2LHUFROZ7TDQAD7", //Random string
                    ConcurrencyStamp = "b52a849c-4b01-4dda-ac2f-30f6b08fe075", //Random guid string
                    Name = "Ben",
                    LastName = "Emnie",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000025",
                    UserName = "ConnieBeter@gmail.com",
                    NormalizedUserName = "CONNIEBETER@GMAIL.COM",
                    Email = "ConnieBeter@gmail.com",
                    NormalizedEmail = "CONNIEBETER@GMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "FWM36IDUG00055IF56RZWA2CR9OYCVB3", //Random string
                    ConcurrencyStamp = "018aba24-a96f-44e9-a058-a047d0bd0b53", //Random guid string
                    Name = "Connie",
                    LastName = "Moeleker",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000026",
                    UserName = "GezondePeter@telenet.be",
                    NormalizedUserName = "GEZONDEPETER@TELENET.BE",
                    Email = "GezondePeter@telenet.be",
                    NormalizedEmail = "GEZONDEPETER@TELENET.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "TJLKW00301EENWVWL2MCPLTCU18IT7XY", //Random string
                    ConcurrencyStamp = "bc117b43-d867-4f86-8ac4-8d4efc2820c4", //Random guid string
                    Name = "Peter",
                    LastName = "Celie",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000027",
                    UserName = "Bennernie@skynet.be",
                    NormalizedUserName = "BENNERNIE@SKYNET.BE",
                    Email = "Bennernie@skynet.be",
                    NormalizedEmail = "BENNERNIE@SKYNET.BE",
                    EmailConfirmed = true,
                    SecurityStamp = "KXW8TS8VIEG0BL1OIA7U2PASSALDXMV3", //Random string
                    ConcurrencyStamp = "1993d307-e257-4e29-8487-b230037199aa", //Random guid string
                    Name = "Benny",
                    LastName = "Thuys",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000028",
                    UserName = "Thebestbusker@london.com",
                    NormalizedUserName = "THEBESTBUSKER@LONDON.COM",
                    Email = "Thebestbusker@london.com",
                    NormalizedEmail = "THEBESTBUSKER@LONDON.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "VRVLNRMUMHA6IADTQ7CO9VCIMVX4OMO5", //Random string
                    ConcurrencyStamp = "b017e971-0a03-4aa0-86e5-b3d1c603d64b", //Random guid string
                    Name = "Cam",
                    LastName = "Cole",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000029",
                    UserName = "CoronaTopper@gmail.com",
                    NormalizedUserName = "CORONATOPPER@GMAIL.COM",
                    Email = "CoronaTopper@gmail.com",
                    NormalizedEmail = "CORONATOPPER@GMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "W7IEDSQT3GEVZWUOTXG8CL1PI3K6MXU7", //Random string
                    ConcurrencyStamp = "50d8c368-d7f1-4e3f-8216-6ba5c5e3e76a", //Random guid string
                    Name = "Claude",
                    LastName = "Root",
                    Password = UserPassword
                },
                new User
                {
                    Id = "00000000-0000-0000-0000-000000000030",
                    UserName = "rapgewoon@hotmail.com",
                    NormalizedUserName = "RAPGEWOON@HOTMAIL.COM",
                    Email = "rapgewoon@hotmail.com",
                    NormalizedEmail = "RAPGEWOON@HOTMAIL.COM",
                    EmailConfirmed = true,
                    SecurityStamp = "JF6GSUYRRSWNWXY9Z1HUJLK1GUQREXOO", //Random string
                    ConcurrencyStamp = "55690745-3bfd-43ad-abbe-af37f549182c", //Random guid string
                    Name = "Eve",
                    LastName = "Wenne",
                    Password = UserPassword
                }
            };

            IPasswordHasher<User> passwordHasher = new PasswordHasher<User>();

            Users.ForEach(u => u.PasswordHash = passwordHasher.HashPassword(u, UserPassword));

            modelBuilder.Entity<User>().HasData(Users);
        }
    }
}
