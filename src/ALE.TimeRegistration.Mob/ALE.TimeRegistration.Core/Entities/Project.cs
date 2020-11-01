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
        public ICollection<Task> Tasks { get; set; }
      
    }
}
