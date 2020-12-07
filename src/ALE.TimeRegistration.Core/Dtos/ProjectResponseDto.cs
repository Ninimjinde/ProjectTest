using System.Collections.Generic;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class ProjectResponseDto : DtoBase
    {
        public string Name { get; set; }
        public ICollection<TaskResponseDto> Tasks { get; set; }
    }
}
