﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Dtos
{
    public class TaskRequestDto
    {
        public string TaskName { get; set; }
        public string Info { get; set; }
        public DateTime UploadDate { get; set; }
        public string ProjectName { get; set; }
    }
}