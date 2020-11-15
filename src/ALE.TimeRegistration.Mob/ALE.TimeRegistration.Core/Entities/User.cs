using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class User : EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }

        public ICollection<Message> ReceivedMessages { get; set; }
        public ICollection<Message> SendMessages { get; set; }
        public ICollection<UserTask> UserTasks { get; set; }
    }
}
