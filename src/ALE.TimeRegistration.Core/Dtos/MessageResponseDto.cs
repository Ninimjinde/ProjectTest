using ALE.TimeRegistration.Core.Entities;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class MessageResponseDto : DtoBase
    {
        public string Text { get; set; }
        public AppTask Task { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}
