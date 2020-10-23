﻿using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class Message : EntityBase
    {
        public string Text { get; set; }

        public Project Project { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}