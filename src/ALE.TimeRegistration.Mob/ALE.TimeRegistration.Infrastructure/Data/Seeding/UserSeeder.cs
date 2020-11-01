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
                new User { DateOfBirth = DateTime.Parse("01/05/1985 0:00:00"), LastName = "Cash", Name = "Johnny", Email = "aboynamedsue@JCash.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("28/12/1972 0:00:00"), LastName = "Kant", Name = "Elke", Email = "EchtElkeKant@hotmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("03/11/1989 0:00:00"), LastName = "Pot", Name = "Jack", Email = "Ialwayswin@gmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("15/03/1984 0:00:00"), LastName = "Vanvoren", Name = "Erna", Email = "ErnaVanvoren@hotmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("02/08/1981 0:00:00"), LastName = "Vangenechte", Name = "Roger", Email = "RogerDoeniemee@telenet.be", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("03/04/1990 0:00:00"), LastName = "Verstraete", Name = "Karel", Email = "CharlesDurue@hotmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("11/09/1993 0:00:00"), LastName = "Vanbelleghem", Name = "Katleen", Email = "Katringring@skynet.be", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("02/11/1984 0:00:00"), LastName = "Guapo", Name = "Edwardo", Email = "SnelnEddy@hotmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("12/01/1977 0:00:00"), LastName = "Degught", Name = "Andy", Email = "Andy123@gmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("01/03/1972 0:00:00"), LastName = "Demain", Name = "Annie", Email = "IloveyouTomorrow@hotmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("13/02/1985 0:00:00"), LastName = "Parrish", Name = "Russ", Email = "Satchel@steelpanther.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("28/07/1986 0:00:00"), LastName = "Pijpers", Name = "Maarten", Email = "DePijpVanMaarten@gmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("04/05/1989 0:00:00"), LastName = "Vaneende", Name = "Edward", Email = "EdwardLeCanard@hotmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("14/12/1983 0:00:00"), LastName = "Declerk", Name = "Yoeri", Email = "DeYoeri@gmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("27/10/1978 0:00:00"), LastName = "Thee", Name = "Camille", Email = "CalmingCamille@telenet.be", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("15/09/1991 0:00:00"), LastName = "Homme", Name = "Josh", Email = "Thebestginger@qotsa.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("26/08/1999 0:00:00"), LastName = "Uytebroeck", Name = "Piet", Email = "Zwaffelaere@gmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("17/07/1978 0:00:00"), LastName = "Lefort", Name = "Jan", Email = "SterkeJan33@pandora.be", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("25/01/1970 0:00:00"), LastName = "Gessof", Name = "Rita", Email = "RietjeGessof@hotmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("18/02/1993 0:00:00"), LastName = "Lambregt", Name = "Willy", Email = "willywilly@thescabs.be", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("24/03/1989 0:00:00"), LastName = "Vervis", Name = "Kelly", Email = "PescadoLover@skynet.be", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("19/04/1998 0:00:00"), LastName = "Vantomme", Name = "Marc", Email = "TomVanmarcke@gmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("23/05/1997 0:00:00"), LastName = "Decruy", Name = "Louis", Email = "Loewiloewie@hotmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("20/06/1984 0:00:00"), LastName = "Emnie", Name = "Ben", Email = "Giezijtem@skynet.be", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("01/07/1996 0:00:00"), LastName = "Moeleker", Name = "Connie", Email = "ConnieBeter@gmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("21/08/1999 0:00:00"), LastName = "Celie", Name = "Peter", Email = "GezondePeter@telenet.be", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("02/09/1992 0:00:00"), LastName = "Thuys", Name = "Benny", Email = "Bennernie@skynet.be", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("23/10/1978 0:00:00"), LastName = "Cole", Name = "Cam", Email = "Thebestbusker@london.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("03/11/1987 0:00:00"), LastName = "Root", Name = "Claude", Email = "CoronaTopper@gmail.com", Password = "TimeReg2020" },
                new User { DateOfBirth = DateTime.Parse("24/12/1981 0:00:00"), LastName = "Wenne", Name = "Eve", Email = "rapgewoon@hotmail.com", Password = "TimeReg2020" }
                );
        }
    }
}
