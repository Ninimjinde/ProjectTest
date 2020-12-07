using ALE.TimeRegistration.Mob.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALE.TimeRegistration.Mob.Domain.Mocking
{
    public class MockUsersService : IMobUserService
    {
        private static List<UserResponsDto> userList = new List<UserResponsDto>
        {
                new UserResponsDto { LastName = "Cash", Name = "Johnny", Email = "admin@test.com", Password = "admin123", Id = Guid.Parse("00000000-0000-0000-0000-000000000001") },
                new UserResponsDto { LastName = "Kant", Name = "Elke", Email = "user@test.com", Password = "user123", Id = Guid.Parse("00000000-0000-0000-0000-000000000002") },
                new UserResponsDto { LastName = "Pot", Name = "Jack", Email = "Ialwayswin@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000003") },
                new UserResponsDto { LastName = "Vanvoren", Name = "Erna", Email = "ErnaVanvoren@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000004") },
                new UserResponsDto { LastName = "Vangenechte", Name = "Roger", Email = "RogerDoeniemee@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000005") },
                new UserResponsDto { LastName = "Verstraete", Name = "Karel", Email = "CharlesDurue@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000006") },
                new UserResponsDto { LastName = "Vanbelleghem", Name = "Katleen", Email = "Katringring@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000007") },
                new UserResponsDto { LastName = "Guapo", Name = "Edwardo", Email = "SnelnEddy@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000008") },
                new UserResponsDto { LastName = "Degught", Name = "Andy", Email = "Andy123@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000009") },
                new UserResponsDto { LastName = "Demain", Name = "Annie", Email = "IloveyouTomorrow@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000010") },
                new UserResponsDto { LastName = "Parrish", Name = "Russ", Email = "Satchel@steelpanther.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000011") },
                new UserResponsDto { LastName = "Pijpers", Name = "Maarten", Email = "DePijpVanMaarten@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000012") },
                new UserResponsDto { LastName = "Vaneende", Name = "Edward", Email = "EdwardLeCanard@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000013") },
                new UserResponsDto { LastName = "Declerk", Name = "Yoeri", Email = "DeYoeri@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000014") },
                new UserResponsDto { LastName = "Thee", Name = "Camille", Email = "CalmingCamille@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000015") },
                new UserResponsDto { LastName = "Homme", Name = "Josh", Email = "Thebestginger@qotsa.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000016") },
                new UserResponsDto { LastName = "Uytebroeck", Name = "Piet", Email = "Zwaffelaere@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000017") },
                new UserResponsDto { LastName = "Lefort", Name = "Jan", Email = "SterkeJan33@pandora.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000018") },
                new UserResponsDto { LastName = "Gessof", Name = "Rita", Email = "RietjeGessof@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000019") },
                new UserResponsDto { LastName = "Lambregt", Name = "Willy", Email = "willywilly@thescabs.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000020") },
                new UserResponsDto { LastName = "Vervis", Name = "Kelly", Email = "PescadoLover@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000021") },
                new UserResponsDto { LastName = "Vantomme", Name = "Marc", Email = "TomVanmarcke@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000022") },
                new UserResponsDto { LastName = "Decruy", Name = "Louis", Email = "Loewiloewie@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000023") },
                new UserResponsDto { LastName = "Emnie", Name = "Ben", Email = "Giezijtem@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000024") },
                new UserResponsDto { LastName = "Moeleker", Name = "Connie", Email = "ConnieBeter@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000025") },
                new UserResponsDto { LastName = "Celie", Name = "Peter", Email = "GezondePeter@telenet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000026") },
                new UserResponsDto { LastName = "Thuys", Name = "Benny", Email = "Bennernie@skynet.be", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000027") },
                new UserResponsDto { LastName = "Cole", Name = "Cam", Email = "Thebestbusker@london.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000028") },
                new UserResponsDto { LastName = "Root", Name = "Claude", Email = "CoronaTopper@gmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000029") },
                new UserResponsDto { LastName = "Wenne", Name = "Eve", Email = "rapgewoon@hotmail.com", Password = "TimeReg2020", Id = Guid.Parse("00000000-0000-0000-0000-000000000030") }
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
            if (user.Password == password & user.Email == "admin@test.com") { isAdmin = true; } else { isAdmin = false; };
            return await Task.FromResult(isAdmin);
        }

    }
}

