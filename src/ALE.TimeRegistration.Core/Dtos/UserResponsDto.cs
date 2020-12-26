using System;
using System.Collections.Generic;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class UserResponsDto : DtoBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public TimeSpan TimeWorked { get; set; }
    }
}
