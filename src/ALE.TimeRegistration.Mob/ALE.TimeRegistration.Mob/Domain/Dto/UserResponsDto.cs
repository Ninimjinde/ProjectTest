using System;
using System.Collections.Generic;

namespace ALE.TimeRegistration.Mob.Domain
{
    public class UserResponsDto : DtoBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<string> Tasks { get; set; }
        public TimeSpan TimeWorked { get; set; }
    }
}
