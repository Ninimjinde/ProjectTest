using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Mob.Domain
{
    public class PictureResponseDto : DtoBase
    {
        public Uri Image { get; set; }
        public AppTaskResponseDto Task { get; set; }
    }
}
