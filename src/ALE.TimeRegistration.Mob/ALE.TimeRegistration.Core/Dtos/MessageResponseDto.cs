using ALE.TimeRegistration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class MessageResponseDto : DtoBase
    {
        public string Text { get; set; }
        public Task Task { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}
