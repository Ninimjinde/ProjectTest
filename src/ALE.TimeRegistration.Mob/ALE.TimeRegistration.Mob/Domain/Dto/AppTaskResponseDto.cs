using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Mob.Domain
{
    public class AppTaskResponseDto : DtoBase
    {
        public string TaskName { get; set; }
        public string Info { get; set; }
        public TimeSpan WorkTime { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime UploadDate { get; set; }
        public ICollection<string> TaskUsers { get; set; }
    }
}
