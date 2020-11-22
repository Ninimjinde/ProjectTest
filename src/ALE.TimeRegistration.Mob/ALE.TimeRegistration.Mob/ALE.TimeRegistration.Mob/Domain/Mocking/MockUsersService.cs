using ALE.TimeRegistration.Core.Entities;
using ALE.TimeRegistration.Mob.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ALE.TimeRegistration.Mob.Domain.Mocking
{
    public class MockUsersService : IMobUserService
    {
        private static List<User> userList = new List<User>
        {
                new User { LastName = "Cash", Name = "Johnny", Email = "admin@test.com", Password = "admin123", Id = Guid.Parse("00000000-0000-0000-0000-000000000001") },
                new User { LastName = "Kant", Name = "Elke", Email = "user@test.com", Password = "user123", Id = Guid.Parse("00000000-0000-0000-0000-000000000002") },
                new User { LastName = "Pot", Name = "Jack", Email = "Ialwayswin@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                new User { LastName = "Vanvoren", Name = "Erna", Email = "ErnaVanvoren@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000004") },
                new User { LastName = "Vangenechte", Name = "Roger", Email = "RogerDoeniemee@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                new User { LastName = "Verstraete", Name = "Karel", Email = "CharlesDurue@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000006") },
                new User { LastName = "Vanbelleghem", Name = "Katleen", Email = "Katringring@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000007") },
                new User { LastName = "Guapo", Name = "Edwardo", Email = "SnelnEddy@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000008") },
                new User { LastName = "Degught", Name = "Andy", Email = "Andy123@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000009") },
                new User { LastName = "Demain", Name = "Annie", Email = "IloveyouTomorrow@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000010") },
                new User { LastName = "Parrish", Name = "Russ", Email = "Satchel@steelpanther.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000011") },
                new User { LastName = "Pijpers", Name = "Maarten", Email = "DePijpVanMaarten@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000012") },
                new User { LastName = "Vaneende", Name = "Edward", Email = "EdwardLeCanard@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000013") },
                new User { LastName = "Declerk", Name = "Yoeri", Email = "DeYoeri@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000014") },
                new User { LastName = "Thee", Name = "Camille", Email = "CalmingCamille@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000015") },
                new User { LastName = "Homme", Name = "Josh", Email = "Thebestginger@qotsa.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000016") },
                new User { LastName = "Uytebroeck", Name = "Piet", Email = "Zwaffelaere@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000017") },
                new User { LastName = "Lefort", Name = "Jan", Email = "SterkeJan33@pandora.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000018") },
                new User { LastName = "Gessof", Name = "Rita", Email = "RietjeGessof@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000019") },
                new User { LastName = "Lambregt", Name = "Willy", Email = "willywilly@thescabs.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000020") },
                new User { LastName = "Vervis", Name = "Kelly", Email = "PescadoLover@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000021") },
                new User { LastName = "Vantomme", Name = "Marc", Email = "TomVanmarcke@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000022") },
                new User { LastName = "Decruy", Name = "Louis", Email = "Loewiloewie@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000023") },
                new User { LastName = "Emnie", Name = "Ben", Email = "Giezijtem@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000024") },
                new User { LastName = "Moeleker", Name = "Connie", Email = "ConnieBeter@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000025") },
                new User { LastName = "Celie", Name = "Peter", Email = "GezondePeter@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000026") },
                new User { LastName = "Thuys", Name = "Benny", Email = "Bennernie@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000027") },
                new User { LastName = "Cole", Name = "Cam", Email = "Thebestbusker@london.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000028") },
                new User { LastName = "Root", Name = "Claude", Email = "CoronaTopper@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000029") },
                new User { LastName = "Wenne", Name = "Eve", Email = "rapgewoon@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000030") }
        };


        public async Task<bool> Login(string email, string password)
        {
            bool isValidUser;
            var user = userList.FirstOrDefault(u => u.Email == email);
            if (user.Password == password) { isValidUser = true; } else { isValidUser = false; };
            return await Task.FromResult(isValidUser);
        }
        public async Task<bool> IsAdmin(string email, string password)
        {
            bool isAdmin;
            var user = userList.FirstOrDefault(u => u.Email == email);
            if (user.Password == password & user.Email == "admin@test.com"){ isAdmin = true;} else { isAdmin = false;};
            return await Task.FromResult(isAdmin);
        }


    }
}

