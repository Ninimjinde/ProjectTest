using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class Project : EntityBase
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public DateTime UploadDate { get; set; }
        public User User { get; set; }
        public Picture Picture { get; set; }
        public TimeSpan WorkTime { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Message> Messages { get; set; }

    }
}
