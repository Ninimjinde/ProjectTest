using ALE.TimeRegistration.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ALE.TimeRegistration.Core.Entities
{
    public class Picture : EntityBase
    {
        public Uri Image { get; set; }
        public Project Project { get; set; }
    }
}
