﻿using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class TaskSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new Task { Id = Guid.Parse("84985336-8b0f-4fcc-883f-affa41175ef2"), Info = "Create API Items", ProjectId = Guid.Parse("c9468ac7-468b-4ad2-ad2f-15f42364481a"), TaskName = "Create API", UploadDate = DateTime.Parse("14/10/18 08:30:12"), WorkTime = TimeSpan.Parse("1:18:20") },
                //new Task { Id = Guid.Parse("bdf71f7a-24e4-4332-8f56-650b089fa1f0"), Info = "Fix issues Items API", ProjectId = Guid.Parse("c9468ac7-468b-4ad2-ad2f-15f42364481a"), TaskName = "API issues", UploadDate = DateTime.Parse("15/10/18 11:30:12"), WorkTime = TimeSpan.Parse("2:19:28") },
                //new Task { Id = Guid.Parse("b5edeb11-3a16-4f1e-8820-94aeb21ba0d7"), Info = "Create new properties Item object", ProjectId = Guid.Parse("c9468ac7-468b-4ad2-ad2f-15f42364481a"), TaskName = "Create properties", UploadDate = DateTime.Parse("18/10/18 09:30:12"), WorkTime = TimeSpan.Parse("0:28:30") },
                //new Task { Id = Guid.Parse("3e3a9323-2f38-4e69-80fe-053f5d2f8c35"), Info = "Link Item to new API vendor", ProjectId = Guid.Parse("c9468ac7-468b-4ad2-ad2f-15f42364481a"), TaskName = "API vendor link", UploadDate = DateTime.Parse("19/10/18 08:35:12"), WorkTime = TimeSpan.Parse("0:08:40") },
                //new Task { Id = Guid.Parse("33567ab4-f1e7-48a1-b5e8-b3e4eeecd6a4"), Info = "Migrate objects to database", ProjectId = Guid.Parse("e8a33c03-0ecf-41ef-8ec6-88cf7773564e"), TaskName = "migrate objects", UploadDate = DateTime.Parse("14/08/19 08:30:12"), WorkTime = TimeSpan.Parse("2:35:50") },
                //new Task { Id = Guid.Parse("1fd57179-6a38-43ee-ace3-edbce12f7bb0"), Info = "Create all API's for website", ProjectId = Guid.Parse("e8a33c03-0ecf-41ef-8ec6-88cf7773564e"), TaskName = "create API's", UploadDate = DateTime.Parse("15/08/19 08:30:12"), WorkTime = TimeSpan.Parse("4:30:20") },
                //new Task { Id = Guid.Parse("c1a7d6ae-08ba-4860-9537-484ae3459ddc"), Info = "Create full working website", ProjectId = Guid.Parse("e8a33c03-0ecf-41ef-8ec6-88cf7773564e"), TaskName = "Website", UploadDate = DateTime.Parse("20/09/19 10:30:12"), WorkTime = TimeSpan.Parse("21:44:30") },
                //new Task { Id = Guid.Parse("f8c4bb72-210a-4e30-b24c-4157f1b0f9e2"), Info = "Finish website", ProjectId = Guid.Parse("e8a33c03-0ecf-41ef-8ec6-88cf7773564e"), TaskName = "finish website", UploadDate = DateTime.Parse("23/09/19 08:30:12"), WorkTime = TimeSpan.Parse("3:18:10") },
                //new Task { Id = Guid.Parse("d2dbab93-70b7-4ba6-8738-a03c3d1505ee"), Info = "Automate pricing and promo", ProjectId = Guid.Parse("e8a33c03-0ecf-41ef-8ec6-88cf7773564e"), TaskName = "automate", UploadDate = DateTime.Parse("02/10/19 08:30:12"), WorkTime = TimeSpan.Parse("5:05:00") },
                //new Task { Id = Guid.Parse("e157259c-1324-478c-8e8b-aa7c5672b056"), Info = "Upload data for demo", ProjectId = Guid.Parse("557e26b7-e891-476d-9501-b37da557564c"), TaskName = "demodata", UploadDate = DateTime.Parse("20/02/20 08:30:12"), WorkTime = TimeSpan.Parse("0:31:50") },
                //new Task { Id = Guid.Parse("97ea799b-2366-4896-b334-cde128c11934"), Info = "Migrate data Electrabel to database", ProjectId = Guid.Parse("557e26b7-e891-476d-9501-b37da557564c"), TaskName = "migrate data", UploadDate = DateTime.Parse("21/02/20 08:30:12"), WorkTime = TimeSpan.Parse("8:41:30") },
                //new Task { Id = Guid.Parse("9b9e16f8-f9f2-48ac-a0b7-42575a011e85"), Info = "Fix issues website selling page", ProjectId = Guid.Parse("dd8f7a03-9e88-4333-8aa2-0e227a718c40"), TaskName = "fix website issues", UploadDate = DateTime.Parse("13/05/20 08:30:12"), WorkTime = TimeSpan.Parse("2:15:40") },
                //new Task { Id = Guid.Parse("947837ce-ae4b-4f83-88d4-17ef7b0e92f4"), Info = "Rebuild itempage website and link new products", ProjectId = Guid.Parse("dd8f7a03-9e88-4333-8aa2-0e227a718c40"), TaskName = "itempage", UploadDate = DateTime.Parse("15/05/20 08:30:12"), WorkTime = TimeSpan.Parse("5:07:30") },
                //new Task { Id = Guid.Parse("3a601f89-5c5a-456a-80c2-50c337cf9af9"), Info = "Automate selling process and work with new API's", ProjectId = Guid.Parse("dd8f7a03-9e88-4333-8aa2-0e227a718c40"), TaskName = "automation", UploadDate = DateTime.Parse("17/05/20 08:30:12"), WorkTime = TimeSpan.Parse("6:39:20") },
                //new Task { Id = Guid.Parse("bcb78b11-7487-451f-a781-622b1f594b14"), Info = "Finish all processes and link to website", ProjectId = Guid.Parse("dd8f7a03-9e88-4333-8aa2-0e227a718c40"), TaskName = "finish automation", UploadDate = DateTime.Parse("18/05/20 08:30:12"), WorkTime = TimeSpan.Parse("4:55:10") },
                //new Task { Id = Guid.Parse("f35ba869-1cb2-426e-be51-bb3a1b173220"), Info = "Create new website and link to database", ProjectId = Guid.Parse("aa5448a9-6e7b-4561-9203-af1037428da7"), TaskName = "create website", UploadDate = DateTime.Parse("20/03/18 08:30:12"), WorkTime = TimeSpan.Parse("32:10:00") },
                new Task { Id = Guid.Parse("83ce5bec-f859-4425-bb53-56de4502c2a9"), Info = "Update al items in database", ProjectId = Guid.Parse("aa5448a9-6e7b-4561-9203-af1037428da7"), TaskName = "update items", UploadDate = DateTime.Parse("25/03/18 08:30:12"), WorkTime = TimeSpan.Parse("1:08:15") }
                //new Task { Id = Guid.Parse("a1b3615f-a8c6-49a2-bb7b-121305615782"), Info = "Automate promo's and guid for admin", ProjectId = Guid.Parse("aa5448a9-6e7b-4561-9203-af1037428da7"), TaskName = "promo's", UploadDate = DateTime.Parse("26/03/18 08:30:12"), WorkTime = TimeSpan.Parse("2:01:35") },
                //new Task { Id = Guid.Parse("08f00eea-d345-4574-be4e-73f86c56726b"), Info = "Upload data and create database", ProjectId = Guid.Parse("8893fc60-83c0-4c1f-ad20-7cd3da784d75"), TaskName = "upload data", UploadDate = DateTime.Parse("14/08/18 08:30:12"), WorkTime = TimeSpan.Parse("3:00:15") },
                //new Task { Id = Guid.Parse("6cfd027b-2af2-4424-8a5d-8235d216f1a8"), Info = "Upload data and create database", ProjectId = Guid.Parse("f8cb37ec-0150-4ee5-ae91-bab50b2c7b55"), TaskName = "upload data", UploadDate = DateTime.Parse("12/07/20 08:30:12"), WorkTime = TimeSpan.Parse("4:47:12") },
                //new Task { Id = Guid.Parse("12e02aac-6a7a-49a9-bf18-6e41ecf4075c"), Info = "Link API's to new database", ProjectId = Guid.Parse("f8cb37ec-0150-4ee5-ae91-bab50b2c7b55"), TaskName = "link API's", UploadDate = DateTime.Parse("13/07/20 08:30:12"), WorkTime = TimeSpan.Parse("0:35:38") },
                //new Task { Id = Guid.Parse("a9d58347-2def-479f-8653-bb765d158308"), Info = "Fix issues with order page on website", ProjectId = Guid.Parse("8aaf9a52-cbc9-41e9-b6d6-56b975b26bb8"), TaskName = "order page", UploadDate = DateTime.Parse("13/10/20 08:30:12"), WorkTime = TimeSpan.Parse("1:26:39") },
                //new Task { Id = Guid.Parse("49745c24-227e-4385-bcba-ed491b62f922"), Info = "Create link order page and new billing page customer and automate proces", ProjectId = Guid.Parse("8aaf9a52-cbc9-41e9-b6d6-56b975b26bb8"), TaskName = "link order page", UploadDate = DateTime.Parse("15/10/20 08:30:12"), WorkTime = TimeSpan.Parse("2:46:40") },
                //new Task { Id = Guid.Parse("06868a16-f909-4160-9924-982a08287083"), Info = "Fix issue billing page", ProjectId = Guid.Parse("8aaf9a52-cbc9-41e9-b6d6-56b975b26bb8"), TaskName = "issue billing", UploadDate = DateTime.Parse("16/10/20 08:30:12"), WorkTime = TimeSpan.Parse("0:51:41") },
                //new Task { Id = Guid.Parse("bc26bd93-775d-4ac0-aba2-339d0575f8c4"), Info = "Create new order page for customers Europe", ProjectId = Guid.Parse("e641caa7-ab53-42b6-a433-6a1c46ce4f8f"), TaskName = "order page", UploadDate = DateTime.Parse("05/11/19 08:30:12"), WorkTime = TimeSpan.Parse("1:08:42") },
                //new Task { Id = Guid.Parse("1e5f5b46-21c4-4ce6-a488-c1d9256dccbf"), Info = "Create API for database to link with order page", ProjectId = Guid.Parse("e641caa7-ab53-42b6-a433-6a1c46ce4f8f"), TaskName = "API orderpage", UploadDate = DateTime.Parse("06/11/19 08:30:12"), WorkTime = TimeSpan.Parse("3:06:35") },
                //new Task { Id = Guid.Parse("3545b234-ebd1-490f-87be-e2ffaf27f21b"), Info = "Create new page for customer portal", ProjectId = Guid.Parse("998ebe9e-c536-4d27-8592-1056a6515fbe"), TaskName = "customer portal", UploadDate = DateTime.Parse("08/11/19 08:30:12"), WorkTime = TimeSpan.Parse("2:19:18") },
                //new Task { Id = Guid.Parse("783f92cc-1371-4b1a-9546-ea8286ee3f76"), Info = "Fix issues customer portal", ProjectId = Guid.Parse("998ebe9e-c536-4d27-8592-1056a6515fbe"), TaskName = "issues customer portal", UploadDate = DateTime.Parse("10/11/19 08:30:12"), WorkTime = TimeSpan.Parse("0:20:19") },
                //new Task { Id = Guid.Parse("bcec176c-6e42-4d4f-a64b-02b1d3d9388f"), Info = "Create API Items and link to database", ProjectId = Guid.Parse("11f97681-bb21-4622-a034-c3ef282dc78e"), TaskName = "API items", UploadDate = DateTime.Parse("10/02/20 08:30:12"), WorkTime = TimeSpan.Parse("3:24:12") },
                //new Task { Id = Guid.Parse("60ff61ee-4b99-4903-8b97-946ce65582a1"), Info = "Fix app issues for customer login page", ProjectId = Guid.Parse("0b5b0699-2d15-46a5-a60a-9f4dd0f9e8b0"), TaskName = "app issues", UploadDate = DateTime.Parse("08/04/19 08:30:12"), WorkTime = TimeSpan.Parse("2:35:35") },
                //new Task { Id = Guid.Parse("2e831816-ff96-4d8b-ac00-3a812d043a51"), Info = "Create full working website", ProjectId = Guid.Parse("b89508f1-2935-44b0-aea3-3282850d3814"), TaskName = "Website", UploadDate = DateTime.Parse("20/06/20 08:30:12"), WorkTime = TimeSpan.Parse("7:47:47") },
                //new Task { Id = Guid.Parse("66bc3260-e00c-435d-aa5f-c36a43e315c2"), Info = "Create full working website", ProjectId = Guid.Parse("1ff6ecc8-faa6-4128-bfe2-28a44455fd73"), TaskName = "Website", UploadDate = DateTime.Parse("15/11/19 08:30:12"), WorkTime = TimeSpan.Parse("10:35:41") },
                //new Task { Id = Guid.Parse("ffd59629-c4a5-4c88-afd2-ece82607095c"), Info = "Create full working website", ProjectId = Guid.Parse("62600880-5959-40f1-902c-9d9f8accc795"), TaskName = "Website", UploadDate = DateTime.Parse("10/10/18 08:30:12"), WorkTime = TimeSpan.Parse("11:31:42") }
                );
        }
    }
}
