using ALE.TimeRegistration.Core.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ALE.TimeRegistration.Core.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }
        public ICollection<Message> SendMessages { get; set; }
        public ICollection<UserTask> UserTasks { get; set; }
    }
}
