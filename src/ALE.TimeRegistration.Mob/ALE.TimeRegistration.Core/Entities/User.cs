﻿using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
