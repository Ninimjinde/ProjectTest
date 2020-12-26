using ALE.TimeRegistration.Core.Entities.Base;
using System;

namespace ALE.TimeRegistration.Core.Entities
{
    public class UserTask : EntityBase
    {
        public string UserId { get; set; }
        public Guid TaskId { get; set; }
        public User User { get; set; }
        public AppTask Task { get; set; }
        public TimeSpan WorkTime { get; set; }
        public DateTime WorkDateTime { get; set; }
    }
}
