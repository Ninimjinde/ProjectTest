using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class Project : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public ICollection<AppTask> Tasks { get; set; }
      
    }
}
