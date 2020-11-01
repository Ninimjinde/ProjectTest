using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class UserTask
    {
        public Guid UserId { get; set; }
        public Guid TaskId { get; set; }
        public User User { get; set; }
        public Task Task { get; set; }
    }
}
