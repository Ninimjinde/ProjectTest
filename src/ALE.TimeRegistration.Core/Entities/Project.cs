using ALE.TimeRegistration.Core.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ALE.TimeRegistration.Core.Entities
{
    public class Project : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public ICollection<AppTask> Tasks { get; set; }

    }
}
