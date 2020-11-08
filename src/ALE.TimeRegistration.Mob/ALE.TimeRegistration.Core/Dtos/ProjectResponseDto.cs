using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class ProjectResponseDto : DtoBase
    {
        public string Name { get; set; }
        public ICollection<TaskResponseDto> Tasks { get; set; }
    }
}
