using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class UserRequestDto : DtoBase
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
