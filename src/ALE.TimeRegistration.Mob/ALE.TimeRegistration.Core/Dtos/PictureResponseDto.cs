using ALE.TimeRegistration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class PictureResponseDto : DtoBase
    {
        public Uri Image { get; set; }
        public Task Task { get; set; }
    }
}
