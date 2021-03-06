﻿using System;

namespace ALE.TimeRegistration.Mob.Domain
{
    public class AppTaskRequestDto : DtoBase
    {
        public string TaskName { get; set; }
        public string Info { get; set; }
        public DateTime UploadDate { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
    }
}
