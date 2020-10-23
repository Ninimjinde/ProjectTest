using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
     public class Task : EntityBase
    {
        public Project Project { get; set; }
        public string TaskName { get; set; }
        public ICollection<Picture> Pictures { get; set; }
    }
}
