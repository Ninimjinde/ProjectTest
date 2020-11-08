using ALE.TimeRegistration.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class TaskResponseDto : DtoBase
    {
        public string TaskName { get; set; }
        public string Info { get; set; }
        public Project Project { get; set; }
        public ICollection<PictureResponseDto> Pictures { get; set; }
    }
}
