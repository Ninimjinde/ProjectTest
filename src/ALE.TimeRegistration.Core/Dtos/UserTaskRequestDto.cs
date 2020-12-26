using ALE.TimeRegistration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class UserTaskRequestDto
    {
        public string UserId { get; set; }
        public Guid TaskId { get; set; }
        public TimeSpan WorkTime { get; set; }
        public DateTime WorkDateTime { get; set; }
    }
}
