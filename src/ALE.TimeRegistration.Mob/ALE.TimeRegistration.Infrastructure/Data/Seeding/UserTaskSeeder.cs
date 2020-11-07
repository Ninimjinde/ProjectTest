using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class UserTaskSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTask>().HasData(
                new UserTask { TaskId = Guid.Parse("84985336-8b0f-4fcc-883f-affa41175ef2"), UserId = Guid.Parse("cfe86e67-56e5-4dc6-9ff7-dca5b4b8343f") },
                new UserTask { TaskId = Guid.Parse("bdf71f7a-24e4-4332-8f56-650b089fa1f0"), UserId = Guid.Parse("9764704d-fbc8-4c4f-9e76-998e927d446e") },
                new UserTask { TaskId = Guid.Parse("b5edeb11-3a16-4f1e-8820-94aeb21ba0d7"), UserId = Guid.Parse("b3b83cb1-2b33-4629-95ea-e2a060f172c1") },
                new UserTask { TaskId = Guid.Parse("3e3a9323-2f38-4e69-80fe-053f5d2f8c35"), UserId = Guid.Parse("bb60dc0a-02dd-4357-9973-9cb54cb837ef") },
                new UserTask { TaskId = Guid.Parse("33567ab4-f1e7-48a1-b5e8-b3e4eeecd6a4"), UserId = Guid.Parse("254def70-50a0-40de-a77a-ab2c2591bb89") },
                new UserTask { TaskId = Guid.Parse("1fd57179-6a38-43ee-ace3-edbce12f7bb0"), UserId = Guid.Parse("f84da3ff-9cc6-49c5-9904-15e431feffe6") },
                new UserTask { TaskId = Guid.Parse("c1a7d6ae-08ba-4860-9537-484ae3459ddc"), UserId = Guid.Parse("87395ea7-a64c-4878-8f09-c55564d4db12") },
                new UserTask { TaskId = Guid.Parse("f8c4bb72-210a-4e30-b24c-4157f1b0f9e2"), UserId = Guid.Parse("67859443-f004-4779-bfb0-3ad2cfa6a154") },
                new UserTask { TaskId = Guid.Parse("d2dbab93-70b7-4ba6-8738-a03c3d1505ee"), UserId = Guid.Parse("1e62ec6c-0f76-4a30-b5c5-15690658930d") },
                new UserTask { TaskId = Guid.Parse("e157259c-1324-478c-8e8b-aa7c5672b056"), UserId = Guid.Parse("66d7e6a2-404e-4919-b032-abf64cfe691d") },
                new UserTask { TaskId = Guid.Parse("97ea799b-2366-4896-b334-cde128c11934"), UserId = Guid.Parse("532d63b6-f0e2-42dd-a205-8daa5548562f") },
                new UserTask { TaskId = Guid.Parse("9b9e16f8-f9f2-48ac-a0b7-42575a011e85"), UserId = Guid.Parse("30a49cd6-9144-40f0-816c-4b1d7a0a766a") },
                new UserTask { TaskId = Guid.Parse("947837ce-ae4b-4f83-88d4-17ef7b0e92f4"), UserId = Guid.Parse("0d505c28-9d9a-4252-a212-e8184f1720e0") },
                new UserTask { TaskId = Guid.Parse("3a601f89-5c5a-456a-80c2-50c337cf9af9"), UserId = Guid.Parse("8bc19dd0-6829-49b6-b084-e742cc6403c0") },
                new UserTask { TaskId = Guid.Parse("bcb78b11-7487-451f-a781-622b1f594b14"), UserId = Guid.Parse("67859443-f004-4779-bfb0-3ad2cfa6a154") },
                new UserTask { TaskId = Guid.Parse("f35ba869-1cb2-426e-be51-bb3a1b173220"), UserId = Guid.Parse("1e62ec6c-0f76-4a30-b5c5-15690658930d") },
                new UserTask { TaskId = Guid.Parse("83ce5bec-f859-4425-bb53-56de4502c2a9"), UserId = Guid.Parse("66d7e6a2-404e-4919-b032-abf64cfe691d") },
                new UserTask { TaskId = Guid.Parse("a1b3615f-a8c6-49a2-bb7b-121305615782"), UserId = Guid.Parse("532d63b6-f0e2-42dd-a205-8daa5548562f") },
                new UserTask { TaskId = Guid.Parse("08f00eea-d345-4574-be4e-73f86c56726b"), UserId = Guid.Parse("30a49cd6-9144-40f0-816c-4b1d7a0a766a") },
                new UserTask { TaskId = Guid.Parse("6cfd027b-2af2-4424-8a5d-8235d216f1a8"), UserId = Guid.Parse("0d505c28-9d9a-4252-a212-e8184f1720e0") },
                new UserTask { TaskId = Guid.Parse("12e02aac-6a7a-49a9-bf18-6e41ecf4075c"), UserId = Guid.Parse("8bc19dd0-6829-49b6-b084-e742cc6403c0") },
                new UserTask { TaskId = Guid.Parse("a9d58347-2def-479f-8653-bb765d158308"), UserId = Guid.Parse("2d2168e4-f8ff-4809-a3cb-0cac07d05fb0") },
                new UserTask { TaskId = Guid.Parse("49745c24-227e-4385-bcba-ed491b62f922"), UserId = Guid.Parse("c3120458-e925-4701-a1c2-f96cd89e8780") },
                new UserTask { TaskId = Guid.Parse("06868a16-f909-4160-9924-982a08287083"), UserId = Guid.Parse("8ce255f7-bb90-4cfa-b088-7a1a9c22b1ef") },
                new UserTask { TaskId = Guid.Parse("bc26bd93-775d-4ac0-aba2-339d0575f8c4"), UserId = Guid.Parse("131de448-db99-4b95-b14e-66b914db725e") },
                new UserTask { TaskId = Guid.Parse("1e5f5b46-21c4-4ce6-a488-c1d9256dccbf"), UserId = Guid.Parse("cfe86e67-56e5-4dc6-9ff7-dca5b4b8343f") },
                new UserTask { TaskId = Guid.Parse("3545b234-ebd1-490f-87be-e2ffaf27f21b"), UserId = Guid.Parse("cfe86e67-56e5-4dc6-9ff7-dca5b4b8343f") },
                new UserTask { TaskId = Guid.Parse("783f92cc-1371-4b1a-9546-ea8286ee3f76"), UserId = Guid.Parse("9764704d-fbc8-4c4f-9e76-998e927d446e") },
                new UserTask { TaskId = Guid.Parse("bcec176c-6e42-4d4f-a64b-02b1d3d9388f"), UserId = Guid.Parse("9764704d-fbc8-4c4f-9e76-998e927d446e") },
                new UserTask { TaskId = Guid.Parse("60ff61ee-4b99-4903-8b97-946ce65582a1"), UserId = Guid.Parse("9764704d-fbc8-4c4f-9e76-998e927d446e") },
                new UserTask { TaskId = Guid.Parse("2e831816-ff96-4d8b-ac00-3a812d043a51"), UserId = Guid.Parse("b3b83cb1-2b33-4629-95ea-e2a060f172c1") },
                new UserTask { TaskId = Guid.Parse("66bc3260-e00c-435d-aa5f-c36a43e315c2"), UserId = Guid.Parse("b3b83cb1-2b33-4629-95ea-e2a060f172c1") },
                new UserTask { TaskId = Guid.Parse("ffd59629-c4a5-4c88-afd2-ece82607095c"), UserId = Guid.Parse("b3b83cb1-2b33-4629-95ea-e2a060f172c1") }
                );
        }
    }
}
