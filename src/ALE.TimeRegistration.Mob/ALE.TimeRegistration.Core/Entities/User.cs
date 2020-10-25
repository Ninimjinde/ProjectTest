using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<UserProject> UserProjects { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
