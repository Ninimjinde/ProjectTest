using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class Message : EntityBase
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public Guid TaskId { get; set; }
        public Task Task { get; set; }
        [Required]
        public Guid SenderId { get; set; }
        public User Sender { get; set; }
        [Required]
        public Guid ReceiverId { get; set; }
        public User Receiver { get; set; }
    }
}
