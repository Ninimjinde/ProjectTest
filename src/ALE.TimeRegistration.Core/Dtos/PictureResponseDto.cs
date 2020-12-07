using ALE.TimeRegistration.Core.Entities;
using System;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class PictureResponseDto : DtoBase
    {
        public Uri Image { get; set; }
        public AppTask Task { get; set; }
    }
}
