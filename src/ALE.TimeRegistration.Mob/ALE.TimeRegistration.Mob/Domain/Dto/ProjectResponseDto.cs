using System.Collections.Generic;

namespace ALE.TimeRegistration.Mob.Domain
{
    public class ProjectResponseDto : DtoBase
    {
        public string Name { get; set; }
        public ICollection<AppTaskResponseDto> Tasks { get; set; }
    }
}
