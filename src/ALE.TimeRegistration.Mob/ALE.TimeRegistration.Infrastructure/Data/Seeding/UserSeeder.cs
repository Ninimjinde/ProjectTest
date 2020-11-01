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
                new User { DateOfBirth = DateTime.Parse("01/05/1985 0:00:00"), LastName = "Cash", Name = "Johnny", Email = "aboynamedsue@JCash.com", Password = "TimeReg2020", Id = Guid.Parse("12ba3def-f041-45dd-bb6c-492749f49d89") },
                new User { DateOfBirth = DateTime.Parse("28/12/1972 0:00:00"), LastName = "Kant", Name = "Elke", Email = "EchtElkeKant@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("b92e79e5-bde7-4c85-9d85-cbe405b599a9") },
                new User { DateOfBirth = DateTime.Parse("03/11/1989 0:00:00"), LastName = "Pot", Name = "Jack", Email = "Ialwayswin@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("e0146a2e-cbec-42cf-8a3c-cfe63b4743e4") },
                new User { DateOfBirth = DateTime.Parse("15/03/1984 0:00:00"), LastName = "Vanvoren", Name = "Erna", Email = "ErnaVanvoren@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("a70ba158-7d24-4996-9729-c04645e4123c") },
                new User { DateOfBirth = DateTime.Parse("02/08/1981 0:00:00"), LastName = "Vangenechte", Name = "Roger", Email = "RogerDoeniemee@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("5f439b90-1504-470e-a403-b7d98fe5a819") },
                new User { DateOfBirth = DateTime.Parse("03/04/1990 0:00:00"), LastName = "Verstraete", Name = "Karel", Email = "CharlesDurue@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("cfe86e67-56e5-4dc6-9ff7-dca5b4b8343f") },
                new User { DateOfBirth = DateTime.Parse("11/09/1993 0:00:00"), LastName = "Vanbelleghem", Name = "Katleen", Email = "Katringring@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("9764704d-fbc8-4c4f-9e76-998e927d446e") },
                new User { DateOfBirth = DateTime.Parse("02/11/1984 0:00:00"), LastName = "Guapo", Name = "Edwardo", Email = "SnelnEddy@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("b3b83cb1-2b33-4629-95ea-e2a060f172c1") },
                new User { DateOfBirth = DateTime.Parse("12/01/1977 0:00:00"), LastName = "Degught", Name = "Andy", Email = "Andy123@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("bb60dc0a-02dd-4357-9973-9cb54cb837ef") },
                new User { DateOfBirth = DateTime.Parse("01/03/1972 0:00:00"), LastName = "Demain", Name = "Annie", Email = "IloveyouTomorrow@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("254def70-50a0-40de-a77a-ab2c2591bb89") },
                new User { DateOfBirth = DateTime.Parse("13/02/1985 0:00:00"), LastName = "Parrish", Name = "Russ", Email = "Satchel@steelpanther.com", Password = "TimeReg2020", Id = Guid.Parse("f84da3ff-9cc6-49c5-9904-15e431feffe6") },
                new User { DateOfBirth = DateTime.Parse("28/07/1986 0:00:00"), LastName = "Pijpers", Name = "Maarten", Email = "DePijpVanMaarten@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("87395ea7-a64c-4878-8f09-c55564d4db12") },
                new User { DateOfBirth = DateTime.Parse("04/05/1989 0:00:00"), LastName = "Vaneende", Name = "Edward", Email = "EdwardLeCanard@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("67859443-f004-4779-bfb0-3ad2cfa6a153") },
                new User { DateOfBirth = DateTime.Parse("14/12/1983 0:00:00"), LastName = "Declerk", Name = "Yoeri", Email = "DeYoeri@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("1e62ec6c-0f76-4a30-b5c5-15690658930d") },
                new User { DateOfBirth = DateTime.Parse("27/10/1978 0:00:00"), LastName = "Thee", Name = "Camille", Email = "CalmingCamille@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("66d7e6a2-404e-4919-b032-abf64cfe691d") },
                new User { DateOfBirth = DateTime.Parse("15/09/1991 0:00:00"), LastName = "Homme", Name = "Josh", Email = "Thebestginger@qotsa.com", Password = "TimeReg2020", Id = Guid.Parse("532d63b6-f0e2-42dd-a205-8daa5548562f") },
                new User { DateOfBirth = DateTime.Parse("26/08/1999 0:00:00"), LastName = "Uytebroeck", Name = "Piet", Email = "Zwaffelaere@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("30a49cd6-9144-40f0-816c-4b1d7a0a766a") },
                new User { DateOfBirth = DateTime.Parse("17/07/1978 0:00:00"), LastName = "Lefort", Name = "Jan", Email = "SterkeJan33@pandora.be", Password = "TimeReg2020", Id = Guid.Parse("0d505c28-9d9a-4252-a212-e8184f1720e0") },
                new User { DateOfBirth = DateTime.Parse("25/01/1970 0:00:00"), LastName = "Gessof", Name = "Rita", Email = "RietjeGessof@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("8bc19dd0-6829-49b6-b084-e742cc6403c0") },
                new User { DateOfBirth = DateTime.Parse("18/02/1993 0:00:00"), LastName = "Lambregt", Name = "Willy", Email = "willywilly@thescabs.be", Password = "TimeReg2020", Id = Guid.Parse("67859443-f004-4779-bfb0-3ad2cfa6a153") },
                new User { DateOfBirth = DateTime.Parse("24/03/1989 0:00:00"), LastName = "Vervis", Name = "Kelly", Email = "PescadoLover@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("1e62ec6c-0f76-4a30-b5c5-15690658930d") },
                new User { DateOfBirth = DateTime.Parse("19/04/1998 0:00:00"), LastName = "Vantomme", Name = "Marc", Email = "TomVanmarcke@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("66d7e6a2-404e-4919-b032-abf64cfe691d") },
                new User { DateOfBirth = DateTime.Parse("23/05/1997 0:00:00"), LastName = "Decruy", Name = "Louis", Email = "Loewiloewie@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("532d63b6-f0e2-42dd-a205-8daa5548562f") },
                new User { DateOfBirth = DateTime.Parse("20/06/1984 0:00:00"), LastName = "Emnie", Name = "Ben", Email = "Giezijtem@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("30a49cd6-9144-40f0-816c-4b1d7a0a766a") },
                new User { DateOfBirth = DateTime.Parse("01/07/1996 0:00:00"), LastName = "Moeleker", Name = "Connie", Email = "ConnieBeter@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("0d505c28-9d9a-4252-a212-e8184f1720e0") },
                new User { DateOfBirth = DateTime.Parse("21/08/1999 0:00:00"), LastName = "Celie", Name = "Peter", Email = "GezondePeter@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("8bc19dd0-6829-49b6-b084-e742cc6403c0") },
                new User { DateOfBirth = DateTime.Parse("02/09/1992 0:00:00"), LastName = "Thuys", Name = "Benny", Email = "Bennernie@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("2d2168e4-f8ff-4809-a3cb-0cac07d05fb0") },
                new User { DateOfBirth = DateTime.Parse("23/10/1978 0:00:00"), LastName = "Cole", Name = "Cam", Email = "Thebestbusker@london.com", Password = "TimeReg2020", Id = Guid.Parse("c3120458-e925-4701-a1c2-f96cd89e8780") },
                new User { DateOfBirth = DateTime.Parse("03/11/1987 0:00:00"), LastName = "Root", Name = "Claude", Email = "CoronaTopper@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("8ce255f7-bb90-4cfa-b088-7a1a9c22b1ef") },
                new User { DateOfBirth = DateTime.Parse("24/12/1981 0:00:00"), LastName = "Wenne", Name = "Eve", Email = "rapgewoon@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("131de448-db99-4b95-b14e-66b914db725e") }
                );
        }
    }
}
