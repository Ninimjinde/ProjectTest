using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ALE.TimeRegistration.Core.Entities
{
    public class Picture : EntityBase
    {
        [Required]
        public Uri Image { get; set; }
        [Required]
        public Guid TaskId { get; set; }
        public AppTask Task { get; set; }
    }
}
