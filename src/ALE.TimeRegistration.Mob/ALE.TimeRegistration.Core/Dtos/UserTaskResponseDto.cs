using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class UserTaskResponseDto
    {
        public string TaskName { get; set; }
        public TimeSpan WorkTime { get; set; }
        public string ProjectName { get; set; }
    }
}
