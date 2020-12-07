﻿using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace ALE.TimeRegistration.Core.Entities
{
    public class Message : EntityBase
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public Guid TaskId { get; set; }
        public AppTask Task { get; set; }
        [Required]
        public Guid SenderId { get; set; }
        public User Sender { get; set; }
        [Required]
        public Guid ReceiverId { get; set; }
        public User Receiver { get; set; }
    }
}
