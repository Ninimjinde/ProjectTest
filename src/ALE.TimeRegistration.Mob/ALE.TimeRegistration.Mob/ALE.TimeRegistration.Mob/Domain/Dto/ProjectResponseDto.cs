using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Mob.Domain
{
    public class ProjectResponseDto : DtoBase
    {
        public string Name { get; set; }
        public ICollection<AppTaskResponseDto> Tasks { get; set; }
    }
}
