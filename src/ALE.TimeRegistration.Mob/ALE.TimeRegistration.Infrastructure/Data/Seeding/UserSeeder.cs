using ALE.TimeRegistration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Infrastructure.Data.Seeding
{
    public class UserSeeder
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { LastName = "Cash", Name = "Johnny", Email = "aboynamedsue@JCash.com", Password = "TimeReg2020", Id = Guid.Parse("12ba3def-f041-45dd-bb6c-492749f49d89") },
                new User { LastName = "Kant", Name = "Elke", Email = "EchtElkeKant@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("b92e79e5-bde7-4c85-9d85-cbe405b599a9") },
                new User { LastName = "Pot", Name = "Jack", Email = "Ialwayswin@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("e0146a2e-cbec-42cf-8a3c-cfe63b4743e4") },
                new User { LastName = "Vanvoren", Name = "Erna", Email = "ErnaVanvoren@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("a70ba158-7d24-4996-9729-c04645e4123c") },
                new User { LastName = "Vangenechte", Name = "Roger", Email = "RogerDoeniemee@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("5f439b90-1504-470e-a403-b7d98fe5a819") },
                new User { LastName = "Verstraete", Name = "Karel", Email = "CharlesDurue@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("cfe86e67-56e5-4dc6-9ff7-dca5b4b8343f") },
                new User { LastName = "Vanbelleghem", Name = "Katleen", Email = "Katringring@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("9764704d-fbc8-4c4f-9e76-998e927d446e") },
                new User { LastName = "Guapo", Name = "Edwardo", Email = "SnelnEddy@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("b3b83cb1-2b33-4629-95ea-e2a060f172c1") },
                new User { LastName = "Degught", Name = "Andy", Email = "Andy123@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("bb60dc0a-02dd-4357-9973-9cb54cb837ef") },
                new User { LastName = "Demain", Name = "Annie", Email = "IloveyouTomorrow@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("254def70-50a0-40de-a77a-ab2c2591bb89") },
                new User { LastName = "Parrish", Name = "Russ", Email = "Satchel@steelpanther.com", Password = "TimeReg2020", Id = Guid.Parse("f84da3ff-9cc6-49c5-9904-15e431feffe6") },
                new User { LastName = "Pijpers", Name = "Maarten", Email = "DePijpVanMaarten@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("87395ea7-a64c-4878-8f09-c55564d4db12") },
                new User { LastName = "Vaneende", Name = "Edward", Email = "EdwardLeCanard@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("67859443-f004-4779-bfb0-3ad2cfa6a153") },
                new User { LastName = "Declerk", Name = "Yoeri", Email = "DeYoeri@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("1e62ec6c-0f76-4a30-b5c5-15690658930f") },
                new User { LastName = "Thee", Name = "Camille", Email = "CalmingCamille@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("66d7e6a2-404e-4919-b032-abf64cfe691f") },
                new User { LastName = "Homme", Name = "Josh", Email = "Thebestginger@qotsa.com", Password = "TimeReg2020", Id = Guid.Parse("00748570-86f3-42c3-a358-8ea38c706cb8") },
                new User { LastName = "Uytebroeck", Name = "Piet", Email = "Zwaffelaere@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("30a49cd6-9144-40f0-816c-4b1d7a0a766a") },
                new User { LastName = "Lefort", Name = "Jan", Email = "SterkeJan33@pandora.be", Password = "TimeReg2020", Id = Guid.Parse("a9ac8612-f8b7-4344-9042-875b1b916e1a") },
                new User { LastName = "Gessof", Name = "Rita", Email = "RietjeGessof@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("8bc19dd0-6829-49b6-b084-e742cc6403c0") },
                new User { LastName = "Lambregt", Name = "Willy", Email = "willywilly@thescabs.be", Password = "TimeReg2020", Id = Guid.Parse("67859443-f004-4779-bfb0-3ad2cfa6a154") },
                new User { LastName = "Vervis", Name = "Kelly", Email = "PescadoLover@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("1e62ec6c-0f76-4a30-b5c5-15690658930d") },
                new User { LastName = "Vantomme", Name = "Marc", Email = "TomVanmarcke@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("66d7e6a2-404e-4919-b032-abf64cfe691d") },
                new User { LastName = "Decruy", Name = "Louis", Email = "Loewiloewie@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("532d63b6-f0e2-42dd-a205-8daa5548562f") },
                new User { LastName = "Emnie", Name = "Ben", Email = "Giezijtem@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("6cac4bc5-293e-4b8a-836c-04f46a681b2f") },
                new User { LastName = "Moeleker", Name = "Connie", Email = "ConnieBeter@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("0d505c28-9d9a-4252-a212-e8184f1720e0") },
                new User { LastName = "Celie", Name = "Peter", Email = "GezondePeter@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("88328685-37dc-45d7-aef0-a7095dbbf9e1") },
                new User { LastName = "Thuys", Name = "Benny", Email = "Bennernie@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("2d2168e4-f8ff-4809-a3cb-0cac07d05fb0") },
                new User { LastName = "Cole", Name = "Cam", Email = "Thebestbusker@london.com", Password = "TimeReg2020", Id = Guid.Parse("c3120458-e925-4701-a1c2-f96cd89e8780") },
                new User { LastName = "Root", Name = "Claude", Email = "CoronaTopper@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("8ce255f7-bb90-4cfa-b088-7a1a9c22b1ef") },
                new User { LastName = "Wenne", Name = "Eve", Email = "rapgewoon@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("131de448-db99-4b95-b14e-66b914db725e") }
                );
        }
    }
}
