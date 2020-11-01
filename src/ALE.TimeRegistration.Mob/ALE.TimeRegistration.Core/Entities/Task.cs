using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
     public class Task : EntityBase
    {
        public string TaskName { get; set; }
        public string Info { get; set; }
        public TimeSpan WorkTime { get; set; }
        public DateTime UploadDate { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        public ICollection<UserTask> TaskUsers { get; set; }
    }
}
