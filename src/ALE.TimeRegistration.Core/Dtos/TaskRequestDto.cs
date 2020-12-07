using System;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class TaskRequestDto : DtoBase
    {
        public string TaskName { get; set; }
        public string Info { get; set; }
        public DateTime UploadDate { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
}
