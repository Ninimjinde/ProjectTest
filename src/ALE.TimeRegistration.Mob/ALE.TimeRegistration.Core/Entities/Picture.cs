using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class Picture : EntityBase
    {
        [Required]
        public Uri Image { get; set; }
        [Required]
        public Guid TaskId { get; set; }
        public Task Task { get; set; }
    }
}
