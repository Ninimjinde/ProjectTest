using System;

namespace ALE.TimeRegistration.Core.Entities
{
    public class UserTask
    {
        public string UserId { get; set; }
        public Guid TaskId { get; set; }
        public User User { get; set; }
        public AppTask Task { get; set; }
    }
}
