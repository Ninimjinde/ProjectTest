using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Mob.Domain
{
    public class MessageResponseDto : DtoBase
    {
        public string Text { get; set; }
        public AppTaskResponseDto Task { get; set; }
        public UserResponsDto Sender { get; set; }
        public UserResponsDto Receiver { get; set; }
    }
}
